using Newtonsoft.Json.Linq;
using RestSharp;

namespace FactoryMethod
{
    public class Connection : IConnection
    {
        public IRestClient Client { get; set; }
        public IRestRequest Request { get; set; }

        public double GetRealTimePrice(string ticker)
        {
            IRestRequest request = CreateConnection(ticker);
            IRestResponse response = Client.Execute(request);

            return (double) JObject.Parse(response.Content)["price"];
        }

        public IRestRequest CreateConnection(string ticker)
        {
            Client = new RestClient("https://twelve-data1.p.rapidapi.com/price?symbol=" + ticker +
                                    "&format=json&outputsize=30");
            Request = new RestRequest(Method.GET);

            Request.AddHeader("x-rapidapi-key", "306a42939bmshf19afc4454ad9c0p181e0djsne1bd985bd930");
            Request.AddHeader("x-rapidapi-host", "twelve-data1.p.rapidapi.com");

            return Request;
        }
    }
}