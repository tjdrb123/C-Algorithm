public class Solution {
    public int solution(string s) {
        int answer = 0;
        char temp = s[0];
        
        if (temp == '-')
        {
            s = s.Trim(temp);
            answer = -int.Parse(s); 
        }
        else
        {
            answer = int.Parse(s);
        }

        return answer;
    }
}