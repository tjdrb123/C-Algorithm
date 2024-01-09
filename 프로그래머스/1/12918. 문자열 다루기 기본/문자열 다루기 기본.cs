public class Solution {
    public bool solution(string s)
        {
            bool answer = (s.Length == 4 || s.Length == 6);
            
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                {
                    answer = false;
                    break;
                }
            }

            return answer;
        }
    }