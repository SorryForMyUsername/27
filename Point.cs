using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27
{
    internal class Point
    {
        /// <summary>
        /// Поле Координата X
        /// </summary>
        int x;
        /// <summary>
        /// Поле Координата Y
        /// </summary>
        int y;

        /// <summary>
        /// Поле Координатная четверть
        /// </summary>
        int coordinateQuadrant;

        /// <summary>
        /// Статическое поле Количество точек
        /// </summary>
        static int count;

        /// <summary>
        /// Свойство Координата X
        /// </summary>
        public int X
        {
            get { return x; }
            set
            {
                x = value;
                DefineCoordinateQuadrant();
            }
        }
        /// <summary>
        /// Свойство Координата Y
        /// </summary>
        public int Y
        {
            get { return y; }
            set
            {
                y = value;
                DefineCoordinateQuadrant();
            }
        }
        
        /// <summary>
        /// Свойство Координатная четверть
        /// </summary>
        public int CoordinateQuadrant { get => coordinateQuadrant; set => coordinateQuadrant = value; }

        /// <summary>
        /// Свойство Количество точек
        /// </summary>
        public static int Count { get => count; set => count = value; }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Point()
        {
            X = 0;
            Y = 0;
            count++;
        }

        /// <summary>
        /// Конструктор с двумя параметрами
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
            count++;
        }

        public double Length()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
        }

        private void DefineCoordinateQuadrant()
        {
            CoordinateQuadrant = x >= 0
                ? y >= 0 ? 1 : 4
                : y >= 0 ? 2 : 3;
        }

        /// <summary>
        /// Метод для вывод значений координат
        /// </summary>
        /// <returns>Значения координат в виде строки</returns>
        public override string ToString()
        {
            return $"x = {X, -5}y = {Y, -5}(Координатная четверть: {coordinateQuadrant})";
        }
    }
}
