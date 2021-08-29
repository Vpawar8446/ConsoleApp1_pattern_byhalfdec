using System;

namespace ConsoleApp1_pattern_byhalfdec
{
    class PatternNo
    {
        public void pattern(int num)
        {
            for (int i =num; i >= 1; i--)
            {
                for (int j =num ; j >= i; j--)
                {

                    Console.Write(+j);
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PatternNo obj = new PatternNo();
            Console.Write("Enter the any number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            obj.pattern(n);
        }
    }
}



   