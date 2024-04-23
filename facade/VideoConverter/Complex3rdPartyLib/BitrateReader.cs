using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoConverter.Complex3rdPartyLib
{
    public class BitrateReader
    {
        public static Buffer Read(string filename, ICodec sourceCodec)
        {
            return new Buffer();
        }

        public static VideoFile Convert(Buffer buffer, ICodec destinationCodec, string originalFilename)
        {
            return new VideoFile(Path.GetFileNameWithoutExtension(originalFilename) + "." + destinationCodec.Format);
        }
    }
}
