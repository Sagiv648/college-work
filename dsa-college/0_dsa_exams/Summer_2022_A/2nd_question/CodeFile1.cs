using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class CodeDriver1111
{
   

    public static void Main(string[] args)
    {
        Stack<int> x = new Stack<int>();
        int i = 0;
        Random random= new Random();
        while (i < 10)
        {
            x.Push(random.Next(1, 20));
            i++;
        }

        Console.Read();
    }
}
