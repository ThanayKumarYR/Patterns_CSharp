using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Csharp
{
    class Program
    {
        static void Main()
        {
            for (int i = 0;i<3;i++) 
            {
                for (int j = 0; j<3; j++)
                {
                    Console.Write((i*3)+(j+1) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
