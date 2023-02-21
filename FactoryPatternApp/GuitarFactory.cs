using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace FactoryPatternApp
{
    public static class GuitarFactory
    {
        public static IGuitarBuild GetGuitar(int styleOfMusic)
        {
            switch (styleOfMusic)
            {
                case 1:
                    return new Accoustic();
                case 2:
                    return new FlyingV();
                case 3:
                    return new Kelly();
                case 4:
                    return new SingleCut();
                default:
                    return new Soloist();
                    
            }
        }
    }
}
