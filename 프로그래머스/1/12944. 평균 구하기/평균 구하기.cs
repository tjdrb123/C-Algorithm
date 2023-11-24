public class Solution {
    public double solution(int[] arr) {
        double answer = 0;
        foreach (int num in arr) answer += num;
        answer /= arr.Length;
        return answer;
    }
}

// answer = arr.Average();