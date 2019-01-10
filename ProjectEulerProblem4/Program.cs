using System;
using System.Linq;

namespace ProjectEulerProblem4
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int LargestPalindromeNumber = new int();
                int TempNumber = new int();
                string NumberToString;
                string PalinCheck;


                for (int i = 100; i < 1000; i++)
                {
                    for (int j = 100; j < 1000; j++)
                    {
                        TempNumber = i * j;

                        NumberToString = TempNumber.ToString();

                        //using LINQ reverse makes it an enumerable sequence of characters so you must make it an array to use it as a string
                        PalinCheck = new string( NumberToString.Reverse().ToArray());


                        if (NumberToString.CompareTo(PalinCheck) == 0)
                        {
                            if (TempNumber > LargestPalindromeNumber)
                            {
                                LargestPalindromeNumber = TempNumber;
                            }
                        }

                    }
                }


                Console.WriteLine("The Largest Palindrome Multiple is : {0}", LargestPalindromeNumber);
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
