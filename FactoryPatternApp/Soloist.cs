using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternApp
{
    internal class Soloist : IGuitarBuild
    {
        public void Build()
        {
            Console.WriteLine("The Soloist: Perfect for any kind of music in both look and sound.");
        }
    }
}
