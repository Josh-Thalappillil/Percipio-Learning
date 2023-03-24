using System;

class Program{
    static void Main(string[]args){
        // string[] fraudulentOrderIDs = new string[3];
        // fraudulentOrderIDs[0] = "A123";
        // fraudulentOrderIDs[1] = "B456";
        // fraudulentOrderIDs[2] = "C789";
        // fraudulentOrderIDs[3] = "D000";
        

        // string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

        // Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
        // Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
        // Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

        // fraudulentOrderIDs[0] = "F000";

        // Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

        // Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

        // EXERCISE:

        // int[] inventory = { 200, 450, 700, 175, 250 };
        // int sum = 0;
        // int bin = 0;
        // foreach (int items in inventory)
        // {
        //     sum += items;
        //     bin++;
        //     Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
        // }
    
        // Console.WriteLine($"We have {sum} items in inventory.");

        // Code challenge - Report the Order IDs that need further investigation
        // Your team has found a pattern. Orders that start with the letter "B" encounter fraud at a rate 25 times greater than the normal rate. 
        // You'll write new code that outputs the Order ID of new orders where the Order ID starts with the letter "B". This will be used by the fraud team to investigate further.
        string[] fraudID = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

        foreach (string item in fraudID)
        {
            if (item.StartsWith("B"))
            {
                Console.WriteLine(item);
            }
        }
    }
}

// RECAP
// Here's the most important things to remember when working with arrays:

// An array is a special variable that holds a sequence of related data elements.
// You should memorize the basic format of an array variable declaration.
// Access each element of an array to set or get its values using a zero-based index inside of square brackets.
// If you attempt to access an index outside of the boundary of the array, you get a run time exception.
// The Length property gives you a programmatic way to determine the number of elements in an array.