using System;
using System.Collections.Generic;
using System.Linq;

namespace class1
{
    class Program
    {

        static void Main(string[] args)
        {
            

            // add fruit
            Console.Clear();
            var f=fruit.add_fruit();

            // give order
            print.line("customer order");
            var o=order.add_order(f);
            
            Console.Clear();

            // print factor
            print.line("customer factor");
            factor.print_factor(f,o);

        }
        // check for end loop enter fruit
        
    }
   
    
    
  


}

