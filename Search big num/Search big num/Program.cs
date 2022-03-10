using System;

namespace Search_big_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = { 15,21,9,19,20,2,8 };
            Console.WriteLine(Bignum(Arr));
        }


        public static int Bignum(int[] Arr) 
        {
            int bignum = Arr[4];
            foreach (var number in Arr)
            {
                if (number>bignum)
                {
                    bignum=number;
                }                
            }
            return bignum;
        }
    }
}