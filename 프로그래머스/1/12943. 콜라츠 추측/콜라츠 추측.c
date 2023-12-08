#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int solution(long num) {
    long answer = 0;
    while(answer < 500 && num != 1)
    {
        num = num % 2 == 0 ? num / 2 : num * 3 + 1;
        answer++;
    }
    
    if (answer >= 500)
    answer = -1;
    return answer;
}