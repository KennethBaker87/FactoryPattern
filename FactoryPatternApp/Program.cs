using System;

namespace FactoryPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int genre;
            bool input = false;

            do
            {

            
            Console.WriteLine("Allow us to assist you with finding the right guitar for your style of music.");
            Console.WriteLine("Please state the style of music you like to play or would like to learn.");
            Console.WriteLine("Please select:");
            Console.WriteLine("1 for Country");
            Console.WriteLine("2 for Rock");
            Console.WriteLine("3 for Metal");
            Console.WriteLine("4 for Jazz");
            Console.WriteLine("Any other number if you do not see your style here");
            input = int.TryParse(Console.ReadLine(),out genre);
                Console.WriteLine();
            }
            while(input == false);

            var guitar = GuitarFactory.GetGuitar(genre);
            guitar.Build();
            
                

            
        }
    }
}
