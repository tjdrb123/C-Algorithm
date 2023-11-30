using System;

public class Solution {
    public int[] solution(long n) {
        int cnt = 0;
        long temp = n;
        while (temp > 0)
        {
            temp /= 10;
            cnt++;
        }
        int[] answer = new int[cnt];
        for (int i = cnt - 1; i >= 0; i--)
        {
            answer[i] = (int)(n % 10);
            n /= 10;
        }
        Array.Reverse(answer);
        return answer;
    }
}