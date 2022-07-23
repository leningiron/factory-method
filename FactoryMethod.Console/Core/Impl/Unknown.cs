using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Console.Core.Impl
{
    public class Unknown : Transport
    {
        public override void Deliver()
        {
            System.Console.WriteLine("Hello transport invalid.!!");
        }
    }
}
