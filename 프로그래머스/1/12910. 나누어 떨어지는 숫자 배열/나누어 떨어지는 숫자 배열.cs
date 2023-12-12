using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int divisor) {
        int[] answer = new int[] { };
        arr = Array.FindAll(arr, num => num % divisor == 0).ToArray();
        Array.Sort(arr);
        answer = arr;
        
        if (answer.Length > 0) return answer;
        else return new int[] {-1};
    }
}