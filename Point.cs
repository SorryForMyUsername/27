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
        /// Свойство Координата X
        /// </summary>
        public int X { get => x; set => x = value; }
        /// <summary>
        /// Свойство Координата Y
        /// </summary>
        public int Y { get => y; set => y = value; }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Point()
        {
            X = 0;
            Y = 0;
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
        }

        /// <summary>
        /// Метод для вывод значений координат
        /// </summary>
        /// <returns>Значения координат в виде строки</returns>
        public override string ToString()
        {
            return $"x = {X, -5}y = {Y, -5}";
        }
    }
}
