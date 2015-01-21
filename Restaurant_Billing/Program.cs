using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Billing
{
    class Program
    {
        string[] menu = new string[5] {"Idli Sambar", "Wada Sambar", "Dosa", "Rice Plate", "uttapa" };
        int[] rate = new int[5] { 50, 50, 60, 100, 50 };
        int[,] ord=new int[5,2];
        int x=0,y=0;
        int Total = 0;
        static int no, quantity;
        
        
        public int edit(int opt)
        {
            Console.Write("Selected Option \t");
            Console.WriteLine(menu[opt - 1] + " " + rate[opt - 1]);
            Console.WriteLine("\nEnter new rate");
            int r = Convert.ToInt32(Console.ReadLine());
            rate[opt - 1] = r;
            Console.WriteLine("\nRate Changed \n");
            return rate[opt - 1];
        }


        public void display()
        {
            Console.WriteLine("\t Name \t\t\t Rate");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + 1 + "\t" + menu[i] + "\t\t" + rate[i]);
            }
        }

        public void order(int choice,int quantity)
        {
          
               
                   ord[x,y] = choice;
                   y++;
                   ord[x,y] = quantity;
                   y=0;
                   x++;
                   Console.WriteLine("Your order Accepted\n");
                   
                   
        }


        public int bill(int choice, int quantity)
        {

            Total = rate[choice - 1] * quantity;
            Console.WriteLine("\n Total Bill For your Order is:"+Total+"\n");
            return Total;
        }
        


        static void Main()
        {
            Program p=new Program();
            Console.WriteLine("Restaurant Billing System\n");
            Console.WriteLine(" 1.Display Menu \n 2.Edit Menu \n 3.Place Order \n 4.Billing \n 5.Exit \n");
            
            try
            {
                while (true)
                {
                    Console.Write("Please enter your selection: ");
                    int i = int.Parse(System.Console.ReadLine());
                    switch (i)
                    {
                        case 1:
                            {
                                p.display();

                                break;
                            }
                        case 2:
                            {
                                p.display();
                                Console.WriteLine("\n Enter menu option to edit");
                                int opt = Convert.ToInt32(Console.ReadLine());
                                p.edit(opt);
                                break;
                            }
                        case 3:
                            {
                                p.display();
                                Console.WriteLine("What do you want to order");
                                Console.WriteLine("Enter Item No :");
                                no = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter Quantity :");
                                quantity = Convert.ToInt32(Console.ReadLine());
                                p.order(no, quantity);
                                break;
                            }
                        case 4:
                            {
                                p.bill(no,quantity);

                                break;
                            }
                        case 5:
                            {
                                Environment.Exit(0);
                                break;
                            }
                    }
                }
            }
            catch
            {
                
                Console.WriteLine("Not Entered Correct Choice");
                Console.ReadKey();
            }
        }

    }
}
