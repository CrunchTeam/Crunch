using System;
using System.Collections.Generic;
using System.Text;

namespace Closet
{
    /// <summary>
    /// 图片基类
    /// </summary>
    class PictureItem
    {
        private string picName;
        /// <summary>
        /// 图片名
        /// </summary>
        public string PicName
        {
            get { return picName; }
            set { picName = value; }
        }

        private string[] picTags = new string[5];
        /// <summary>
        /// 5个标签
        /// </summary>
        public string[] PicTags
        {
            get { return picTags; }
            set { picTags = value; }
        }

        
        private bool isPublish;
        /// <summary>
        /// 是否共享到云
        /// </summary>
        public bool IsPublish
        {
            get { return isPublish; }
            set { isPublish = value; }
        }

    }
}
