using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursTI.src
{
    class LecsAnalys
    {
        private static Letter let;

        public static char GC()
        {
            using (StreamReader sr = File.OpenText("../resource/prog.txt"))
            {
                while (sr.Peek() != -1)
                {
                    char c = (char)sr.Read();
                    

                }
            }
        }


        
    }
}
