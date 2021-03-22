using System;

namespace FindMaximumProblem
{
    class Program
    {
        static void Main(string[] args)
        {    
            int integerOutput = MaximumNumberCheck.MaximumIntegerNumber(11, 44, 33);
            Console.WriteLine(integerOutput);

            double doubleOutput = MaximumNumberCheck.MaximumFloatNumber(111.44, 44.20, 33.65);
            Console.WriteLine(doubleOutput);

            string stringOutput = MaximumNumberCheck.MaximumStringNumber("Carrot","Banana","Apple");
            Console.WriteLine(stringOutput);
        }
    }
}
