using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptEd
{
    class Script
    {
        public long offset;
        public string bytes;

        public Script(long l, string s)
        {
            offset = l;
            bytes = s;
        }

        public void setOffset(long temp)
        {
            offset = temp;
        }

        public void setBytes(string str)
        {
            bytes = str;
        }

        public long getOffset()
        {
            return offset;
        }

        public string getBytes()
        {
            return bytes;
        }
        
    }
}
