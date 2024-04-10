using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carental_Limited.Backend.Model
{
    [Serializable]
    public abstract class Vehicle
    {
        public double _price { get; set; }
        public string _fuel { get; set; }
        public int _carNum { get; set; }
        public string _company { get; set; }
        protected Vehicle(double price, string fuel, int carNum, string company)
        {
            _price = price;
            _fuel = fuel;
            _carNum = carNum;
            _company = company;
           
        }
        public abstract int maxSpeed();
        public abstract int type();
        public abstract string GetCarInfo();
    }
}
