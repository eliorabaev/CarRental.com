using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carental_Limited.Backend.Model
{
    [Serializable]
    public class Truck : WorkVehicle
    {
        public int _loadingCapacity { get; set; }
        public int _towingCapacity { get; set; }

        public Truck(double price, string fuel, int carNum, string company, string license, int loadingCapacity, int towingCapacity) :
            base(price, fuel, carNum, company, license)
        {
            _loadingCapacity = loadingCapacity;
            _towingCapacity = towingCapacity;
        }
        public override int maxSpeed()
        {
            return 130;
        }
        public override int type()
        {
            return 4;
        }
        public override string GetCarInfo()
        {
            return "Car Numer: " + this._carNum + "\nCar Company: " + this._company + "\nCar Fuel Type: " + this._fuel + "\nNeed license type: " + this._license + "\nLoading Capacity: " + this._loadingCapacity + "\nTowing Capacity: " + this._towingCapacity+ "\nCar Price: " + this._price;
        }
    }
}
