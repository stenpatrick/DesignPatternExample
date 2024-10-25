using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Model
{
    public class CarBuilder
    {
        private readonly Car _car;

        public CarBuilder()
        {
            _car = new Car();
        }

        public CarBuilder SetMake(string make)
        {
            _car.Make = make;
            return this;
        }

        public CarBuilder SetModel(string model)
        {
            _car.Model = model;
            return this;
        }

        public CarBuilder SetYear(int year)
        {
            _car.Year = year;
            return this;
        }

        public CarBuilder SetColor(string color)
        {
            _car.Color = color;
            return this;
        }

        public Car Build()
        {
            return _car;
        }
    }

}
