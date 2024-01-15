public class Solution {
     public int[] solution(int n, int m) {
                int[] answer = new int[2];
                int min;
                int max;
        
                //최대공약수 -> 유클리드 호제법 gcd(n, m) = gcd(m, n%m)
                min = gcd(n, m);
                //최소공배수 -> 두수의 곱 / 최대 공약수
                max = (n * m) / min;
        
                answer[0] = min;
                answer[1] = max;
                return answer;
            }
            public int gcd(int n, int m)
            {
                //두 수 n, m 이 있을 때 어느 한 수가 0이 될 때 까지
                //gcd(m, n%m) 의 재귀함수 반복
                if(m==0) return n;
                else return gcd(m, n%m);
            }
}