using System;
using System.Collections.Generic;
using System.Text;

namespace Closet
{
    class PictureItem
    {
        private string picName;

        public string PicName
        {
            get { return picName; }
            set { picName = value; }
        }

        private string[] picTags = new string[5];

        public string[] PicTags
        {
            get { return picTags; }
            set { picTags = value; }
        }

        
        private bool isPublish;

        public bool IsPublish
        {
            get { return isPublish; }
            set { isPublish = value; }
        }

    }
}
