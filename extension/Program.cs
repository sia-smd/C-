using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace extension
{
    class Program
    {
        delegate void d(int a,int b);
        static void Main(string[] args)
        {
            string s = DateTime.Now.toshamsi();
            System.Console.WriteLine(s);
            // متد با چند خروجي

            int q, w;
            int c = sum(5, 6, out q, out w);
            System.Console.WriteLine(c);
            System.Console.WriteLine(q);
            System.Console.WriteLine(w);

            List<int> w1 = new List<int> { 1, 2, 3, 6, 8, 12, 23 };
            System.Console.WriteLine(w1.fard());
            System.Console.WriteLine(w1.fardL());
            //  deligate 
            d x=new d(sum);
            x+=zarb;
            x+=div;
            x(1,3);



        }

        public static void sum(int a, int b)
        {
            System.Console.WriteLine(a + b);
        }
        public static void div(int a, int b)
        {
            System.Console.WriteLine(a / b);
        }
        public static void zarb(int a, int b)
        {
            System.Console.WriteLine(a * b);
        }


        public static int sum(int a, int b, out int z, out int x)
        {
            z = ++a;
            x = --b;
            return a + b;
        }
    }
    //  براي  extention  
    // كلاس استاتيك
    public static class shamsi
    {
        // متد استاتيك
        // كلمه this  
        //داشته باشه
        public static string toshamsi(this DateTime a)
        {
            PersianCalendar s = new PersianCalendar();
            // چه مدلي بنويسه
            //   tostring("00")  دو رقمي بنويسه 
            // tostring("#.0")    12,000,000
            string date = s.GetYear(a) + "/" + s.GetMonth(a).ToString("00") + "/" + s.GetDayOfMonth(a).ToString("00") + "  " + s.GetHour(a).ToString("00") + ":" + s.GetMinute(a).ToString("00");

            return date;
        }
        public static int fard(this List<int> a)
        {
            int sum = 0;
            foreach (var item in a)
            {
                if (item % 2 != 0)
                {
                    sum = sum + item;
                }

            }
            return sum;

        }
        public static int fardL(this List<int> a)
        {

            return a.Where(p => p % 2 != 0).Sum();

        }



    }
}
