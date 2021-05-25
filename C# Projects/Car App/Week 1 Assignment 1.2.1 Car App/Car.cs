using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1_Assignment_1._2._1_Car_App
{
    class Car
    {
        private string licencePlate;
        private int maxFuelLevel;
        private int currentFuelLevel;
        private string carStatus;
        private int kmPerLiter = 20;// Otherwise we will get Division zero exception if we not use 20
        

        public Car(string nwlicencePlate,int nwMaxFuelLevel)
        {
            this.licencePlate = nwlicencePlate;
            this.maxFuelLevel = nwMaxFuelLevel;
            this.carStatus = "";
            this.currentFuelLevel = 0;
        }
        public Car(string licencePlate, int maxFuelLevel, int kmPerLiter)
        {
            this.licencePlate = licencePlate;
            this.maxFuelLevel = maxFuelLevel;
            //Make sure the car starts with 0 fuel and the status OK
            this.currentFuelLevel = 0;
            this.carStatus = "OK";
            this.kmPerLiter = kmPerLiter;
        }
        public void AddFuel(int fuel)
        {
        
            //+= means this.currentFuelLevel=currenFuelLevel+fuel;
            if (carStatus != "Sold")
            {
                this.currentFuelLevel +=  fuel;
                if (this.currentFuelLevel > this.maxFuelLevel)
                {
                    this.currentFuelLevel = this.maxFuelLevel;
                }

            }
        }
        public void SetUnderMaintenance(bool isUnderMaintenance)
        {
            if (isUnderMaintenance == true)
            {
                this.carStatus = "Under Maintenance";
            }
            else
            {
                this.carStatus = "OK";
            }
        }
        public void SetSold()
        {
            if(carStatus!="Under Maintenance" || carStatus != "Ok")
            {
                this.carStatus = "Sold";
            }
            
        }
        public string GetInfo()
        {
            string info;
            info = "License Plate " + this.licencePlate+"/"+ " Status " + this.carStatus + "/"+ " Fuel " +
                this.currentFuelLevel.ToString()+ "/" + " Max Fuel Level " + this.maxFuelLevel.ToString()+"/"
                ;
            return info;
        }
        override
        public string ToString()
        {
            return licencePlate;
        }
        public void drive(int km)
        {           
            int fuelNeeded = km / this.kmPerLiter;

            this.currentFuelLevel -= fuelNeeded;

            if (this.currentFuelLevel < 0)
            {
                this.currentFuelLevel = 0;
            }
        }
       
      
       
    }
}
