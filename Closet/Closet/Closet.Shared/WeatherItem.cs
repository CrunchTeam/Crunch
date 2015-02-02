using System;
using System.Collections.Generic;
using System.Text;

namespace Closet
{
    /// <summary>
    /// 气象信息基类
    /// </summary>
    class WeatherItem
    {
        private int areaId;
        /// <summary>
        /// 区域代码
        /// </summary>
        public int AreaId
        {
            get { return areaId; }
            set { areaId = value; }
        }

        private int tempDay0;
        /// <summary>
        /// 今天白天气温
        /// </summary>
        public int TempDay0
        {
            get { return tempDay0; }
            set { tempDay0 = value; }
        }

        private int tempNight0;
        /// <summary>
        /// 今天晚上气温
        /// </summary>
        public int TempNight0
        {
            get { return tempNight0; }
            set { tempNight0 = value; }
        }

        private int tempDay1;
        /// <summary>
        /// 明天白天气温
        /// </summary>
        public int TempDay1
        {
            get { return tempDay1; }
            set { tempDay1 = value; }
        }

        private int tempNight1;
        /// <summary>
        /// 明天晚上气温
        /// </summary>
        public int TempNight1
        {
            get { return tempNight1; }
            set { tempNight1 = value; }
        }

        private int tempDay2;
        /// <summary>
        /// 后天白天气温
        /// </summary>
        public int TempDay2
        {
            get { return tempDay2; }
            set { tempDay2 = value; }
        }

        private int tempNight2;
        /// <summary>
        /// 后天晚上气温
        /// </summary>
        public int TempNight2
        {
            get { return tempNight2; }
            set { tempNight2 = value; }
        }

        private int phenDay0;
        /// <summary>
        /// 今天白天天气现象
        /// </summary>
        public int PhenDay0
        {
            get { return phenDay0; }
            set { phenDay0 = value; }
        }

        private int phenNight0;
        /// <summary>
        /// 今天晚上天气现象
        /// </summary>
        public int PhenNight0
        {
            get { return phenNight0; }
            set { phenNight0 = value; }
        }

        private int phenDay1;
        /// <summary>
        /// 明天白天天气现象
        /// </summary>
        public int PhenDay1
        {
            get { return phenDay1; }
            set { phenDay1 = value; }
        }

        private int phenNight1;
        /// <summary>
        /// 明天晚上天气现象
        /// </summary>
        public int PhenNight1
        {
            get { return phenNight1; }
            set { phenNight1 = value; }
        }

        private int phenDay2;
        /// <summary>
        /// 后天白天天气现象
        /// </summary>
        public int PhenDay2
        {
            get { return phenDay2; }
            set { phenDay2 = value; }
        }

        private int phenNight2;
        /// <summary>
        /// 后天晚上天气现象
        /// </summary>
        public int PhenNight2
        {
            get { return phenNight2; }
            set { phenNight2 = value; }
        }
    }
}
