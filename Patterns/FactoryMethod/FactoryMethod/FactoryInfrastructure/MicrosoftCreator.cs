namespace FactoryMethod.FactoryInfrastructure
{
    public class MicrosoftCreator : Company
    {
        public override ICompany CreateCompany()
        {
            return new Models.Microsoft();
        }
    }
}