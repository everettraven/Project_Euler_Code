#include <stdio.h>

int main()
{
    int sum = 0;
    int number;

    for(int i = 0; i < 1000; i++)
    {
        if(i % 5 == 0 || i % 3 == 0)
        {
            number = i;
            sum = sum + number;
        }
    }

    printf("%d", sum);
    
    return 0;
}