using System;

namespace ers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            human x=new human();
            x.breath();
            x.move();
            fish y=new fish();
            y.breath();
            y.move();

            
            myclass t=new myclass();
            t.a=2;
            t.b="2";
            t.p=1;
            t.t=true;
            
        }
    
    }
    abstract class process
    {
        public abstract int save(int a);
        public abstract void delete (string b);

    }
    class test : process
    {
        public override void delete(string b)
        {
            System.Console.WriteLine("done");
        }

        public override int save(int a)
        {
            return 1;
        }
    }
     partial  class myclass
     {
        public int a;
        public string b;
     }

     partial class myclass
     {
        public int p;
        public bool t;
     }



}
