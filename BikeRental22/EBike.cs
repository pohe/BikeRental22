using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental22
{
    public class EBike : Bike
    {
        public int Motor { get; set; }

        public EBike(string model, int yearOfPurchase, string frameColor, int chassisNumber, int motor) : base(model, yearOfPurchase, frameColor, chassisNumber)
        {
            Motor = motor;
        }

        public override string ToString()
        {
            return base.ToString() + $" | Motor: {Motor}";
        }
    }
}
