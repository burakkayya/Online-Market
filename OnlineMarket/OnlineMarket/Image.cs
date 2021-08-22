using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    class Image
    {
        private string Filename;
        private string Path;

        public string filename
        {
            get
            {
                return Filename;
            }
            set
            {
                Filename = value;
            }
        }
        public string path
        {
            get
            {
                return Path;
            }
            set
            {
                Path = value;
            }
        }
    }
}
