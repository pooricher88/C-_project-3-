﻿namespace DeliverySystem
{
    public class Car : Vehicle
    {
        protected int doors;
        protected double fuelLevel;

        // Додано newMaxSpeed з дефолтним значенням 180.0 для підтримки Car і Van
        public Car(string brand, int year, double mileage, int doors, double newMaxSpeed = 180.0)
            : base(brand, year, mileage, newMaxSpeed)
        {
            this.doors = doors;
            this.fuelLevel = 50;
        }

        public override string GetInfo()
        {
            return $"Car: {brand} ({year}), Doors: {doors}, Fuel: {fuelLevel}L";
        }

        public override void Move(double distance)
        {
            base.Move(distance);

            fuelLevel -= distance * 0.1;

            if (fuelLevel < 0)
            {
                fuelLevel = 0;
            }
        }

        public void Refuel(double liters)
        {
            fuelLevel += liters;

            if (fuelLevel > 50)
            {
                fuelLevel = 50;
            }
        }
    }
}