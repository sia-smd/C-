using System;
using System.Collections.Generic;
using System.Linq;

namespace class1
{
    class Program
    {

        static void Main(string[] args)
        {
            List<fruit> list_fruit = new List<fruit>();
            List<order> list_order = new List<order>();
            List<factor> factor_L = new List<factor>();

            // add fruit
            Console.Clear();
            var f=fruit.add_fruit();

            // give order
            line("customer order");
            var o=order.add_order(f);
            
            Console.Clear();

            // print factor
            line("customer factor");
            factor.print_factor(f,o);

        }
        // check for end loop enter fruit
        public static bool next()
        {
            bool c = false;
            System.Console.WriteLine("do you want add another fruit ? y/n");
            string ent = Console.ReadLine();
            if (ent == "y" || ent == "Y" || ent == "yes" || ent == "yes")
            {
                c = true;
            }
            return c;
        }
       
        public static void line(string a)
        {
            System.Console.WriteLine("***********************************");
            System.Console.WriteLine($"**         {a}        **");
            System.Console.WriteLine("***********************************");
        }
    }
   
    
    
    class check
    {
        public static int ck1(string a)
        {
            int num = 0;
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                System.Console.WriteLine(a);
            }
            ck2(num);

            return num;
        }
        public static void ck2(int a)
        {
            if (a <= 0)
            {
                System.Console.WriteLine("enter bigger than 0");
                ck1("enter correct number");
            }
        }
    }


}

