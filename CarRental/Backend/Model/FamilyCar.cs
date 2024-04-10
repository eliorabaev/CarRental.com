using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carental_Limited.Backend.Model
{
    [Serializable]
    public class FamilyCar : Privates
    {
        bool _backSeatsScreens { get; set; }
        public FamilyCar(double price, string fuel, int carNum, string company, int seats, bool screens) :
            base(price, fuel, carNum, company, seats)
        {
            _backSeatsScreens = screens;
        }

        public override int maxSpeed()
        {
            return 260;
        }
        public override int type()
        {
            return 1;
        }
        public override string GetCarInfo()
        {
            return "Car Numer: " + this._carNum + "\nCar Company: " + this._company+ "\nCar Fuel Type: " + this._fuel+ "\nNumber of seats: " + this._seats+ "\nHas seat screens: " + this._backSeatsScreens + "\nCar Price: " + this._price;
        }
    }
}
