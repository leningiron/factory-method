using FactoryMethod.Console.Core;
using FactoryMethod.Console.Core.Model;
using FactoryMethod.Console.Core.Model.Catalogs;

namespace FactoryMethod.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DelegationType[] deliveries = 
            { 
                DelegationType.BenitoJuarez, 
                DelegationType.Coyoacan,
                DelegationType.MiguelHidalgo, 
                DelegationType.None, 
                DelegationType.Tlalpan 
            };

            foreach (var delivery in deliveries)
            {
                var transportEngine = new TransportEngine();
                var transport = transportEngine.GetTransport(new Policy { DelegationType = delivery });
                transport.Deliver();
            }

            System.Console.ReadKey();
        }
    }
}
