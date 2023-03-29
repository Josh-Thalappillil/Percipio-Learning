using OOP_TestCar;

//practicing constructors in car class

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // constructor = A special method in a class
            //               Same name as the class name
            //               Can be used to assign arguments to fields when creating an object

            Console.ForegroundColor = ConsoleColor.Green;

            Car car1 = new Car("Nissan", "Skyline R33", 1994, "black");
            car1.Drive();

            Console.ReadKey();
        }
    }
}