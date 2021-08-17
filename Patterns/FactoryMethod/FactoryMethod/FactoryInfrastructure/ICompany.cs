namespace FactoryMethod.FactoryInfrastructure
{
    public interface ICompany
    {
        public double StockPrice { get; set; }
        void GetCurrentStockPrice();
    }
}