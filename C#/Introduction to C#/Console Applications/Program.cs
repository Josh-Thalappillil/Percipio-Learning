using System;

class Program{
    static void Main(string[]args){
        
        // Code CHallenge: Find a function that returns the larger of two numbers(Example code below)
        // int firstValue = 500;
        // int secondValue = 600;
        // int largerValue;
        // Console.WriteLine(largerValue);

        // My Solution:
        int firstValue = 500;
        int secondValue = 600;
        int largerValue = Math.Max(firstValue, secondValue);
        
        Console.WriteLine(largerValue);
    }
}