using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptEd
{
    class compiledScript
    {
        long offset;
        byte[] bytes;
        public compiledScript(long o, byte[] b)
        {
            offset = o;
            bytes = b;
        }

        public compiledScript()
        {

        }

        public void setBytes(byte[]b)
        {
            bytes = b;
        }

        public void setOffset(long o)
        {
            offset = o;
        }

        public long getOffset()
        {
            return offset;
        }

        public byte[] getBytes()
        {
            return bytes;
        }
    }
}
