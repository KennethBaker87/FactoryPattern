using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternApp
{
    public class SingleCut : IGuitarBuild
    {
        public void Build()
        {
            Console.WriteLine("The Single Cut: A classic look for a classic sound.");
        }
    }
}
