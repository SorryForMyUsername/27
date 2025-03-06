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
            Point[] points1 = InitPointArray();
            OutputArray(points1);
            Console.WriteLine();

            Point[] points2 = InputPointArray(4);
            OutputArray(points2);
            Console.WriteLine();

            List<Point> points3 = InputPointList(5);
            OutputList(points3);
            Console.WriteLine();

            Console.ReadKey(true);
        }

        static Point[] InitPointArray()
        {
            return new Point[]{
                new Point(1, 1),
                new Point(-7, 10),
                new Point(0, -5),
                new Point(-1, -6),
            };
        }

        static Point[] InputPointArray(int length)
        {
            Point[] points = new Point[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write($"points[{i}].X = ");
                int x = int.Parse( Console.ReadLine() );
                Console.Write($"points[{i}].Y = ");
                int y = int.Parse(Console.ReadLine());
                points[i] = new Point(x, y);
            }
            return points;
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

        static void OutputArray(Point[] points)
        {
            Console.WriteLine("Массив точек:");
            foreach (Point point in points)
            {
                Console.WriteLine($"  {point}");
            }
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
