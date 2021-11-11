using System;
using System.Collections.Generic;
using System.Linq;

namespace class1
{
    class factor
    {
        string name;
        int weight;
        int price;
        public string _name
        {
            get { return name; }
            set { name = value; }
        }
        // enter weight
        public int _weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public int _price
        {
            get { return price; }
            set { price = value; }
        }
        public static void print_factor(List<fruit> list_f, List<order> order_L)
        {

            int sum = 0;

            foreach (var x in order_L)
            {
                var name = list_f.First(d => d.id == x.cd).name;
                var price = list_f.First(d => d.id == x.cd).fr;
                var s = x.wg;
                System.Console.WriteLine("name ----weight------price------sum");
                System.Console.WriteLine(name + "       " + s + "       " + price + "       " + (s * price));
                sum = sum + (s * price);
            }
            System.Console.WriteLine();
            System.Console.WriteLine("total------------------------" + sum);


        }


    }
}