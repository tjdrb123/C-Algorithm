using System.Linq;

public class Solution {
    public int[] solution(int[] arr)
{
    int[] answer = new int[] { };
    int min = arr.Min();
    if (arr.Length > 1)
    {
        arr = arr.Where(x => x != min).ToArray();
        answer = arr;
    }
    else
    {
        answer = new int[] { -1 };
    }
    return answer;
}
}