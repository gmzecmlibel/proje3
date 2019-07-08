using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace ConsoleApplication32
{
    class Program
    {
        static List<string> sil(string s, char c)
        {
            List<string> gli = new List<string>();
            List<string>li=new List<string>();
            foreach (object o in li)
            {
                if (li.Contains(o))
                    gli.Add(o.ToString());
            }
            return gli;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(sil("adana", 'a'));
        }
    }
}
