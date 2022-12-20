using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental22
{
    public class Bike
    {
        public string Model { set; get; }
        public int YearOfPurchase { set; get; }
        public string FrameColor { set; get; }
        public int ChassisNumber { get; }

        public Bike(string model, int yearOfPurchase, string frameColor, int chassisNumber)
        {
            Model = model;
            YearOfPurchase = yearOfPurchase;
            FrameColor = frameColor;
            ChassisNumber = chassisNumber;
        }

        public override string ToString()
        {
            return $"Model: {Model} | Year Of Purchase: {YearOfPurchase} | Frame Color: {FrameColor} | Chassis Number: {ChassisNumber}";
        }
    }
}
