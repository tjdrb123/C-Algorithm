using System.Linq;

public class Solution {
    public string solution(string s) {
        string answer = "";
        answer = string.Concat(s.OrderByDescending(ch => ch));
        return answer;
    }
}