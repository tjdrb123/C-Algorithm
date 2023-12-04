using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        var num = Math.Sqrt(n);
        
        if (num % 1 == 0)
        {
            answer = (long)num + 1;
            answer *= answer;
        }
        else
        {
            answer = -1;
        }
        return answer;
    }
}