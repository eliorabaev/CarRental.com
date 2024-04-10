using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carental_Limited.Backend.Model
{
    [Serializable]
    public abstract class Privates : Vehicle
    {
        public int _seats { get; set; }
        protected Privates(double price, string fuel, int carNum, string company, int seats) :
            base(price, fuel, carNum, company)
        {
            _seats = seats;
        }
    }
}
