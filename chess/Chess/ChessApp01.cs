using System;

namespace Chess_Hilma
{
   
        class Program
        {
            static void Main(string[] args)
            {

               // Chessapp av Hilma
                for (var y = 0; y < 8; y++)
                {
                    for (var x = 0; x < 16; x++)
                    {
                        int characterIndex = (x / 2 + y) % 2;
                        char character = characterIndex == 0 ? '░' : '▓';

                        Console.Write(character);
                    }

                    Console.Write('\n');
                }

                Console.ReadKey();
            }
        }
    }
