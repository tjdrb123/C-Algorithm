using System;

class Solution
{
    public long solution(long price, long money, long count)
    {
        long sumPrice = 0;
        for(int NumberofRides = 1; NumberofRides <= count; NumberofRides++)
        {
            sumPrice += price * NumberofRides;
        }
        if (money - sumPrice < 0)
            return -(money - sumPrice);
        else
            return 0;
    }
}