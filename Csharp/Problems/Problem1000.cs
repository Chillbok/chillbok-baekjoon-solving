using System;

public class Problem1000
{
    public void APlusB()
    {
        string[] inputs = Console.ReadLine()!.Split();
        int A = int.Parse(inputs[0]);
        int B = int.Parse(inputs[1]);

        Console.WriteLine(A + B);
    }
}