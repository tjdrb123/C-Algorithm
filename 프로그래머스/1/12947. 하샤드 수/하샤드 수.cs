public class Solution {
    public bool solution(int x) {
        int copyX = x;
        int sum = 0;
        bool answer = true;
        
        while (copyX > 0)
        {
            sum += copyX % 10;
            copyX /= 10;
        }
        answer = x % sum == 0 ? true : false;
        return answer;
    }
}