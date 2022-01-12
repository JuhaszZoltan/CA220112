using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA220112
{
    internal class Program
    {
        static List<Futo> futok = new List<Futo>();
        static void Main()
        {
            F02();
            F03();
            Console.ReadKey(true);
        }

        private static void F03()
        {
            Console.WriteLine($"3. feladat: Egyéni indulók száma: {futok.Count} fő");
        }

        private static void F02()
        {
            using (var sr = new StreamReader(@"..\..\res\ub2017egyeni.txt", Encoding.UTF8))
            {
                var fejlec = sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    futok.Add(new Futo(sr.ReadLine()));
                }
            }
        }
    }
}
