using System;

namespace sql2
{
    class Program
    {
        static void Main(string[] args)
        {
            // db_student.delete_student(2);

            vm_student st=new vm_student();
            System.Console.Write("enter id:");
            int id_s=int.Parse(Console.ReadLine());
            var select_st=db_student.select(id_s);
            select_st.name="hesam";
            db_student.update_student(select_st);
           
            
        }
    }
}
