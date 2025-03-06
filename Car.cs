using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27
{
    internal class Car
    {
        string make;
        string model;
        int manufacturerYear;

        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public int ManufacturerYear { get => manufacturerYear; set => manufacturerYear = value; }

        public Car() { }

        public Car(string make, string model, int manufacturerYear)
        {
            Make = make;
            Model = model;
            ManufacturerYear = manufacturerYear;
        }

        public override string ToString()
        {
            return $"Марка: {Make,-10}Модель: {Model,-10}Год выпуска: {ManufacturerYear}";
        }
    }
}
