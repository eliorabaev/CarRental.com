using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carental_Limited.Backend.Model
{
    [Serializable]
    public class CommercialVehicle : WorkVehicle
    {
        public int _TrunkVolume { get; set; }

        public CommercialVehicle(double price, string fuel, int carNum, string company, string license, int TrunkVolume) :
            base(price, fuel, carNum, company, license)
        {
            _TrunkVolume = TrunkVolume;
        }
        public override int maxSpeed()
        {
            return 160;
        }
        public override int type()
        {
            return 3;
        }
        public override string GetCarInfo()
        {
            return "Car Numer: " + this._carNum + "\nCar Company: " + this._company + "\nCar Fuel Type: " + this._fuel + "\nNeed license type: " + this._license + "\nTrunk Volume: " + this._TrunkVolume + "\nCar Price: " + this._price;
        }
    }
}
