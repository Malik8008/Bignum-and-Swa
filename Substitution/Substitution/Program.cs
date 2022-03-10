using System;

namespace Substitution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Substitution(num, num2));
        }

        public static int Substitution(int num, int num2)
        {
            int numCopy = num;
            int count = 0;
            int var = 1;
            while (numCopy >= 1)
            {
                numCopy /= 10;
                count++;
            }
            for (int i = 0; i < count; i++)
            {
                var *= 10;
            }
            num = (num2 * var) + num;
            return num;
        }
    }
}
