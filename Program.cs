﻿// See https://aka.ms/new-console-template for more information

using System.Diagnostics.CodeAnalysis;

int n1, n2;
Console.WriteLine("Please enter frst number ");
n1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("please enter second number");
n2= Convert.ToInt32(Console.ReadLine());
for(int i =n1; i<=n2; i++)
{
    if(isperfect(i))
    {
        Console.WriteLine("i");
    }
}

static bool isperfect(int n)
{
    int sum = 0;
    for (int i = 1; i < n;i++)
    { 

        if (n % i == 0)
        {
            sum+= i;
       
        }
    }
    return sum == n;

}