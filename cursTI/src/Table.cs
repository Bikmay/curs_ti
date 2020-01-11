using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursTI.src
{
    class Table
    {

        public string[] arrayLecsems;

        public Table(string TableName)
        {
            StreamReader sr = new StreamReader("./tables/TablesConfig.txt");
            string line;
            string[] arr = new string[2];
            int numberElementsOfArrayLecsems=0;

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                arr=line.Split(' ');
                if (arr[0].Equals(TableName))
                {
                    numberElementsOfArrayLecsems = int.Parse(arr[1]);
                }
            }
            sr.Close();

            this.arrayLecsems = new string[numberElementsOfArrayLecsems];
        }

        public static int AddRouteToTable(string TableName, string lecs)
        {
            if (FindRoute(TableName,lecs) != 0)
            {
                StreamWriter writer = new StreamWriter("./tables/" + TableName + ".txt");

                writer.WriteLine(lecs);
                writer.Close();
                return inc(TableName);
                
            }
            else
            {
                return 0;
            }
        }

        public static int FindRoute(string TableName,string lecs)
        {
            StreamReader sr = new StreamReader("./tables/" + TableName + ".txt");
            string line;
            int count = 1;

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                if (line.Equals(lecs))
                    return count;
                else
                {
                    count++;
                }
            }
            sr.Close();
            return 0;
        }

        private static int inc(string TableName)
        {
            string[,] f = new string[4,2];

            StreamReader sr = new StreamReader("./tables/TablesConfig.txt");
            string line;
            int num = 0, i = 0;
     

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                f[i, 0] = line.Split(' ')[0];
                f[i, 1] = line.Split(' ')[1];
                if (f[i,0].Equals(TableName))
                {
                    num = int.Parse(f[i, 1])+1;
                    f[i, 1] = num.ToString();
                }
                


                i++;
            }
            sr.Close();

            StreamWriter writer = new StreamWriter("./tables/TablesConfig.txt");
            File.WriteAllText("./tables/TablesConfig.txt", "");
            foreach (string a in f)
            {
                writer.WriteLine(a[0]+" "+a[1]);
            }

            return num;
        }

        public static bool WriteNum(int num)
        {
            return 0!=AddRouteToTable("TN", num.ToString());
            
        }
    }
}
