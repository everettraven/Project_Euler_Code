using System;

namespace ProjectEulerProblem3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                long LargestPrimeFactor = 0;
                long Prime = 0;
                long Previous = 0;


                Console.WriteLine("Give me what number you'd like to find the highest prime factor of");
                long InputNumber = Convert.ToInt64(Console.ReadLine());

                for (long i = 1; i < 7000; i++)
                {
                    Prime = i + Previous;
                    Previous = i;

                    if (InputNumber % Prime == 0)
                    {
                        LargestPrimeFactor = Prime;
                    }

                }


                Console.WriteLine("The Biggest Prime Factor is : {0}", LargestPrimeFactor);
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }

        }
    }
}
