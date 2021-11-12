using System;
using System.Collections.Generic;

namespace class1
{
    class order
    {
        int code;
        int weight;
        // enter code of fruit
        public int cd
        {
            get { return code; }
            set { code = value; }
        }
        // enter weight
        public int wg
        {
            get { return weight; }
            set { weight = value; }
        }
   


    public static List<order> add_order(List<fruit> L)
    {
        List<order> order_L = new List<order>();
        bool r=false;
        do
            {
                order ord = new order();
                System.Console.WriteLine("enter code of fruit");

                var result = "";
                do
                {
                    ord.cd = check.ck1("enter correct code");
                    result = Convert.ToString(L.Find(u => u.id == ord.cd));
                    if (result != "class1.fruit")
                    {
                        System.Console.WriteLine("this code not available. use another code");
                    }
                } while (result != "class1.fruit");


                System.Console.WriteLine("enter weight");
                ord.wg = check.ck1("enter correct weight");
                order_L.Add(ord);
                r = print.next();
            } while (r == true);
            return order_L;

    }
     

    }


}