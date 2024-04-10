using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carental_Limited.Backend.Model
{
    [Serializable]
    public class SportCar : Privates
    {
        
        bool _workshop { get; set; }
        public SportCar(double price, string fuel, int carNum, string company, int seats, bool workshop) :
            base(price, fuel, carNum, company, seats)
        {
            _workshop = workshop;
        }

        public override int maxSpeed()
        {
            return 300;
        }
        public override int type()
        {
            return 2;
        }
        public override string GetCarInfo()
        {
            return "Car Numer: " + this._carNum + "\nCar Company: " + this._company + "\nCar Fuel Type: " + this._fuel + "\nNumber of seats: " + this._seats + "\nWorkshop: " + this._workshop + "\nCar Price: " + this._price;
        }
    }
}
