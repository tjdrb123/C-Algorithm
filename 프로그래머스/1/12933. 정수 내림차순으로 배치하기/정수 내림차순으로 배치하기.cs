using System;
using System.Collections.Generic;

public class Solution {
    public long solution(long n) {
        List<long> list = new List<long>();
        long answer = 0;
        
        while(n > 0)
        {
            list.Add(n % 10);
            n /= 10;
        }
        list.Sort();
        list.Reverse();
        
        int cnt = list.Count - 1;
        for(int i = 0; i < list.Count; i++)
        {
    answer += list[i] * (long)Math.Pow(10, cnt-i);
        }
        return answer;
    }
}