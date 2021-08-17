namespace FactoryMethod.FactoryInfrastructure
{
    public class MicrosoftCreator : Company
    {
        protected override ICompany CreateCompany()
        {
            return new Models.Microsoft();
        }
    }
}