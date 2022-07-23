using FactoryMethod.Console.Core.Impl;
using FactoryMethod.Console.Core.Model;
using FactoryMethod.Console.Core.Model.Catalogs;
using System.Collections.Generic;

namespace FactoryMethod.Console.Core
{

    public class TransportEngine : TransportFactory
    {
        private readonly Dictionary<DelegationType, TransportType> 
            relationData = new()
        {
            { DelegationType.BenitoJuarez, TransportType.Motorcycle },
            { DelegationType.Coyoacan, TransportType.Motorcycle },
            { DelegationType.Iztacalco, TransportType.Motorcycle },
            { DelegationType.Iztapalapa, TransportType.Car },
            { DelegationType.MiguelHidalgo, TransportType.Bicycle },
            { DelegationType.Tlalpan, TransportType.Car }
        };

        public override Transport GetTransport(Policy policy)
        {
            bool hasValue = relationData.TryGetValue(policy.DelegationType, out TransportType value);
            if (hasValue)
            {
                switch (value)
                {
                    case TransportType.None:
                        return new Unknown();
                    case TransportType.Bicycle:
                        return new Bicycle();
                    case TransportType.Car:
                        return new Car();
                    case TransportType.Motorcycle:
                        return new Motorcycle();
                    default:
                        return new Unknown();
                }
            }
            else
            {
                return new Unknown();
            }
        }
    }
}
