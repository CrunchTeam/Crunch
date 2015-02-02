using System;
using System.Collections.Generic;
using System.Text;
using Windows.Security.Cryptography;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;
using System.Net.Http;
using System.Threading.Tasks;
using Windows.Data.Json;
using System.Runtime.Serialization.Json;
namespace Closet
{
    /// <summary>
    /// 从天气网获取天气
    /// </summary>
    class WeatherGetter
    {
        /// <summary>
        /// HMAC算法生成key
        /// </summary>
        /// <param name="publicKey">
        /// 为不包含 key 在内的完整 URL 其它部分（此处appid 为完整 appid）
        /// </param>
        /// <param name="privateKey">
        /// 天气网提供
        /// </param>
        /// <returns>
        /// 返回key值
        /// </returns>
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

        /// <summary>
        /// 异步读取天气数据存入content
        /// </summary>
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
            //http://open.weather.com.cn/data/?areaid=101010100&type=forecast_v&date=201501271237&appid=abf5bca8b45837c2

            var httpClient = new HttpClient();
            var content = await httpClient.GetStringAsync(url);
            Action<Task,object> readJson = WeatherGet;

            Task t=Task.Run(() =>
            {
                string c = content;
                //this.WeatherGet(c);
            });
            await t.ContinueWith(readJson, content);
        }

        public void WeatherGet(Task t,object s)
        {
            JsonObject jso = new JsonObject();
            JsonValue jsv = JsonValue.CreateStringValue(s.ToString());
     
        }

    }
}
