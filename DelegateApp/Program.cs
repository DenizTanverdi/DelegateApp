using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApp
{
    class Program
    {
        delegate int MyDelegate(int a);
        static void Main(string[] args)
        {
            MyDelegate del = new MyDelegate(kareAl);
            Console.WriteLine($"5'in Karesi : {del(5)}");
            MyDelegate my = delegate (int a) { return (a * a) };
            Console.ReadLine();
            
        }
        public static int kareAl(int a)
        {
            return (a*a);
        }
    }
}
