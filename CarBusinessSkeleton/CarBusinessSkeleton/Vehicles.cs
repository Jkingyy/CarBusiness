using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBusinessSkeleton
{
    //vehicle object that has the data that all vehicle tyoes have
    public class Vehicles
    {
        protected string make;
        protected string model;
        protected int year;
        protected decimal price;
        protected decimal weight;
        protected string colour;
        protected string registration;
        
        public Vehicles(string pMake, string pModel, int pYear, decimal pPrice, decimal pWeight, string pColour, string pRegistration)
        {
            make = pMake;
            model = pModel;
            year = pYear;
            price = pPrice;
            weight = pWeight;
            colour = pColour;
            registration = pRegistration;
        }
        //the restoration method to be overloaded by each vehicle type
        public virtual void vehicleRestoration()
        {

        }

    }
    //car inherits the vehicles data and add its own 3 
    class Car : Vehicles
    {
        int numberOfDoors;
        decimal engineSize;
        bool electricWindows;

        public Car(string pMake, string pModel, int pYear, decimal pPrice, decimal pWeight, string pColour, string pRegistration, int pNumberOfDoors, decimal pEngineSize, bool pElectricWindows) : base(pMake, pModel, pYear,pPrice,pWeight,pColour,pRegistration)
        {
            numberOfDoors = pNumberOfDoors;
            engineSize = pEngineSize;
            electricWindows = pElectricWindows;
        }

        //overrides the ToString() for displaying the information in the forms
        public override string ToString()
        {
            return (GetType().ToString().Split('.')[1] + "," + make + "," + model + "," + year + "," + price + "," + weight + "," + colour + "," + registration + "," + numberOfDoors + "," + engineSize + "," + electricWindows);
        }

        //restores the car cahnging the price and weight
        public override void vehicleRestoration()
        {
            price = (((price / 100) * 25) + price);
            weight = (weight - ((weight / 100) * 10));
        }

    }
    //truck inherits from vehicles
    class Truck : Vehicles
    {
        int weightLimit;
        int numberOfWheels;
        int length;

        public Truck(string pMake, string pModel, int pYear, decimal pPrice, decimal pWeight, string pColour, string pRegistration, int pWeightLimit, int pNumberOfWheels, int pLength) : base(pMake, pModel, pYear, pPrice, pWeight, pColour, pRegistration)
        {
            weightLimit = pWeightLimit;
            numberOfWheels = pNumberOfWheels;
            length = pLength;

        }
        public override string ToString()
        {
            return (GetType().ToString().Split('.')[1] + "," + make + "," + model + "," + year + "," + price + "," + weight + "," + colour + "," + registration + "," + weightLimit + "," + numberOfWheels+ "," + length);
        }
        public override void vehicleRestoration()
        {
            weight = weight - ((weight / 100) * 50);
            colour = "Black";
        }

    }
    //helicopter inherits from vehicles
    class Helicopter : Vehicles
    {
        protected bool airworthy;
        protected int hoursUsed;
        protected int altitudeLimit;

        public Helicopter(string pMake, string pModel, int pYear, decimal pPrice, decimal pWeight, string pColour, string pRegistration, bool pAirworthy, int pHoursUsed, int pAltitudeLimit) : base(pMake, pModel, pYear, pPrice, pWeight, pColour, pRegistration)
        {
            airworthy = pAirworthy;
            hoursUsed = pHoursUsed;
            altitudeLimit = pAltitudeLimit;
        }
        public override string ToString()
        {
            return (GetType().ToString().Split('.')[1] + "," + make + "," + model + "," + year + "," + price + "," + weight + "," + colour + "," + registration + "," + airworthy + "," + hoursUsed + "," + altitudeLimit);
        }
        public override void vehicleRestoration()
        {
            airworthy = true;
            price = price + ((price / 100) * 300);
            altitudeLimit = altitudeLimit + ((altitudeLimit / 100) * 10);
        }
    }
    //plane inherits from helicopter as it contains the needed data plus the 2 it adds itself
    class Plane : Helicopter
    {
        int seats;
        string engines;

        public Plane(string pMake, string pModel, int pYear, decimal pPrice, decimal pWeight, string pColour, string pRegistration, bool pAirworthy, int pHoursUsed, int pAltitudeLimit, int pSeats, string pEngines) : base(pMake, pModel, pYear, pPrice, pWeight, pColour, pRegistration, pAirworthy, pHoursUsed, pAltitudeLimit)
        {
            seats = pSeats;
            engines = pEngines;

        }
        public override string ToString()
        {
            return (GetType().ToString().Split('.')[1] + "," + make + "," + model + "," + year + "," + price + "," + weight + "," + colour + "," + registration + "," + airworthy + "," + hoursUsed + "," + altitudeLimit + "," + seats + "," + engines);
        }
        public override void vehicleRestoration()
        {
            airworthy = true;
            price = price + ((price / 100) * 300);
            altitudeLimit = altitudeLimit + ((altitudeLimit / 100) * 15);
            weight = weight - ((weight / 100) * 2);
        }
    }
}
