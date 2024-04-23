using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoConverter.Complex3rdPartyLib
{
    public class CodecFactory
    {
        public ICodec Extract(VideoFile file)
        {
            switch(file.Extension)
            {
                case "mp4":
                    return new MPEG4CompressionCodec();
                case "ogg":
                    return new OggCompressionCodec();
                default:
                    throw new NotImplementedException("CodecFactory: Extract method: Unknown codec type");
            }
        }
    }
}
