namespace FactoryMethod.FactoryInfrastructure
{
    public abstract class Company
    {
        protected abstract ICompany CreateCompany();

        public void GetStockPrice()
        {
            ICompany company = CreateCompany();

            company.GetCurrentStockPrice();
        }
    }
}