using System;
namespace erse
{
    

    class space 
    {
        double area;
        public double price;
        
        public space (double _area) 
        {
            price=15000;
            area=_area;
            
        }
        public void cal_price()
        {
            double cal=area*price;
            System.Console.WriteLine("price for painting :"+ cal);

        }
    }
    class rectangle:space
    {
        int Width;
        int height;
        int length;
        double area;
       
       
        public rectangle(int _w,int _h,int _l):base(area)
        {
            Width=_w;
            height=_h;
            length=_l;  
        }
        public void cal_r()
        {
            area=cal_area(Width,height,length);
            
        }
        private int cal_area(int w,int h,int l)
        {
            int s =((w*l)*2)+((w*h)*2)+((h*l)*2);
            return s;

        }

    }

    class circle:space
    {
        int Radius;
        int height;
        double area;
        
        
       
        public circle(int _r,int _h):base(area)
        {
            Radius=_r;
            height=_h;
            area=cal_area(Radius,height);  
        }
        public void cal_c(){
             area=cal_area(Radius,height); 
        }
        private double cal_area(int r,int h)
        {
            double s =((2*r*3.14)*h)+(((r*r)*3.14)*2);
            return s;
        }

    }
    
}