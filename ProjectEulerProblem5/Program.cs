using System;

namespace ProjectEulerProblem5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int LowestPossible = 0;
                int EndNumber;
                int TestAllRemainder = 0;

                Console.WriteLine("What is the number you would like to check to?");
                EndNumber = Convert.ToInt32(Console.ReadLine());


                for (int j = 1; j < Int32.MaxValue/3; j++)
                {
                    for (int k = 1; k < EndNumber; k++)
                    {

                        TestAllRemainder = TestAllRemainder + j % k;

                    }

                    if (TestAllRemainder == 0)
                    {
                        LowestPossible = j;
                        break;
                    }


                    TestAllRemainder = 0;

                }


                Console.WriteLine("Lowest Possible Number is : {0}", LowestPossible);
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
