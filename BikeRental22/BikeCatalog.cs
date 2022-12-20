using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental22
{
    public class BikeCatalog
    {
        public Dictionary<int, Bike> bikeDictionary;

        public BikeCatalog()
        {
            bikeDictionary = new Dictionary<int, Bike>();
        }

        public void AddBike(Bike aBike)
        {
            if (bikeDictionary.Keys.Contains(aBike.ChassisNumber))
            {
                throw new ArgumentException("Bike with ChassisNumber is already registered in the BikeCatalog.");
            }
            else
            {
                bikeDictionary.Add(aBike.ChassisNumber, aBike);
            }
        }

        public void PrintBikeList()
        {
            foreach (Bike item in bikeDictionary.Values)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Number Of Items: {bikeDictionary.Count}");
            Console.WriteLine($"Current Time: {DateTime.Now}");
        }

        public Bike SearchBike(int chassisNumber)
        {
            foreach (KeyValuePair<int, Bike> item in bikeDictionary)
            {
                if (item.Key == chassisNumber)
                {
                    return item.Value;
                }
            }

            return null;
        }

        public void DeleteBike(int chassisNumber)
        {
            Bike foundBike = SearchBike(chassisNumber);

            if (foundBike != null)
            {
                bikeDictionary.Remove(chassisNumber);
            }
        }

        public List<Bike> SearchBikesOfModel(string model)
        {
            List<Bike> bikeList = new List<Bike>();

            foreach (Bike item in bikeDictionary.Values)
            {
                if (item.Model == model)
                {
                    bikeList.Add(item);
                }
            }

            return bikeList;
        }

        public void DeleteAllBikesOfModel(string model)
        {
            foreach (KeyValuePair<int, Bike> item in bikeDictionary)
            {
                if (item.Value.Model == model)
                {
                    DeleteBike(item.Key);
                }
            }
        }
    }
}
