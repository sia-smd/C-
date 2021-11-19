using System;
using System.Collections.Generic;

namespace ostad
{
   public abstract class master
    {
        public abstract void add();
        public abstract bool delete(int id);
        public abstract bool edit(int id);

    }
    class ostads
    {
        public int id;
        public string name;
        public string phone;
    }
   public class process : master
    {
     
        public static int i = 1;
        static List<ostads> list_ostad = new List<ostads>();
        public override void add()
        {



            bool r = false;
            // add ostad
            do
            {

                ostads ostad_l = new ostads();
                ostad_l.id = i;

                System.Console.WriteLine($"enter name of master number {i}:");
                ostad_l.name = Console.ReadLine();

                list_ostad.Add(ostad_l);
                i++;
                r = next();
            } while (r == true);

            Console.Clear();

            // print list master
            print();
        }

        public override bool delete(int id)
        {
            foreach (var item in list_ostad)
            {
                if (item.id == id)
                {
                    list_ostad.Remove(item);
                    print();
                    return true;
                }

            }
            return false;
        }

        public override bool edit(int id)
        {
            foreach (var item in list_ostad)
            {
                if (item.id == id)
                {
                    System.Console.WriteLine("enter new name");
                    item.name = Console.ReadLine();
                    System.Console.WriteLine("enter new phone");
                    item.phone = Console.ReadLine();
                    print();
                    return true;
                }

            }
            return false;
        }
        public void print()
        {
            System.Console.WriteLine("List of master ");

            foreach (var item in list_ostad)
            {
                System.Console.WriteLine("code:" + item.id + "-" + item.name + "-" + item.phone);
            }
            System.Console.WriteLine();
        }

        public static bool next()
        {
            bool c = false;
            System.Console.WriteLine("do you want add another fruit ? y/n");
            string ent = Console.ReadLine();
            if (ent == "y" || ent == "Y" || ent == "yes" || ent == "YES")
            {
                c = true;
            }
            return c;
        }
    }
}