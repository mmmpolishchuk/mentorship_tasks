using FactoryMethod;
using FactoryMethod.FactoryInfrastructure;
using FactoryMethod.Models;
using FluentAssertions;
using Xunit;

namespace FactoryMethodFactory
{
    public class GoogleCreatorTests : TestBase
    {
        [Fact]
        public void GoogleCreator_CreateCompany_ShouldReturnGoogleInstance()
        {
            // Arrange
            Mocker
                .GetMock<GoogleCreator>()
                .Setup(s => s.CreateCompany())
                .Returns(new Google());

            // Act
            var actualResult = new GoogleCreator().CreateCompany();

            // Assert
            actualResult.Should().BeOfType<Google>();
        }
        
        [Fact]
        public void Microsoft_GetCurrentStockPrice_ShouldShowStockPrice()
        {
            // Arrange
            Mocker.GetMock<ICompany>()
                .Setup(google => google.GetCurrentStockPrice());
            Mocker.GetMock<IConnection>()
                .Setup(connection => connection.GetRealTimePrice("GOOGL"));
            
            // Act
            ICompany google =  new Google();
            google.GetCurrentStockPrice();

            // Assert
            google.StockPrice.Should().NotBe(default);
            google.StockPrice.Should().BePositive();
        }
    }
}