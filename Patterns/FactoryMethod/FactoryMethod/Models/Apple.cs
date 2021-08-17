using System;
using AbstractFactory;
using FactoryMethod.FactoryInfrastructure;

namespace FactoryMethod.Models
{
    public class Apple : ICompany
    {
        public double StockPrice { get; set; }
        private const string Ticker = "AAPL";
        private readonly Connection _connection = new();

        public void GetCurrentStockPrice()
        {
            StockPrice = _connection.GetRealTimePrice(Ticker);
            
            Console.WriteLine("Current Google stock price : " + StockPrice);
        }
    }
}