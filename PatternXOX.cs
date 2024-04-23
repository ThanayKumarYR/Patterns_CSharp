using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Csharp

{
    class PatternXOX
    {
        public static void Main()
        {
            for (int i = 1; i <=3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    if (i == 2 && j == 2) 
                    {
                        Console.Write("x ");
                    }
                    else if (i * j % 2 == 0)
                    {
                        Console.Write("o ");
                    }
                    else
                    {
                        Console.Write("x ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
