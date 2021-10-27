using System;

namespace project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 30;
            string[,] std = new string[a, 2];
            string[,] mardod = new string[a, 2];
            int j = 0;
            int count = 0;
            //  student name
            for (int i = 0; i < a; i++)
            {
                System.Console.WriteLine("enter student name #" + (i + 1));
                std[i, 0] = Console.ReadLine();
                count++;
                if (std[i, 0] == "no")
                {
                    count--;
                    break;
                }

            }
            // student mark
            for (int i = 0; i < a; i++)
            {
                if (std[i, 0] != "no")
                {
                    System.Console.WriteLine("enter mark of " + std[i, 0]);
                    std[i, 1] = Console.ReadLine();
                    if (Convert.ToInt32(std[i, 1]) < 10)
                    {
                        mardod[j, 0] = std[i, 0];
                        mardod[j, 1] = std[i, 1];
                        j++;
                    }
                }
                else
                {
                    break;
                }
            }


            // mardodin
            System.Console.WriteLine("********************");
            System.Console.WriteLine("mardoodin");
            for (int i = 0; i < j; i++)
            {
                System.Console.Write(mardod[i, 0]);
                System.Console.WriteLine(" |mark:" + mardod[i, 1]);
            }


            // sort
            int max = 0;
            System.Console.WriteLine("************");
            System.Console.WriteLine("ranking");

            for (int i = 0; i < count; i++)
            {
                max = Convert.ToInt32(std[0, 1]);
                int p = 0;
                for (int m = 0; m < count; m++)
                {
                    if (max < Convert.ToInt32(std[m, 1]))
                    {
                        max = Convert.ToInt32(std[m, 1]);
                        p = m;
                    }
                }
                System.Console.Write($"#{i + 1}:" + std[p, 0]);
                System.Console.WriteLine(" |mark: " + std[p, 1]);
                std[p, 1] = "0";
            }
        }
    }
}
