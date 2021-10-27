using System;

namespace project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=30;
            string[,] std = new string[a, 2];
            string[,] mardod = new string[a, 2];
            int j = 0;
            int count = 0;
            //  student name
            for (int i = 0; i < a; i++)
            {
                System.Console.WriteLine("enter student name number" + (i + 1));
                std[i, 0] = Console.ReadLine();
                count++;
                if (std[i, 0] == "no")
                {
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
                System.Console.Write("student name:"+mardod[i,0]);
                System.Console.WriteLine("|mark:"+mardod[i,1]);
            }
            // sort
        }
    }
}
