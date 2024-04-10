using Carental_Limited.Backend.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Carental_Limited.Backend
{
    public class FileUtiles
    {
        public static void SaveCarsToFile(BindingList<Vehicle> cars)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileInfo fi = new System.IO.FileInfo("cars.bin");
            using (var binaryFile = fi.Create())
            {
                binaryFormatter.Serialize(binaryFile, cars);
                binaryFile.Flush();
            }
        }

        public static BindingList<Vehicle> LoadCarsFromFile()
        {
            BindingList<Vehicle> cars;
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileInfo fi = new System.IO.FileInfo("cars.bin");
                using (var binaryFile = fi.OpenRead())
                {
                    cars = (BindingList<Vehicle>)binaryFormatter.Deserialize(binaryFile);
                }
            }
            catch (Exception ex)
            {
                cars = new BindingList<Vehicle>();
            }
            return cars;
        }
    }
}
