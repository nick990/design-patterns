using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoConverter.Complex3rdPartyLib;

namespace VideoConverter
{
    public class SimpleVideoConverter
    {
        public File Convert(string filename, string format)
        {
            VideoFile videoFile = new VideoFile(filename);
            ICodec sourceCodec = (new CodecFactory()).Extract(videoFile);
            ICodec destinationCodec;
            switch (format)
            {
                case "mp4":
                    destinationCodec = new MPEG4CompressionCodec();
                    break;
                case "ogg":
                    destinationCodec = new OggCompressionCodec();
                    break;
                default:
                    throw new ArgumentException("Format not supported");
            }
            Complex3rdPartyLib.Buffer buffer = BitrateReader.Read(filename, sourceCodec);
            VideoFile result = BitrateReader.Convert(buffer, destinationCodec,filename);
            return result.ConvertToFile();
            
        }
    }
}
