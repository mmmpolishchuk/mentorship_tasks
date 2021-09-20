using Moq.AutoMock;

namespace FactoryMethodFactory
{
    public class TestBase
    {
        protected AutoMocker Mocker { get; } = new();
    }
}