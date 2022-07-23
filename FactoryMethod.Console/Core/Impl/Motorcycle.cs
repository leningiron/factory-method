using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Console.Core.Impl
{
    public class Motorcycle : Transport
    {
        public override void Deliver()
        {
            System.Console.WriteLine("Hello from the Motorcycle!!");
        }
    }
}
