using System;

namespace ArrayQuadrato
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] arr = new int[5, 5];

            int counter = 0;

            //scorre le righe
            for (int i = 0; i < 5; i++)
            {
                //scorre contenuto righe
                for (int j = 0; j < 5; j++)
                {
                    ++counter;
                    //uso operatore condizionale ? if
                    //se j == 0 scrivi 0, altrimenti scrivi il val di counter
                    arr[i, j] = (j == 0) ? 0 : counter;

                    Console.Write($"{arr[i, j]} ");
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}

//esercizio deve dare come risultato
//0 2 3 4 5
//0 7 8 9 10
//0 12 13 13 15
//0 17 18 19 20
//0 22 23 24 25
