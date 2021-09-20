using FactoryMethod.Models;

namespace FactoryMethod.FactoryInfrastructure
{
    public class AppleCreator : Company
    {
        public override ICompany CreateCompany()
        {
            return new Apple();
        }
    }
}