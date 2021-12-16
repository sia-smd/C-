using System;

namespace sql
{
    class Program
    {
        static void Main(string[] args)
         {
             do
             {
                 Console.Clear();
                 
                 System.Console.WriteLine("select job:  1-insert product  2-insert category");

                 int ans = int.Parse(Console.ReadLine());
                 switch (ans)
                 {
                     case 1:
                      db_product.insert_product();

                         break;
                         case 2:
                      db_product.insert_category();

                         break;

                         case 3 :
                         db_product.del_category();
                         break;
                     
                 }
                 
             } while (true);

           
           
             
             // do
        // { Console.Clear();
        
        //     System.Console.WriteLine("1-insert   2-select name  3-price between 4-delete product 5-update product");
        //     int a=int.Parse(Console.ReadLine());
            
        //     switch (a)
        //     {
        //         case 1:
        //             db_product.insert_producte();
        //             break;
        //             case 2:
        //             db_product.select_name();
        //             break;
        //             // case 3:
        //             // db_product.price_product();
        //             // break;
        //             // case 4:
        //             // db_product.delete_product();
        //             // break;
        //             // case 5:
        //             // db_product.insert_producte();
        //             // break;
        //     }
            
        // } while (true);

        
           



        }
    }
}
