using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankIntvwPrepKit
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 2,1,5,3,4};
            int[] myArray2 = new int[] { 2, 5, 1, 3, 4 };
            int counter = 0;
            for (int i = 0; i < myArray2.Length; i++)
            {
                int sum = myArray2[i] - 1 - i;
                if(sum == 1)
                {
                    counter++;
                }
                else if(sum == 2)
                {
                    counter += 2;
                }
                else if(sum == 3)
                {
                    counter = 0;
                    Console.WriteLine("Too chaotic");
                   
                }
                
                

            }
            if(counter > 0)
            {
                Console.WriteLine(counter);
            }
            
            Console.ReadKey();

        }
    }
}
