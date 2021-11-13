using System;

namespace car
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //در يك متغير  تاريخ حال حاضر شمسي رو ذخيره ميكنيم
            PersianDateTime now = PersianDateTime.now;
            System.Console.WriteLine(now);
            //  mitooni be sorat tike shode bebinish (int)
            System.Console.WriteLine(now.Year);
            // mishe toye int zakhire kard
            int a = now.Year;
            System.Console.WriteLine("a="+a);
            //
            System.Console.WriteLine(now.Month);
            System.Console.WriteLine(now.Day);
            System.Console.WriteLine(now.Hour);
            System.Console.WriteLine(now.Minute);
            System.Console.WriteLine(now.Second);
            // chandomin rooz hafte
            System.Console.WriteLine(now.DayOfWeek);
            // chandomin rooz sal
            System.Console.WriteLine(now.DayOfYear);

            System.Console.WriteLine("enter your age... like (1362/11/20)");

            // گرفتن يك تاريخ تولد به صورت شمسي

            PersianDateTime age = PersianDateTime.Parse(Console.ReadLine());



            // پيدا كردن سن (سال)
            int b = now.Year - age.Year;
            System.Console.WriteLine("your age :" + b);

            // age be sorat tike shode 
            System.Console.WriteLine($"year:{age.Year} month:{age.Month} days: {age.Day}");

            // ejafe kardan 100 rooz be age

            System.Console.WriteLine("your old age :" + age);
            //
            age = age.AddDays(100);
            //
            System.Console.WriteLine("your new age :" + age);


            //  در يك متغير تاريخ الان رو به صورت ميلادي رو ذخيره ميكنيم 

            DateTime now1 = DateTime.Now;
            System.Console.WriteLine(now1);

            // khord kardan now1
            System.Console.WriteLine(now1.Year);
            // mishe to yek int zakhire kard
            int t = now1.Year;
            System.Console.WriteLine("t=" + t);
            //
            System.Console.WriteLine(now1.Month);
            System.Console.WriteLine(now1.Day);

            // gereftan yek tarikh miladi

            System.Console.WriteLine("enter your birthday like 2002/01/15");

            DateTime age1 = DateTime.Parse(Console.ReadLine());


            // پيدا كردن سن (سال)
            int c = now1.Year - age1.Year;
            System.Console.WriteLine("your age :" + c);

            // age be sorat tike shode 
            System.Console.WriteLine($"year:{age1.Year} month:{age1.Month} days: {age1.Day}");

            //  model neshon dadan har zamni
            Console.WriteLine(now1.ToString("MM/dd/yyyy"));
            Console.WriteLine(now1.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(now1.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(now1.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(now1.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(now1.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(now1.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            Console.WriteLine(now1.ToString("MM/dd/yyyy HH:mm"));
            Console.WriteLine(now1.ToString("MM/dd/yyyy hh:mm tt"));
            Console.WriteLine(now1.ToString("MM/dd/yyyy H:mm"));
            Console.WriteLine(now1.ToString("MM/dd/yyyy h:mm tt"));
            Console.WriteLine(now1.ToString("MM/dd/yyyy HH:mm:ss"));
            Console.WriteLine(now1.ToString("MMMM dd"));
            Console.WriteLine(now1.ToString("HH:mm"));
            Console.WriteLine(now1.ToString("hh:mm tt"));
            Console.WriteLine(now1.ToString("H:mm"));
            Console.WriteLine(now1.ToString("h:mm tt"));
            Console.WriteLine(now1.ToString("HH:mm:ss"));
            Console.WriteLine(now1.ToString("yyyy MMMM"));

            System.Console.WriteLine("**********");
            //  زمان رو تبديل به واحد كوچكتر كني
            string span = "00:02:30";
            System.Console.WriteLine("00:02:30=" + TimeSpan.Parse(span).TotalSeconds.ToString());
            span = "01:55:00";
            System.Console.WriteLine("01:55:00="+TimeSpan.Parse(span).TotalMinutes.ToString());


            // فاصله بين 2 تا تاريخ
            TimeSpan t2 = now1 - age1;
            System.Console.WriteLine("time diff:" + t2);
            //  فاصله به روز
            var t3 = t2.TotalDays.ToString();
            System.Console.WriteLine("time diff(days):" + t3);
            // فاصله بين 2 زمان به صورت ساعت
            var t4 = t2.TotalHours.ToString();
            System.Console.WriteLine("time diff(hours):" + t4);
        }
    }

    internal class PersianDateTime
    {
        internal static PersianDateTime now;

        public bool Year { get; internal set; }
    }
}
