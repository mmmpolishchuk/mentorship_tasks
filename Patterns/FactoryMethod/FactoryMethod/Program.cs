using System;
using FactoryMethod.FactoryInfrastructure;

namespace FactoryMethod
{
    static class Program
    {
        private static Company _company;

        private static void GetPrice(char digit)
        {
            switch (digit)
            {
                case '1':
                    _company = new AppleCreator();
                    _company.GetStockPrice();
                    break;

                case '2':
                    _company = new GoogleCreator();
                    _company.GetStockPrice();
                    break;

                case '3':
                    _company = new MicrosoftCreator();
                    _company.GetStockPrice();
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Try again by choosing any digit from 1 to 3.");
                    Console.ForegroundColor = default;
                    break;
            }
        }

        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("********** ONLINE STOCK PRICES OF APPLE, GOOGLE AND MICROSOFT **********");
            Console.WriteLine("========================================================================");
           
            Console.WriteLine("Enter a digit to see a corresponding company's stock price:");
            Console.WriteLine("  1 --- APPLE");
            Console.WriteLine("  2 --- GOOGLE");
            Console.WriteLine("  3 --- MICROSOFT");
            Console.WriteLine("  Q --- Quit from app");
            Console.WriteLine("========================================================================");
            
            while (true)
            {
                Console.Write("Your choice : ");
                var companyNumb = Convert.ToChar(Console.ReadLine().ToLower());

                if (companyNumb == 'q')
                {
                    Console.WriteLine("Application has been stopped.");
                    break;
                }
                
                GetPrice(companyNumb);

                companyNumb = default;
            }
        }
    }
}