using System;
using System.Threading.Tasks;

namespace Dz6
{
    class Program
    {
        static async Task Main()
        {
           
           
            var threadMathx1 =  Task.Run(() => Intmasiv(100, 100));       
            var threadMathx2 =  Task.Run(() => Intmasiv(100, 100));
           
            var Matr1 = await threadMathx1;
            var Matr2 = await threadMathx2;

            var threadMathx3 = Task.Run(() => SumMatrix(Matr1, Matr2));
            var Matr3 = await threadMathx3;

        }

        static int [,] SumMatrix(int [,] Matr1, int [,] Matr2)
        {
            int[,] Matr3 = new int[Matr1.Length, Matr2.Length];
            for (int i = 0; i < Matr2.GetLength(1); i++)
            {
                for (int j = 0; j < Matr2.GetLength(0); j++)
                {
                    Matr3[i, j] = 0;
                    for (int k = 0; k < Matr2.GetLength(0); k++)
                    {
                        Matr3[i, j] += Matr1[i, k] * Matr2[k, j];
                    }
                }
            }
            foreach (var item in Matr3)
            {
                Console.WriteLine(item);
            }
         
            return Matr3;
        }
        static int[,] Intmasiv( int row, int column)
        {
            int[,] matr = new int[row, column];
            Random rnd = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                 
                    matr[i, j] = matr[rnd.Next(0, 10), rnd.Next(0, 10)];
                }
            }
            foreach (var item in matr)
            {
                Console.WriteLine(item);
            }
            return matr;
        }
    }

}
