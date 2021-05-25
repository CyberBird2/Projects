using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1_Assignment_1._2._1_Car_App
{
    class Garage
    {
        private int carCounter;
        private string name;
        private Car[] cars;


        public Garage() { }

        public Garage(string nwName)
        {
            this.name = nwName;
            this.cars = new Car[carCounter];

        }

        public void AddCar(Car c)
        {   // we dont need for loop because we adding all of them
            cars[carCounter] = c;
            carCounter++; 
        }
        public Car GetCar(int index)
        {

           

        }
    }
}
