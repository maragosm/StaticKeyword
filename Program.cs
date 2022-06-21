using System;

namespace StaticKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you here for excersize 1 or 2?");
            Console.Write("Exercise: ");
            var userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.WriteLine("For Fahrenheit to Celcius conversions, enter 1. For Celcius to Fahrenheit, enter 2.");
                Console.Write("Input: ");
                userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    Console.WriteLine("Enter the temperature below to convert to Celcius.");
                    Console.Write("Fahrenheit Temp: ");
                    var fTemp = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"{fTemp} degrees Fahrenheit is {TempConverter.TempFtoC(fTemp)} in Celcius.");
                }
                else if (userInput == "2")
                {
                    Console.WriteLine("Enter the temperature below to convert to Fahrenheit.");
                    Console.Write("Celcius Temp: ");
                    var cTemp = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"{cTemp} degrees Celcius is {TempConverter.TempCtoF(cTemp)} in Fahrenheit.");
                }
            }

            if (userInput == "2")
            {
                Console.WriteLine("I will now create three car objects, then add them to the car lot. Progress will be shown below: ");
                var car1 = new Car() { Name = "Mercedes Benz" };
                Console.WriteLine($"A {car1.Name} has been created and added, there is now {CarLot.numberOfCars} car in the car lot.");
                var car2 = new Car() { Name = "Jeep Grand Cherokee" };
                Console.WriteLine($"A {car1.Name} has been created and added, there are now {CarLot.numberOfCars} cars in the car lot.");
                var car3 = new Car() { Name = "Chrysler PT Cruiser" };
                Console.WriteLine($"A {car1.Name} has been created and added, there are now {CarLot.numberOfCars} cars in the car lot.");
            }
        }
    }
}
