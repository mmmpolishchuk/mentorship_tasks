using FactoryMethod.Models;

namespace FactoryMethod.FactoryInfrastructure
{
    public class AppleCreator : Company
    {
        protected override ICompany CreateCompany()
        {
            return new Apple();
        }
    }
}