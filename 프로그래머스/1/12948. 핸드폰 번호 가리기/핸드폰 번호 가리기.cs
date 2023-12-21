 public class Solution
 {
     public string solution(string phone_number)
     {
         char[] arr = phone_number.ToCharArray();
         for(int i = 0; i < arr.Length - 4; i++)
         {
             arr[i] = '*';
         }

         string answer = new string(arr);
         // char는 struct, string은 class
         return answer;
     }
 }