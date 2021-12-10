using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphizer
{
    class Program
    {
        public class Operations
        {
            public int Add(int n1, int n2)
            {
                return n1 + n2;
            }

            public float Add(float n1, float n2)
            {
                return n1 + n2;
            }

            public decimal Add(decimal n1, decimal n2)
            {
                return n1 + n2;
            }

            public string Add(string n1, string n2)
            {
                return n1 +" "+ n2;
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine(@"
 +-+ +-+ +-+ +-+ +-+ +-+ +-+
 |C| |a| |n| |a| |r| |y| |s|
 +-+ +-+ +-+ +-+ +-+ +-+ +-+

[ Dev : Blesslin Jerish R | C# .net ]
");
            
            Console.WriteLine("");
            Console.WriteLine("Bonjour Canarys");
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString("F"));
            Console.WriteLine("");


            Console.WriteLine(" | Arithmetic Ops");

        start:
            Console.WriteLine("");
            Console.WriteLine("Int Ops");
            Operations op = new Operations();
            Console.WriteLine("First number ? ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number ? ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int sum = op.Add(n1, n2);
            Console.WriteLine($"Addition of both : {sum}");
            
            Console.WriteLine("");
            Console.WriteLine("Float Ops");
            Console.WriteLine("First number ? ");
            float fn1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Second number ? ");
            float fn2 = Convert.ToSingle(Console.ReadLine());
            float fsum = op.Add(fn1, fn2);
            Console.WriteLine($"Addition of both : {fsum}");

            Console.WriteLine("");
            Console.WriteLine("Dec Ops");
            Console.WriteLine("First number ? ");
            decimal dn1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Second number ? ");
            decimal dn2 = Convert.ToDecimal(Console.ReadLine());
            decimal dsum = op.Add(dn1, dn2);
            Console.WriteLine($"Addition of both : {dsum}");

            Console.WriteLine("");
            Console.WriteLine("Str Ops");
            Console.WriteLine("First String ? ");
            string s1 = Console.ReadLine();
            Console.WriteLine("Second String ? ");
            string s2 = Console.ReadLine();
            string ssum = op.Add(s1, s2);
            Console.WriteLine($"Concat of both : {ssum}");
            
            Console.ReadLine();

            goto start;
        }
    }
}
