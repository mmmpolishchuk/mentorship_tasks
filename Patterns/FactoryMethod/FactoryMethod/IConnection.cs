using RestSharp;

namespace FactoryMethod
{
    public interface IConnection
    {
        double GetRealTimePrice(string ticker);
        IRestRequest CreateConnection(string ticker);
    }
}