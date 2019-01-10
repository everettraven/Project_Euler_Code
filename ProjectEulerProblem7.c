#include <stdio.h>


int main ()
{
    int Number, PrimeNumber, count = 0, tempCount = 0;

    printf("What nth Prime Number would you like to find?\n");
    scanf("%d", &Number);
    printf("%d\n", Number);

    for (int i = 2; i < 2000000; i++)
    {
        for(int j = 2; j < i; j++)
        {
            if(i % j == 0)
            {
                if(i == j)
                {

                }
                else
                {
                    tempCount += 1;
                }

            }
        }

        if(tempCount == 0)
        {
            PrimeNumber = i;
            count += 1;
        }

        tempCount = 0;

        if(count == Number)
        {
            break;
        }

    }


    printf("The %dth Prime Number is : \n%d", Number, PrimeNumber);

    return 0;
}