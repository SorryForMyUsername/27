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
            List<Point> points = InputPointList(4);
            OutputList(points);
            Console.WriteLine($"\nБлижайшая точка: {ClosestPointNumber(points)}\n" +
                $"Всего точек: {Point.Count}");

            Console.ReadKey(true);
        }

        static List<Point> InputPointList(int length)
        {
            List<Point> points = new List<Point>();
            for (int i = 0;i < length; i++)
            {
                Console.Write($"points[{i}].X = ");
                int x = int.Parse(Console.ReadLine());
                Console.Write($"points[{i}].Y = ");
                int y = int.Parse(Console.ReadLine());
                points.Add(new Point(x, y));
            }
            return points;
        }

        static int ClosestPointNumber(List<Point> points)
        {
            int number = 0;
            double closest = points[0].Length();

            for(int i = 0;i < points.Count; i++)
            {
                double length = points[i].Length();
                if(length < closest)
                {
                    number = i;
                    closest = length;
                }
            }
            return number;
        }

        static void OutputList(List<Point> points)
        {
            Console.WriteLine("Лист точек:");
            foreach (Point point in points)
            {
                Console.WriteLine($"  {point}");
            }
        }
    }
}
