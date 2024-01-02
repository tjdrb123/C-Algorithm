using System;

public class Solution {
    public int solution(int left, int right) {
        int answer = 0;
        for(int i = left; i<=right; i++)
        {
            if (Math.Sqrt(i) == (int)Math.Sqrt(i))
                answer -= i;
            else
                answer += i;
        }
        return answer;
    }
}