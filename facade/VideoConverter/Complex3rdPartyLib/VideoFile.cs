using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoConverter.Complex3rdPartyLib
{
    public class VideoFile
    {
        public string FileName { get; private set; }
        public string Extension
        {
            get
            {
                return FileName.Substring(FileName.LastIndexOf('.') + 1);
            }
        }

        public VideoFile(string filename)
        {
            FileName = filename;
        }
        public File ConvertToFile()
        {
            return new File(this.FileName);
        }
    }
}
