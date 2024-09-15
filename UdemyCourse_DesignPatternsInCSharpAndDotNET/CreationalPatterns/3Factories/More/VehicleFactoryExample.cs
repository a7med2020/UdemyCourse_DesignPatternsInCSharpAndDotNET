using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCourse_DesignPatternsInCSharpAndDotNET.CreationalPatterns._3Factories.More
{
    // Library classes
    abstract class Vehicle
    {
        public abstract void printVehicle();
    }

    class TwoWheeler : Vehicle
    {
        public override void printVehicle()
        {
            Console.WriteLine("I am two wheeler");
        }
    }

    class FourWheeler : Vehicle
    {
        public override void printVehicle()
        {
            Console.WriteLine("I am four wheeler");
        }
    }

    // Factory Interface
    interface VehicleFactory
    {
        Vehicle createVehicle();
    }

    // Concrete Factory for TwoWheeler
    class TwoWheelerFactory : VehicleFactory
    {
        public Vehicle createVehicle()
        {
            return new TwoWheeler();
        }
    }

    // Concrete Factory for FourWheeler
    class FourWheelerFactory : VehicleFactory
    {
        public Vehicle createVehicle()
        {
            return new FourWheeler();
        }
    }

    // Client class
    class Client_
    {
        private Vehicle pVehicle;

        public Client_(VehicleFactory factory)
        {
            pVehicle = factory.createVehicle();
        }

        public Vehicle getVehicle()
        {
            return pVehicle;
        }
    }

    // Driver program
    public class GFG
    {
        public static void main(String[] args)
        {
            VehicleFactory twoWheelerFactory = new TwoWheelerFactory();
            Client_ twoWheelerClient = new Client_(twoWheelerFactory);
            Vehicle twoWheeler = twoWheelerClient.getVehicle();
            twoWheeler.printVehicle();

            VehicleFactory fourWheelerFactory = new FourWheelerFactory();
            Client_ fourWheelerClient = new Client_(fourWheelerFactory);
            Vehicle fourWheeler = fourWheelerClient.getVehicle();
            fourWheeler.printVehicle();
        }
    }
}
