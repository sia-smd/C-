using System;
using System.Collections.Generic;

namespace class1
{
    class fruit
    {
        public int id;
        public string name;
        int price;
        // enter price
        public int fr
        {
            get { return price; }
            set { price = value; }
        }
        // enter and check price


        public static List<fruit> add_fruit()
        {
            List<fruit> list_f = new List<fruit>();
            int i = 1;
            bool r = false;
            // add fruit
            do
            {
                fruit fr_n = new fruit();
                System.Console.WriteLine($"enter name of fruit number {i}:");
                fr_n.name = Console.ReadLine();
                fr_n.id = i;
                System.Console.WriteLine($"enter price of fruit number {i}:");
                fr_n.fr = check.ck1("enter correct price");
                list_f.Add(fr_n);
                i++;
                r = Program.next();
            } while (r == true);


            Program.line("List of fruit ");
            // print list fruit
            Console.Clear();


            foreach (var item in list_f)
            {
                System.Console.WriteLine("code:" + item.id + "-" + item.name + " // ");
            }
            System.Console.WriteLine();

            return list_f;
        }

        




    }
}