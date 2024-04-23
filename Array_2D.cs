using System;

namespace Patterns_Csharp
{
    class Array_2D
    {
        public static void Main()
        {
            int[,] x = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(x[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[][] y = new int[2][];
            y[0] = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            y[1] = new int[5] { 1, 2, 3, 4, 5 };
        }
    }
}
