namespace FactoryMethod.FactoryInfrastructure
{
    public interface ICompany
    {
        public double StockPrice { get; }
        void GetCurrentStockPrice();
    }
}