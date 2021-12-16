using System;
using Dapper;
using System.Data.SqlClient;
using System.Linq;

namespace sql
{
    class db_product
    {
        static string conection = "Data source =.;initial catalog =shop;integrated security =true";


        public static void insert_product()
        {   Console.Clear();
        
             using (SqlConnection db=new SqlConnection(conection))
            {
                vm_product p=new vm_product();
                var list=db.Query<vm_category>("SELECT c1.category_id,c1.category_name FROM dbo.category c1 LEFT JOIN dbo.category c2 ON c1.category_id=c2.parent WHERE c2.category_id IS null").ToList();
                foreach (var item in list)
                 {
                     System.Console.WriteLine(item.category_id+"-"+item.category_Name);
                 }
                 System.Console.Write("enter producte name:");
                 p.product_name=Console.ReadLine();
                 System.Console.Write("enter producte price:");
                 p.product_price=int.Parse(Console.ReadLine());
                 System.Console.Write("enter producte count:");
                 p.count=int.Parse(Console.ReadLine());
                 System.Console.Write("enter producte category:");
                 p.category=int.Parse(Console.ReadLine());
                 string ins = "EXECUTE dbo.insert_product @name = "+p.product_name+",@price ="+p.product_price+",@count = "+p.count+", @category = "+p.category;
                 db.Execute(ins);
                 System.Console.WriteLine("success");
                 Console.ReadKey();
            }
        }

                public static void insert_category()
        {    Console.Clear();
             using (SqlConnection db=new SqlConnection(conection))
            {
                var list=db.Query<vm_category>("SELECT category_id,category_name FROM dbo.category WHERE active=1").ToList();
                foreach (var item in list)
                 {
                     System.Console.WriteLine(item.category_id+"-"+item.category_Name);
                 }
                vm_category c=new vm_category();
                 System.Console.Write("enter category name:");
                 c.category_Name=Console.ReadLine();
                 System.Console.Write("enter parent (0 for base category):");
                 c.parent=int.Parse(Console.ReadLine());
                 string ins = "EXECUTE dbo.insert_category @name ="+c.category_Name+",@parent ="+c.parent;
                 db.Execute(ins);
                 System.Console.WriteLine("success");
                 Console.ReadKey();
            }
        }
          public static void del_category()
        {    Console.Clear();
             using (SqlConnection db=new SqlConnection(conection))
            {
                var list=db.Query<vm_category>("SELECT category_id,category_name FROM dbo.category WHERE parent<>0 AND active=1").ToList();
                foreach (var item in list)
                 {
                     System.Console.WriteLine(item.category_id+"-"+item.category_Name);
                 }
                 System.Console.Write("choose id from list :");
                 int ans =int.Parse(Console.ReadLine());
                 string a="EXECUTE dbo.del_category "+ans; 
                 db.Execute(a);
                 System.Console.WriteLine("success");
                 Console.ReadKey();
            }




        // public static void show_city()
        // {
        //     using (SqlConnection db=new SqlConnection(conection))
        //     {
        //          var list=db.Query<vcolm_city>("SELECT * FROM state INNER JOIN city ON city.state_id=state.state_id").ToList();
        //          foreach (var item in list)
        //          {
        //              System.Console.WriteLine(item.state_name+"-"+item.city_name);
        //          }

        //     }

        // }

        // public static void insert_producte()
        // {
        //      vm_product product=new vm_product();
        //     System.Console.Write("enter name product :");
        //     product.product_name=Console.ReadLine();
        //     System.Console.Write("enter price :");
        //     product.product_price=int.Parse(Console.ReadLine());
            
        //     using ( SqlConnection db=new SqlConnection(conection))
        //     {
        //         string ins="insert into product values (@product_name,@product_price)";
        //         db.Execute(ins,product);
        //     }
        // }

        // public static void select_name()
        // {
        //     System.Console.Write("enter a letter :");
        //     string a=Console.ReadLine();
            
        //      using ( SqlConnection db=new SqlConnection(conection))
        //     {
        //         var list=db.Query<vm_product>($"SELECT * FROM product WHERE product_name LIKE '%{a}%'").ToList();
        //         foreach (var item in list)
        //         {
        //             System.Console.WriteLine(item.product_name);  
                    
        //         }
        //     }
        //     Console.ReadKey();
        // }

        // public static void price_product()
        // {
        //   var list=db.Query<vm_product>($"SELECT * FROM product WHERE product_price").ToList();
        //         foreach (var item in list)
        //         {
        //             System.Console.WriteLine(item.product_name);  
                    
        //         }
        //     }
        //     Console.ReadKey();  



        // }



    }
  class vm_city
    {
        public int city_id { get; set; }
        public string city_name { get; set; }
       // public int state_id { get; set; }
        public string state_name { get; set; }
    } 
    
    class vm_product
    {
        public int product_id { get; set; }
        public string product_name { get; set; }
        public int product_price { get; set; }
        public int count { get; set; }
        public int category { get; set; }
           
    }

     class vm_category
    {
       public int category_id { get; set; }
       public string category_Name { get; set; }
       public int parent { get; set; }
    }
}
}