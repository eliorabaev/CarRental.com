using Carental_Limited.Backend.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carental_Limited.Backend
{
    public class CarsManager
    {
        private static BindingList<Vehicle> cars;
        static CarsManager()
        {
            cars = FileUtiles.LoadCarsFromFile();
        }

        public static void saveCar(object sender, FormClosingEventArgs e)
        {
            FileUtiles.SaveCarsToFile(cars);
        }

        public static BindingList<Vehicle> GetCars()
        {
            return cars;
        }

        public static void AddCar(Vehicle car)
        {
            cars.Add(car);
        }
        public static Vehicle GetVehicleByIndex(int idx)
        {
            if(idx >= 0 && idx < cars.Count)
            {
                return cars[idx];

            }
            Vehicle err = new SportCar(-1, "0", 0, "0", 0, false);
            return err;

        }
        public static void RemoveCar(int index)
        {
            if (index >= 0 && index < cars.Count)
            {
                cars.RemoveAt(index);
                MessageBox.Show("Item at parking lot number " + (index + 1) + " deleted successfully.");
            }
            else
            {
                MessageBox.Show("No item exists at car parking lot numer " + (index + 1) + ".");
            }
        }
        public static void SwapCars(int index1, int index2)
        {
            if (index1 < 0 || index1 >= cars.Count || index2 < 0 || index2 >= cars.Count)
            {
                MessageBox.Show("Invalid parkinglots provided.");
                return;
            }

            Vehicle temp = cars[index1];
            cars[index1] = cars[index2];
            cars[index2] = temp;
            MessageBox.Show("Car places swapped successfully.");
        }
        public static string GetCarInfo(int index)
        {
            if (index >= 0 && index < cars.Count)
            {
                return cars[index].GetCarInfo();
            }
            else
            {
               return "empty parking lot";
            }

        }
        public static void ChangeCar(Vehicle car, int idx)
        {
            cars[idx] = car;
        }
        public static BindingList<T> GetSpecificCars<T>() where T : Vehicle
        {
            BindingList<T> specificCars = new BindingList<T>();
            foreach (Vehicle car in cars)
            {
                if (car is T)
                {
                    specificCars.Add(car as T);
                }
            }
            return specificCars;
        }
    }
}
