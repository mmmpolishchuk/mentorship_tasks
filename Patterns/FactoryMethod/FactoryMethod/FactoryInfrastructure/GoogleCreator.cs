using FactoryMethod.Models;

namespace FactoryMethod.FactoryInfrastructure
{
    public class GoogleCreator : Company
    {
        public override ICompany CreateCompany()
        {
            return new Google();
        }
    }
}