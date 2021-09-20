using FactoryMethod;
using FactoryMethod.FactoryInfrastructure;
using FluentAssertions;
using Xunit;

namespace FactoryMethodFactory
{
    public class MicrosoftCreatorTests : TestBase
    {
        [Fact]
        public void MicrosoftCreator_CreateCompany_ShouldReturnMicrosoftInstance()
        {
            // Arrange
            Mocker
                .GetMock<MicrosoftCreator>()
                .Setup(s => s.CreateCompany())
                .Returns(new FactoryMethod.Models.Microsoft());

            // Act
            var actualResult = new MicrosoftCreator().CreateCompany();

            // Assert
            actualResult.Should().BeOfType<FactoryMethod.Models.Microsoft>();
        }

        [Fact]
        public void Microsoft_GetCurrentStockPrice_ShouldShowStockPrice()
        {
            // Arrange
            Mocker.GetMock<ICompany>()
                .Setup(microsoft => microsoft.GetCurrentStockPrice());
            Mocker.GetMock<IConnection>()
                .Setup(connection => connection.GetRealTimePrice("MSFT"));
            
            // Act
            ICompany microsoft =  new FactoryMethod.Models.Microsoft();
            microsoft.GetCurrentStockPrice();

            // Assert
            microsoft.StockPrice.Should().NotBe(default);
            microsoft.StockPrice.Should().BePositive();
        }
    }
}