using FactoryMethod.Models;

namespace FactoryMethod.FactoryInfrastructure
{
    public class GoogleCreator : Company
    {
        protected override ICompany CreateCompany()
        {
            return new Google();
        }
    }
}