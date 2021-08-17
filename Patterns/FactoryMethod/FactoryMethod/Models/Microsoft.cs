using System;
using AbstractFactory;
using FactoryMethod.FactoryInfrastructure;

namespace FactoryMethod.Models
{
    public class Microsoft : ICompany
    {
        public double StockPrice { get; set; }
        private const string Ticker = "MSFT";
        private readonly Connection _connection = new();
        
        public void GetCurrentStockPrice()
        {
            StockPrice = _connection.GetRealTimePrice(Ticker);

            Console.WriteLine( "Current Microsoft stock price : " + StockPrice);
        }
    }
}