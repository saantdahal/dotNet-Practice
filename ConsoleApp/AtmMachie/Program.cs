using System;

namespace AtmMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal balance = 5000m;
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nWelcome To ATM");
                Console.WriteLine("Enter Your Choice:");
                Console.WriteLine("Choices: \n 1. Check Balance \n 2. Deposit Money \n 3. Withdraw Money \n 4. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Your Current Balance is RS. {balance}");
                        break;
                    case 2:
                        Console.Write("Enter the amount to deposit: ");
                        decimal deposit = Convert.ToDecimal(Console.ReadLine());
                        if (deposit > 0)
                        {
                            balance += deposit;
                            Console.WriteLine($"RS. {deposit} is deposited to your account. New balance is RS. {balance}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount. Please enter a positive number.");
                        }
                        break;
                    case 3:
                        Console.Write("Enter the amount to withdraw: ");
                        decimal withdraw = Convert.ToDecimal(Console.ReadLine());
                        if (withdraw > 0 && withdraw <= balance)
                        {
                            balance -= withdraw;
                            Console.WriteLine($"RS. {withdraw} is withdrawn from your account. New balance is RS. {balance}");
                        }
                        else if (withdraw > balance)
                        {
                            Console.WriteLine("Insufficient balance.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount. Please enter a positive number.");
                        }
                        break;
                    case 4:
                        exit = true;
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }
    }
}
