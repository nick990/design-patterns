using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoConverter
{
    public class File
    {
        public string FileName { get; private set; }
        public string Extension
        {
            get
            {
                return FileName.Substring(FileName.LastIndexOf('.') + 1);
            }
        }
        public File(string fileName)
        {
            FileName = fileName;
        }
    }
}
