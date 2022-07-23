using FactoryMethod.Console.Core.Model;
namespace FactoryMethod.Console.Core
{
    public abstract class TransportFactory
    {
         public abstract Transport GetTransport(Policy policy);
    }
}
