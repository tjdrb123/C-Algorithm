public class Solution {
    public bool solution(int x) {
        int copyX = x;
        int sum = 0;
        bool answer = true;
        
        while (x > 0)
        {
            sum += x % 10;
            x /= 10;
        }
        answer = copyX % sum == 0 ? true : false;
        return answer;
    }
}