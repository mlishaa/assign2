using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 2, 3, 4, 5, 5, 1,1 ,10,3,4};
            int[,] result = new int[arr.Length,2];
            int ind = 0;
            bool doing = true;

            for(int i = 0; i < arr.Length; ++i)
            {
                doing = false;
                for(int j=0;j < result.GetLength(0); ++j)
                {
                    if (result[j, 0] == arr[i])
                    {
                        result[j,1]++;
                        doing = true;
                        break;
                    }
                 
                }

                if (doing == false)
                {
                    result[ind, 0] = arr[i];
                    result[ind, 1] = 1;
                    ind++;
                }


            }

            for(int x = 0; x < result.GetLength(0); ++x)
            {
                if (result[x, 0] != 0 && result[x, 1] == 0)
                {
                    Console.Write("number {0} Occurs {1}", result[x, 0], result[x, 1]);
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
