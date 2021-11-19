using System;
namespace ers
{
     abstract class  creator
    {
        int a;
        int b;
        public creator (int _a,int _b)
        {
            a=_a;
            b=_b;
        }
        abstract public void breath();
       
        abstract public void move();
        
    }
    class fish:creator
    {
        public fish():base(1,2)
        {

        }
        public override void breath()
        {
            System.Console.WriteLine("ab shosh");
        }
        public override void move()
        {
            System.Console.WriteLine("swim");
        }

    }
    class  human:creator
    {
        public human():base(3,4)
        {

        }

        public override void breath()
        {
            System.Console.WriteLine("shosh");
        }

        public override void move()
        {
         System.Console.WriteLine("walk");
        }
    }
    
}