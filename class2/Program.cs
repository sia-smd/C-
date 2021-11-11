using System;
using System.Collections.Generic;

namespace New_folder
{
    class Program
    {
        static void Main(string[] args)
        {

            List<student> list = new List<student>();

            for (int i = 0; i < 5; i++)
            {
                student st = new student();
                System.Console.WriteLine("entre name");
                st.name = Console.ReadLine();

                System.Console.WriteLine("enter riazi number");
                st.r = check();
                System.Console.WriteLine("enter honar number");
                st.h = check();
                System.Console.WriteLine("enter dini number");
                st.d = check();

                list.Add(st);
            }
            int sum=0;
            int total=0;
            foreach (var item in list)
            {
                sum=(item.r+item.h+item.d)/3;
                System.Console.WriteLine(item.name);
                System.Console.WriteLine(sum);
                System.Console.WriteLine("-----");
                total=total+sum;
            }
            System.Console.WriteLine("avg total:"+total/5);
            
        }
   
       public static int check()
       {
           int r=0;
           while (!int.TryParse(Console.ReadLine(),out r))
           {
                System.Console.WriteLine("enter correct mark:");
           }
           return r;
       }
   
    }
    class student
    {

        public string name;
        int n_r;
        int n_h;
        int n_d;
        // درس ریاضی
        public int r
        {
            get { return n_r; }
            set
            {
                while (value < 0 || value > 20)
                {
                    System.Console.WriteLine("enter mark again:");
                    value = Program.check();

                }
                n_r = value;
            }
        }
        // درس هنر
        public int h
        {
            get { return n_h; }
            set
            {
                while (value < 0 || value > 20)
                {
                    System.Console.WriteLine("enter mark again:");
                    value =Program.check();

                }
                n_h = value;
            }
        }
        // درس دینی
        public int d
        {
            get { return n_d; }
            set
            {
                while (value < 0 || value > 20)
                {
                    System.Console.WriteLine("enter mark again:");
                    value = Program.check();

                }
                n_d = value;
            }
        }



    }
}
