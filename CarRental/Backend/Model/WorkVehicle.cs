using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carental_Limited.Backend.Model
{
    [Serializable]
    public abstract class WorkVehicle : Vehicle
    {
        public string _license { get; set; }
        protected WorkVehicle(double price, string fuel, int carNum, string company, string license):
            base(price,fuel,carNum,company)
        {
            _license = license;
        }
    }

  
}
