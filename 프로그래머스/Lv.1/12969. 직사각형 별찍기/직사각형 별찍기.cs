using System;

public class Example
{
    public static void Main()
    {
         String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int a = Int32.Parse(s[0]);
        int b = Int32.Parse(s[1]);

        for(int row = 0; row < b; row++)
        {
            for(int star = 0; star < a; star++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}