namespace FactoryMethod.FactoryInfrastructure
{
    public abstract class Company
    {
        public abstract ICompany CreateCompany();

        public void GetStockPrice()
        {
            ICompany company = CreateCompany();

            company.GetCurrentStockPrice();
        }
    }
}