using System;
using System.Collections.Generic;
using System.Text;
using Windows.Security.Cryptography;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;
using System.Net.Http;
using System.Threading.Tasks;

namespace Closet
{
    class GetWeather
    {
        public string CreateHMAC(string publicKey, string privateKey)
        {
            string strAlgName = MacAlgorithmNames.HmacSha1;
            MacAlgorithmProvider objMacProv = MacAlgorithmProvider.OpenAlgorithm(strAlgName);

            IBuffer data = CryptographicBuffer.ConvertStringToBinary(publicKey, BinaryStringEncoding.Utf8);
            IBuffer buffKeyMaterial = CryptographicBuffer.ConvertStringToBinary(privateKey, BinaryStringEncoding.Utf8);
            CryptographicKey hmacKey = objMacProv.CreateKey(buffKeyMaterial);

            var buffHMAC = CryptographicEngine.Sign(hmacKey, data);

            return CryptographicBuffer.EncodeToBase64String(buffHMAC);
        }

        public async void GetAsync()
        {
            string areaId = "101010100";
            string type = "forecast_v";
            string date = System.DateTime.Now.ToString("yyyyMMddHHmm");
            string appId = "abf5bca8b45837c2";
            string privateKey = "90661f_SmartWeatherAPI_fc1316b";
            string publicKey = string.Format("http://open.weather.com.cn/data/?areaid={0}&type={1}&date={2}&appid={3}",
                areaId, type, date, appId);

            string key = CreateHMAC(publicKey, privateKey);
            string url = string.Format(@"http://open.weather.com.cn/data/?areaid={0}&type={1}&date={2}&appid={3}&key={4}",
                areaId, type, date, appId.Substring(0, 6), key);

            var httpClient = new HttpClient();
            var content = await httpClient.GetStringAsync(url);
            await Task.Run(() =>
            {
                string c = content;
            });
        }
    }
}
