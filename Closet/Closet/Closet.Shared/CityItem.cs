using System;
using System.Collections.Generic;
using System.Text;

namespace Closet
{
    class CityItem
    {
        private int cityId;

        /// <summary>
        /// 城市代码
        /// </summary>
        public int CityId
        {
            get { return cityId; }
            set { cityId = value; }
        }

        private string provinceE;
        /// <summary>
        /// 省英文
        /// </summary>
        public string ProvinceE
        {
            get { return provinceE; }
            set { provinceE = value; }
        }

        private string provinceC;
        /// <summary>
        /// 省中文
        /// </summary>
        public string ProvinceC
        {
            get { return provinceC; }
            set { provinceC = value; }
        }

        private string cityE;
        /// <summary>
        /// 市英文
        /// </summary>
        public string CityE
        {
            get { return cityE; }
            set { cityE = value; }
        }

        private string cityC;
        /// <summary>
        /// 市中文
        /// </summary>
        public string CityC
        {
            get { return cityC; }
            set { cityC = value; }
        }

        private string countyE;
        /// <summary>
        /// 镇英文
        /// </summary>
        public string CountyE
        {
            get { return countyE; }
            set { countyE = value; }
        }

        private string countyC;
        /// <summary>
        /// 镇中文
        /// </summary>
        public string CountyC
        {
            get { return countyC; }
            set { countyC = value; }
        }

        private string nationE;
        /// <summary>
        /// 国英文
        /// </summary>
        public string NationE
        {
            get { return nationE; }
            set { nationE = value; }
        }

        private string nationC;
        /// <summary>
        /// 国中文
        /// </summary>
        public string NationC
        {
            get { return nationC; }
            set { nationC = value; }
        }
    }
}
