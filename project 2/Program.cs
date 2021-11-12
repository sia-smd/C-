using System;

namespace project_2
{
    class Program
    {
       
        static void Main(string[] args)
        {
         PersianDateTime now = PersianDateTime.Now;
         System.Console.WriteLine("enter your age");
         PersianDateTime age=PersianDateTime.Parse(Console.ReadLine()); 
         
         int a = now.Year-age.Year;
         System.Console.WriteLine(a);
        

        }
    }
}


