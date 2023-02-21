using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternApp
{
    internal class FlyingV : IGuitarBuild
    {
        public void Build()
        {
            Console.WriteLine("The Flying V: Make a statement with your music and your presence");
        }
    }
}
