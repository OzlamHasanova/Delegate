using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ən böyük və ən kiçiklərindən başqa
            //N sayda tam ədədlərdən ibarət massiv verilir. Bu massivin ən kiçik və ən böyük elementlərindən başqa bütün elementlərinin cəmini tapın.



            const Array=[20, 23, 8, 27, 7, 35];
            int sum = 0;

            int minElement = Array[0];
            int maxElement = Array[0];
            for (int i = 0; i < Array.length; ++i)
            {
                if (Array[i] < minElement)
                {
                    minElement = Array[i];
                }
                if (Array[i] > maxElement)
                {
                    maxElement = Array[i];
                }
            }
            for (int a = 0; a < Array.length; ++a)
            {
                if (Array[a] != maxElement && myArray[a] != minElement)
                {
                    sum += myArray[a];
                }
            }
            console.log(minElement);
            console.log(maxElement);
            console.log(sum);



        }
    }
}