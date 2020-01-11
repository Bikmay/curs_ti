using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static cursTI.src.Table;

namespace cursTI.src
{
    class Lecsem
    {
        public string S;

        public bool add(Letter let)
        {
            S += let.GetActualLetter();
            return true;
        }


        public bool Nill()
        {
            S = "";
            return true;
        }

        public int Look(string TableName)
        {
            return FindRoute(TableName, S);
        }

        public int Put(string TableName)
        {
            return AddRouteToTable(TableName, S);
        }

        public bool Out(int n,int k)
        {
            return WriteNum(n) & WriteNum(k);
            
        }
    }
}
