using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    class Product
    {
        private string Name;
        private string Description;
        private float Price;
        private Image Picture=new Image();

        public string name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        public string description
        {
            get
            {
                return Description;
            }
            set
            {
                Description = value;
            }
        }

        public float price
        {
            get
            {
                return Price;
            }
            set
            {
                Price = value;
            }
        }

        public Image picture
        {
            get
            {
                return Picture;
            }
            set
            {
                Picture = value;
            }
        }
    }
}
