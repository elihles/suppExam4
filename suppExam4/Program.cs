using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suppExam4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
            int choice;
            Console.WriteLine("Welcome to the banking app");
            Console.Write("Enter your initial balance :");
           double initialBal=int.Parse(Console.ReadLine());
            bool quit = false;
            while (!quit)
            {
                displayOptions();
                Console.Write("Enter your choice:");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        DepositFunds(ref initialBal);
                        break;
                    case 2:
                        WithdrawFunds(ref initialBal);
                        break;
                    case 3:
                        CheckAccount(initialBal);
                        break;

                    case 4:
                        Console.WriteLine("Goodbye");
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
           
            Console.WriteLine();
            Console.ReadLine();
        }
        static void displayOptions()
        {
            Console.WriteLine("1. Deposit funds");
            Console.WriteLine("2. Withdraw funds");
            Console.WriteLine("3.  Check account balance");
            Console.WriteLine("4. Quit ");
        }
        static void DepositFunds(ref double  initialBal)
        {
           
            double amount;
            Console.Write("Enter the amount you would like to deposit :");
            amount=double.Parse(Console.ReadLine());
            initialBal+=amount;
            Console.WriteLine("Deposit successful");


        }
        static void WithdrawFunds(ref double initialBal)
        {

            double withdrawAmount;
            Console.Write("Enter the amount you would like to withdraw :");
            withdrawAmount = double.Parse(Console.ReadLine());

            if (withdrawAmount > initialBal)
            {
                Console.WriteLine("Insufficient funds to withdraw {0:C1}", withdrawAmount);
            }
            else
            {
              
                initialBal -= withdrawAmount;
                Console.WriteLine("Withdrawal successful");
            }
        }
            static double CheckAccount(double initialBal)
                
            {
            

            Console.WriteLine("your account balance is {0:C} ",initialBal);
            return initialBal;

            
            
            }
            
        }

    }

