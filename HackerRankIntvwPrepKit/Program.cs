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
            //int[] myarray = new int[] { 2, 1, 5, 3, 4 };
            //int[] myArray2 = new int[] { 1,2,5,3,7,8,6,4};
            //int counter = 0;
            //for (int i = 0; i < myArray2.Length; i++)
            //{
            //    int sum = myArray2[i] - 1 - i;
            //    if (sum == 1)
            //    {
            //        counter++;
            //        Console.WriteLine(counter);
            //    }
            //    else if (sum == 2)
            //    {
            //        counter += 2;
            //        Console.WriteLine(counter);
            //    }
            //    else if(sum <= 0)
            //    {
            //        Console.WriteLine(counter);
            //        continue;
            //    }
            //    else 
            //    {
            //        counter = 0;
            //        Console.WriteLine("Too chaotic");
            //        break;

            //    }

            //}
            //if (counter > 0)
            //{
            //    Console.WriteLine(counter);
            //}

            //Console.ReadKey();
            //************************************************
            //Alternating Characters

            string name = "Ranger";
            for (int i = 0; i < name.Length; i++)
            {
                if(name[i] == 'R')
                {
                    Console.WriteLine("Yes");
                }
            }


        }
    }
}
