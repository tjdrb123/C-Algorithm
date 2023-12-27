public class Solution {
     public string solution(string s)
     {
         string answer = "";
         if(s.Length % 2 == 0)
         {
             return s.Substring(s.Length / 2 - 1, 2);
         }
         else
         {
             return s.Substring(s.Length / 2, 1);
         }
     }
}