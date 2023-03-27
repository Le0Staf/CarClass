using System;

namespace CarClass
{
    class Program
    {
        static void Main()
        {
            ChooseCar();
        }

        static void ChooseCar()
        {
            Car car1 = new Car();
            Console.WriteLine("Select brand: ");
            car1.brand = Console.ReadLine();
            Console.WriteLine("Select color: ");
            car1.color = Console.ReadLine();
            car1.stock = new Random().Next(1, 500);

            Console.WriteLine("\nBrand: " + car1.brand);
            Console.WriteLine("Color: " + car1.color);
            Console.WriteLine("In stock: " + car1.stock);
            car1.price = new Random().Next(500, 50000);
            Console.WriteLine("Price: $" + car1.price);

            Console.WriteLine("Purchase? (y/n)");
            if (Console.ReadLine() == "y")
            {
                Console.WriteLine("Congratulations! You just bought a |" + car1.color + " " + car1.brand + "| for $" + car1.price);
            }

            Console.WriteLine("\nLook up another car? (y/n)");
            if (Console.ReadLine() == "y")
            {
                Console.WriteLine("\n");
                Main();
            }
        }
    }
}