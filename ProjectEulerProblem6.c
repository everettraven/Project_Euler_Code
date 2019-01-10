#include <stdio.h>


int main()
{
    int Final, TempSum = 0, TempSquares = 0, Number;


    printf("Gimme a number :)\n");
    scanf("%d", &Number);



    for(int i = 0; i < Number + 1; i++)
    {
        TempSquares += i*i;
    }

    for (int i = 0; i < Number + 1; i++)
    {
        TempSum += i;
    }

    TempSum = TempSum*TempSum;

    Final = TempSum - TempSquares;

    printf("the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum is :\n%d", Final);

    return 0;

}