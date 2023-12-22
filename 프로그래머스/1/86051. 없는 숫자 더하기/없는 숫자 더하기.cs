using System;
using System.Linq;

public class Solution {
    public int solution(int[] numbers)
    {
        int answer = 45 - numbers.Sum(x => x);
        return answer;
    }
}