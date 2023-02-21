using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternApp
{
    internal class Accoustic : IGuitarBuild
    {
        public void Build()
        {
            Console.WriteLine("Accoustic: Simple like the style. No need for an amp!");
        }
    }
}
