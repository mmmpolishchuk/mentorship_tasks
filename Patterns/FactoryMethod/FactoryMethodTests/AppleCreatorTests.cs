using FactoryMethod;
using FactoryMethod.FactoryInfrastructure;
using FactoryMethod.Models;
using FluentAssertions;
using Xunit;

namespace FactoryMethodFactory
{
    public class AppleCreatorTests : TestBase
    {
        [Fact]
        public void AppleCreator_CreateCompany_ShouldReturnAppleInstance()
        {
            // Arrange
            Mocker
                .GetMock<AppleCreator>()
                .Setup(s => s.CreateCompany())
                .Returns(new Apple());

            // Act
            var actualResult = new AppleCreator().CreateCompany();

            // Assert
            actualResult.Should().BeOfType<Apple>();
        }
        
        [Fact]
        public void Apple_GetCurrentStockPrice_ShouldShowStockPrice()
        {
            // Arrange
            Mocker.GetMock<ICompany>()
                .Setup(apple => apple.GetCurrentStockPrice());
            Mocker.GetMock<IConnection>()
                .Setup(connection => connection.GetRealTimePrice("AAPL"));
            
            // Act
            ICompany google =  new Apple();
            google.GetCurrentStockPrice();
            
            // Assert
            google.StockPrice.Should().NotBe(default);
            google.StockPrice.Should().BePositive();
        }
    }
}