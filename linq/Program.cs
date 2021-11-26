using System;
using System.Collections.Generic;
using System.Linq;
namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
        //    employer e=new employer();
        //    e.add();
        //    e.sort();

        List<string> L_c=new List<string>
        {
            "asus",
            "nokia",
            "sony",
            "samsung",
            "LG",
            "motorela",
            "sanam",
            "iphone",
            "xiaomi",
            "huawei"
        };
        string ans="y";
        int i=1;
        

        do
        {
            Console.Clear();
            var s=L_c.Skip((i-1)*2).Take(2).ToList();
            s.ForEach(k1=>System.Console.WriteLine(k1));
            System.Console.WriteLine("enter page number");
            i=int.Parse(Console.ReadLine());     
        } while (ans=="y");

         
            
        }
    }
    
    class employer
    {
        int id;
        string Name;
        int Age;
        string Gender;
        int Price;
        string Job;

        public static int i=1;

        public static List<employer> employer_list=new List<employer>();

        public void add()
        {
            // do
            // {
              employer f= new employer();  
            //   emp.id=i;
            //   System.Console.Write($"enter name employer #{i}:");
            //   emp.name=Console.ReadLine();
            //   System.Console.Write($"enter age employer #{i}:");
            //   emp.age=int.Parse(Console.ReadLine());
            //   System.Console.Write($"enter gender employer #{i}:");
            //   emp.gender=bool.Parse(Console.ReadLine());
            //   System.Console.Write($"enter salary employer #{i}:");
            //   emp.salary=int.Parse(Console.ReadLine());
            //   System.Console.Write($"enter job locatiob employer #{i}:");
            //   emp.job_location=Console.ReadLine();
            //   employer_list.Add(emp);
            //   i++;
            // } while (i<5);

                       
            f.Name="ALi";
            f.Price=16000;
            f.Gender="Male";
            f.Age=47;
            f.Job="Admin";
            employer_list.Add(f);
            employer g= new employer();
            g.Name="sara";
            g.Price=2700;
            g.Gender="Female";
            g.Age=27;
            g.Job="Operator";
            employer_list.Add(g);
             employer k= new employer();
            k.Name="Mohammad";
            k.Price=5500;
            k.Gender="Male";
            k.Age=23;
            k.Job="G_Father";
            employer_list.Add(k);
            employer o= new employer();
            o.Name="Mona";
            o.Price=12000;
            o.Gender="Female";
            o.Age=32;
            o.Job="Full_Developer";
            employer_list.Add(o);
             employer t= new employer();
            t.Name="Hasan";
            t.Price=9000;
            t.Gender="Male";
            t.Age=26;
            t.Job="Front_Developer";
            employer_list.Add(t);
        }

        public void sort()
        {
            var l1=employer_list.OrderByDescending(p => p.Age>40).ToList();
            l1.ForEach (k => System.Console.WriteLine(k.Name+"-"+k.Age));

        }
         public void salry()
        {
            var l1=employer_list.OrderBy(p => p.Price>10000 && p.Price<13000 ).ToList();
            l1.ForEach (k => System.Console.WriteLine(k.Name+"-"+k.Age));

        }
         public void female()
        {
            var l1=employer_list.Any(p => p.Gender=="Female" && p.Price<3000 );
            System.Console.WriteLine("is female lower salary ? "+l1);

        }
        public void sum()
        {
            int sum=employer_list.Sum(p => p.Price);
            System.Console.WriteLine("sum all salary :"+sum);

            var avg=employer_list.Where(k => k.Gender=="Male").Average( a => a.Price);
            System.Console.WriteLine("male salary avrage"+avg);
            var maxP=employer_list.Max(l=>l.Price);
            var max=employer_list.Where(f=>f.Price==maxP).FirstOrDefault();
            System.Console.WriteLine("max location"+max.Job);
            var avgAge=employer_list.Average(A=> A.Age);
            System.Console.WriteLine("avrage all age"+avgAge);


        }
    }
}
