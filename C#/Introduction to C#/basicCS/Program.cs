using System;


class Program{
    static void Main(string[] args){
        // string firstName;
        // firstName = "Josh";
        // Console.WriteLine(firstName);
        // firstName = "Alisha";
        // Console.WriteLine(firstName);
        // firstName = "Sienna";
        // Console.WriteLine(firstName);
        // The above is testing for interchanging variables

        // Testing variables in console output below (Exercise 1)
        string firstName;
        firstName = "Josh";

        int mailNum;
        mailNum = 27;

        decimal tempCelsius;
        tempCelsius = 29.3m;

        Console.WriteLine($"Hello, {firstName}! You have {mailNum} in your inbox. The temperature is {tempCelsius} celsius.");

        // Exercise 2
        string projectName = "ACME";

        string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";


        Console.WriteLine($@"View English output:
        c:\Exercise\{projectName}\data.txt");

        Console.WriteLine($@"{russianMessage}:
        c:\Exercise\{projectName}\ru-RU\data.txt");

    }
}



