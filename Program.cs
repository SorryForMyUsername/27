using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car[] cars1 = InitCarArray();
            OutputArray(cars1);
            Console.WriteLine();

            Car[] cars2 = InputCarArray(4);
            OutputArray(cars2);
            Console.WriteLine();

            List<Car> cars3 = InputCarList(5);
            OutputList(cars3);
            Console.WriteLine();

            Console.ReadKey(true);
        }

        static Car[] InitCarArray()
        {
            return new Car[]{
                new Car("BMW", "BMW XM", 2005),
                new Car("Volvo", "Volvo S60", 20014),
                new Car("Skoda", "Enyaq", 2020),
                new Car("Toyota", "Corolla", 2025),
            };
        }

        static Car[] InputCarArray(int length)
        {
            Car[] cars = new Car[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Марка {i + 1}-го автомобиля: ");
                string make = Console.ReadLine();
                Console.Write($"Модель {i + 1}-го автомобиля: ");
                string model = Console.ReadLine();
                Console.Write($"Год {i + 1}-го выпуска: ");
                int manufacturerYear = int.Parse(Console.ReadLine());
                cars[i] = new Car(make, model, manufacturerYear);
            }
            return cars;
        }

        static List<Car> InputCarList(int length)
        {
            List<Car> cars = new List<Car>();
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Марка {i + 1}-го автомобиля: ");
                string make = Console.ReadLine();
                Console.Write($"Модель {i + 1}-го автомобиля: ");
                string model = Console.ReadLine();
                Console.Write($"Год {i + 1}-го выпуска: ");
                int manufacturerYear = int.Parse(Console.ReadLine());
                cars.Add(new Car(make, model, manufacturerYear));
            }
            return cars;
        }

        static void OutputArray(Car[] points)
        {
            Console.WriteLine("Массив автомобилей:");
            foreach (Car point in points)
            {
                Console.WriteLine($"  {point}");
            }
        }

        static void OutputList(List<Car> points)
        {
            Console.WriteLine("Лист автомобилей:");
            foreach (Car point in points)
            {
                Console.WriteLine($"  {point}");
            }
        }
    }
}
