using System;
using Dapper;
using System.Data.SqlClient;
using System.Linq;

namespace sql2
{
    class db_student
    {
        static string conection = "Data source =.;initial catalog =sia;integrated security =true";

        public static void delete_student(int id)
        {
            string a="DELETE FROM student WHERE id=@x";

            using ( SqlConnection db=new SqlConnection(conection))
            {
                // var list= db.Query("select * from student where id=@y",new {y=3}).FirstOrDefault();
                db.Execute(a,new{x=id}); 
            }
            
        }

        public static vm_student select(int id)
        {
             using ( SqlConnection db=new SqlConnection(conection))
            {
                var list= db.Query<vm_student>("select * from student where id=@y",new {y=id}).FirstOrDefault();
                return list;
            }
        }
        public static void update_student(vm_student st)
        {
            
            string a="UPDATE student SET name=@Name,lastname=@lastname,age=@age WHERE id=@id";
             using ( SqlConnection db=new SqlConnection(conection))
            {
                db.Execute(a,st);
            }

        }

         public static void getstudent()
        {

            using (SqlConnection Db = new SqlConnection(conection))
            {
                var list = Db.Query<vm_student>("select * from student").ToList();
                foreach (var item in list)
                {
                    System.Console.WriteLine("ID:" + item.id + " name:" + item.name + "lastname" + item.lastname);

                }
            }
        }



    }

    class vm_student
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public int age { get; set; }
        
    }

}