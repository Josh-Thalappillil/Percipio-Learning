using System;

class Program{
    static void Main(string[]args){
        Random dice = new Random();

        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);

        int total = roll1 + roll2 + roll3;

        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

        if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
        {
            if((roll1 == roll2) && (roll2 == roll3))
            {
                Console.WriteLine("You rolled triples! +6 bonus added to total!");
                total += 6;
            }
            
            else
            {
                Console.WriteLine("You rolled doubles! +2 bonus added to total!");
                total += 2;
            }
        }

        if (total >= 16)
        {
            Console.WriteLine("You won a new car!");
        }

        else if (total >= 10)
        {
            Console.WriteLine("You won a new laptop");
        }

        else if (total == 7)
        {
            Console.WriteLine("You won a holiday overseas!");
        }

        else
        {
            Console.WriteLine("You won a kitten!");
        }

    }
}



// Boolean expressions:
// Other simple Boolean expressions can be created by using operators to compare two values. Operators include:
// ==, the "equals" operator, to test for equality
// >, the "greater than" operator, to test that the value on the left is greater than the value on the right
// <, the "less than" operator, to test that the value on the left is less than the value on the right
// >=, the "greater than or equal to" operator
// <=, the "less than or equal to" operator