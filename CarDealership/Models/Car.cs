using System;

namespace CarDealership.Models
{

    public class Car
    {
        private string _makeModel;
        private int _price;
        private int _miles;
        private static List<Car> carList = new List<Car> {};

        public Car(string makeModel, int price, int miles)
        {
            _makeModel = makeModel;
            _price = price;
            _miles = miles;
            _carList.Add(this);

        }

        public Car ()
        {
            
        }

        public string GetMakeModel()
        {
            return _makeModel;
        }

        public int GetPrice()
        {
            return _price;
        }

        public int GetMiles()
        {
            return _miles;
        }

        public void SetPrice(int newPrice)
        {
            _price = newPrice;
        }

        public bool WorthBuying(int maxPrice)
        {
            return (_price < maxPrice);
        }

        public bool MaxMiles(int maxMiles)
        {
            return (_miles < maxMiles);
        }
    }
}
