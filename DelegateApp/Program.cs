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
            /* Baslangıc Adımı */
            Console.WriteLine($"5'in Karesi : {kareAl(5)}");
            /* 1.Adım */
            MyDelegate del = new MyDelegate(kareAl);
            Console.WriteLine($"5'in Karesi : {del(5)}");
            /* 2.Adım */
            MyDelegate my = delegate (int a) { return (a * a); };
            Console.WriteLine($"5'in Karesi : {my(5)}");
            /* 3.Adım */
            MyDelegate kare = (int sayi) => { return (sayi * sayi); };
            Console.WriteLine($"5'in Karesi : {kare(5)}");
            /* 4.Adım */
            MyDelegate kare2 = (int sayi) => (sayi * sayi);
            Console.WriteLine($"5'in Karesi : {kare2(5)}");
            /*5.Adım*/
            MyDelegate kare3 = sayi => (sayi * sayi);
            Console.WriteLine($"5'in Karesi : {kare3(5)}");
            LamdaKullanimi();
            Console.ReadLine();
            
        }
        public static int kareAl(int a)
        {
            return (a*a);
        }
        static void LamdaKullanimi()
        {
            int[] tumRakamlar = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            IEnumerable<int> tekRakamlar = tumRakamlar.Where(x => x % 2 == 1);
            IEnumerable<int> ciftRakamlar = tumRakamlar.Where(x => x % 2 == 0);
            Console.WriteLine("Tek Rakamlar : ");
            foreach (int rakam in tekRakamlar)
            {
                Console.WriteLine(rakam);
            }
            Console.WriteLine("Cift Rakamlar : ");
            foreach (int rakam in ciftRakamlar)
            {
                Console.WriteLine(rakam);
            }
            Console.ReadKey();
           
        }
    }
}
