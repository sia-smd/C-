using System;
using System.Collections.Generic;


namespace atm
{
   
    
    class process : atm
    {
        static List<card> list_card = new List<card>();
        static List<card_history> history_card = new List<card_history>();
        int i = 1;
        static string card_no;

        // vared kardan 2 card baraye rah andazi ATM
        public void add()
        {
            System.Console.WriteLine("add 2 card for run ATM");
            do
            {
                card c = new card();
                System.Console.WriteLine("enter card name-#" + i);
                c.name = Console.ReadLine();
                System.Console.WriteLine("enter card number-#" + i);
                c.id = Console.ReadLine();
                System.Console.WriteLine("enter card password-#" + i);
                c.pass = Console.ReadLine();
                System.Console.WriteLine("enter card credit ($)-#" + i);
                c.price = ATM.ck1("enter correct amount");
                list_card.Add(c);
                i++;
            } while (i < 3);
        }

        // sorat hesab
        public void credit()
        {
            foreach (var item in list_card)
            {
                if (item.id == card_no)
                {
                    Console.Clear();
                    System.Console.WriteLine("Your account balance : " + item.price + " $");
                    Console.ReadKey();
                }
            }
        }

        // taghir ramz card
        public void update()
        {
            Console.Clear();
            System.Console.Write("enter old password : ");
            string old_pass = Console.ReadLine();
            System.Console.Write("enter new password : ");
            string new_pass = Console.ReadLine();
            System.Console.Write("repeat new password : ");
            string re_pass = Console.ReadLine();


            foreach (var item in list_card)
            {
                if (item.id == card_no)
                {
                    Console.Clear();
                    if (item.pass == old_pass)
                    {
                        if (new_pass == re_pass)
                        {
                            item.pass = new_pass;
                            System.Console.WriteLine("success");
                        }
                        else
                        {
                            System.Console.WriteLine("wrong new pass");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("wrong old pass");
                    }
                    Console.ReadKey();
                }
            }
        }

        // daryaft pool az ATM
        public void cash()
        {
            Console.Clear();
            foreach (var item in list_card)
            {
                if (item.id == card_no)
                {
                    Console.Clear();
                    if (item.price - cash >= 0)
                    {
                        item.price = item.price - cash;
                        add_history(item.id, cash, "cash");
                        System.Console.WriteLine("success");
                        System.Console.WriteLine("new credit : " + item.price + " $");
                    }
                    else
                    {
                        System.Console.WriteLine("credit is not enough");
                    }
                    Console.ReadKey();
                }
            }
        }

        // card be card kardan
        public void CtoC()
        {
            Console.Clear();
            System.Console.Write("enter Destination card : ");
            string des_card = Console.ReadLine();
            System.Console.Write("Enter the amount to transfer : ");
            int cash = ATM.ck1("enter correct amount");

            foreach (var item in list_card)
            {
                if (item.id == card_no)
                {
                    Console.Clear();
                    if (item.price - cash >= 0)
                    {
                        foreach (var item1 in list_card)
                        {
                            if (item1.id == des_card)
                            {
                                System.Console.WriteLine("owner Destination card :" + item1.name);
                                System.Console.WriteLine("amount to transfer : " + cash);
                                System.Console.Write("are you sure ? y/n : ");
                                string ans = Console.ReadLine();
                                if (ans == "y" || ans == "Y")
                                {
                                    item1.price = item1.price + cash;
                                    add_history(item1.id, cash, "Deposit");
                                    item.price = item.price - cash;
                                    add_history(item.id, cash, "withdrow");
                                    System.Console.WriteLine("success");
                                    System.Console.WriteLine("new credit : " + item.price + " $");
                                    Console.ReadKey();
                                    return;
                                }
                                else
                                {
                                    System.Console.WriteLine("ignore by user");
                                    Console.ReadKey();
                                    return;
                                }
                            }
                        }
                        System.Console.WriteLine("Destination card not found");
                    }
                    else
                    {
                        System.Console.WriteLine("credit is not enough");
                    }
                    Console.ReadKey();
                }
            }
        }

        // vorod be hesab karbari
        public bool select()
        {
            Console.Clear();
            System.Console.WriteLine("----------WELCOME----------");
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.Write("    enter card number :");
            card_no = Console.ReadLine();
            System.Console.Write("     enter password :");
            string password = Console.ReadLine();
            foreach (var item in list_card)
            {
                if (item.id == card_no && item.pass == password)
                {
                    return true;
                }
            }
            Console.Clear();
            System.Console.WriteLine("wrong password");
            Console.ReadKey();
            return false;
        }

        // 10 gardesh akhar
        public void history()
        {
            history_card.Reverse();

            int i = 1;
            Console.Clear();
            System.Console.WriteLine("row--amount ----------- date -------------- type -*");
            System.Console.WriteLine("--------------------------------------------------*");

            foreach (var item in history_card)
            {
                if (item.id == card_no && i < 11)
                {
                    var s = item.price;
                    System.Console.Write("*-" + i + "    " + item.price);
                    ATM.space(item.price);
                    System.Console.WriteLine(item.date + "   " + item.type);
                    i++;
                }
            }
            System.Console.WriteLine("--------------------------------------------------*");
            Console.ReadKey();
        }

        //  log tarakonesh card
        public void add_history(string id, int price, string type)
        {
            card_history c_h = new card_history();
            c_h.id = id;
            c_h.price = price;
            c_h.date = DateTime.Now;
            c_h.type = type;
            history_card.Add(c_h);

        }
    }

}