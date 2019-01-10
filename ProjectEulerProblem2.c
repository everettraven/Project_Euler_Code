#include <stdio.h>

int main()
{
    int second = 1,next,first = 0, sum = 0;

    for(int i = 0; i < 35; i++)
    {
        if(i <= 1)
        {
            next = i;
        }
        else
        {
            next = first + second;
            first = second;
            second = next;

            if(next % 2 == 0)
            {
                sum += next;
            }
        }


        printf("%d\n", next);
    }


    printf("%d", sum);

    return 0;

}