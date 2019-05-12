using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_as_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Moe Better";
            string s2 = "Larry Good";
            string s3 = "Curly Best";
            int x = s1.IndexOf(" ");
            int y = s2.IndexOf(" ");
            int z = s3.IndexOf(" ");
            string s4 = s1.Substring(0, x) + " is" + s2.Substring(y).ToLower() + ", " + s2.Substring(0, y) + 
                " is" + s1.Substring(x).ToLower() + ", but " + s3.Substring(0, z) + " is" + s3.Substring(z).ToLower() + ".";
            Console.WriteLine(s4);
            //Console.WriteLine(s4.ToUpper());
            Console.ReadLine();
        }
    }
}
