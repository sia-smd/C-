using System;


namespace class1
{
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
    class print
    {
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




}