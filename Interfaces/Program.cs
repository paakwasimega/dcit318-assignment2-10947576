using System;

namespace InterfacesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IMovable car = new Car();
            car.Move(); // Output: Car is moving

            IMovable bicycle = new Bicycle();
            bicycle.Move(); // Output: Bicycle is moving
        }
    }
}
