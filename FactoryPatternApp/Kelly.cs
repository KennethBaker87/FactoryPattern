using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternApp
{
    internal class Kelly : IGuitarBuild
    {
        public void Build()
        {
            Console.WriteLine("The Kelly: Looks as aggressive as the music sounds!");
        }
    }
}
