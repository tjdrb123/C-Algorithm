public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2) {
        int[,] answer = new int[arr1.GetLength(0), arr1.GetLength(1)];
        for(int first = 0; first <arr1.GetLength(0); first++)
        {
            for(int second = 0; second < arr1.GetLength(1); second++)
            {
                answer[first, second] = arr1[first, second] + arr2[first, second];
            }
        }
        return answer;
    }
}