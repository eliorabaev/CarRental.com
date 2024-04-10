using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Carental_Limited.Backend;
using Carental_Limited.Backend.Model;

namespace CarRental.Frontend
{
   
    public partial class MainMenu : Form
    {
        bool carAdd = false;
        bool changeCar = false;
        BindingList<Vehicle> cars = CarsManager.GetSpecificCars<Vehicle>();
        private bool parkingLot0Selected = false;
        private bool parkingLot1Selected = false;
        private bool parkingLot2Selected = false;
        private bool parkingLot3Selected = false;
        private bool parkingLot4Selected = false;
        private bool parkingLot5Selected = false;
        private bool parkingLot6Selected = false;
        private bool parkingLot7Selected = false;
        int[] counter = new int[8];
        int isChecked = 0;
        private bool isDragging0;
        private Point offset0;
        private Point originalLocation0;
        private bool isDragging1;
        private Point offset1;
        private Point originalLocation1;
        private bool isDragging2;
        private Point offset2;
        private Point originalLocation2;
        private bool isDragging3;
        private Point offset3;
        private Point originalLocation3;
        private bool isDragging4;
        private Point offset4;
        private Point originalLocation4;
        private bool isDragging5;
        private Point offset5;
        private Point originalLocation5;
        private bool isDragging6;
        private Point offset6;
        private Point originalLocation6;
        private bool isDragging7;
        private Point offset7;
        private Point originalLocation7;
        private Dictionary<PictureBox, ToolTip> pictureBoxTooltips = new Dictionary<PictureBox, ToolTip>();
        public MainMenu()
        {
            InitializeComponent();


            timer1.Start();
            timerForTime.Start();
            timeTxt.Text = DateTime.Now.ToLongTimeString();
            originalLocation0 = parkingLot0.Location;
            originalLocation1 = parkingLot1.Location;
            originalLocation2 = parkingLot2.Location;
            originalLocation3 = parkingLot3.Location;
            originalLocation4 = parkingLot4.Location;
            originalLocation5 = parkingLot5.Location;
            originalLocation6 = parkingLot6.Location;
            originalLocation7 = parkingLot7.Location;
            foreach (Vehicle car in cars)
            {
                if (car.type() == 1)
                {
                    if (parkingLot0.Image == null)
                    {
                        parkingLot0.Image = CarRental.Properties.Resources.Family;
                    }
                    else if (parkingLot1.Image == null)
                    {
                        parkingLot1.Image = CarRental.Properties.Resources.Family;
                    }
                    else if (parkingLot2.Image == null)
                    {
                        parkingLot2.Image = CarRental.Properties.Resources.Family;
                    }
                    else if (parkingLot3.Image == null)
                    {
                        parkingLot3.Image = CarRental.Properties.Resources.Family;
                    }
                    else if (parkingLot4.Image == null)
                    {
                        parkingLot4.Image = CarRental.Properties.Resources.Family;
                    }
                    else if (parkingLot5.Image == null)
                    {
                        parkingLot5.Image = CarRental.Properties.Resources.Family;
                    }
                    else if (parkingLot6.Image == null)
                    {
                        parkingLot6.Image = CarRental.Properties.Resources.Family;
                    }
                    else if (parkingLot7.Image == null)
                    {
                        parkingLot7.Image = CarRental.Properties.Resources.Family;
                    }
                    else
                    {
                        MessageBox.Show("No place to add new cars");
                    }
                }
                if (car.type() == 2)
                {
                    if (parkingLot0.Image == null)
                    {
                        parkingLot0.Image = CarRental.Properties.Resources.Sport;
                    }
                    else if (parkingLot1.Image == null)
                    {
                        parkingLot1.Image = CarRental.Properties.Resources.Sport;
                    }
                    else if (parkingLot2.Image == null)
                    {
                        parkingLot2.Image = CarRental.Properties.Resources.Sport;
                    }
                    else if (parkingLot3.Image == null)
                    {
                        parkingLot3.Image = CarRental.Properties.Resources.Sport;
                    }
                    else if (parkingLot4.Image == null)
                    {
                        parkingLot4.Image = CarRental.Properties.Resources.Sport;
                    }
                    else if (parkingLot5.Image == null)
                    {
                        parkingLot5.Image = CarRental.Properties.Resources.Sport;
                    }
                    else if (parkingLot6.Image == null)
                    {
                        parkingLot6.Image = CarRental.Properties.Resources.Sport;
                    }
                    else if (parkingLot7.Image == null)
                    {
                        parkingLot7.Image = CarRental.Properties.Resources.Sport;
                    }
                    else
                    {
                        MessageBox.Show("No place to add new cars");
                    }
                }
                if (car.type() == 3)
                {
                    if (parkingLot0.Image == null)
                    {
                        parkingLot0.Image = CarRental.Properties.Resources.Commercial;
                    }
                    else if (parkingLot1.Image == null)
                    {
                        parkingLot1.Image = CarRental.Properties.Resources.Commercial;
                    }
                    else if (parkingLot2.Image == null)
                    {
                        parkingLot2.Image = CarRental.Properties.Resources.Commercial;
                    }
                    else if (parkingLot3.Image == null)
                    {
                        parkingLot3.Image = CarRental.Properties.Resources.Commercial;
                    }
                    else if (parkingLot4.Image == null)
                    {
                        parkingLot4.Image = CarRental.Properties.Resources.Commercial;
                    }
                    else if (parkingLot5.Image == null)
                    {
                        parkingLot5.Image = CarRental.Properties.Resources.Commercial;
                    }
                    else if (parkingLot6.Image == null)
                    {
                        parkingLot6.Image = CarRental.Properties.Resources.Commercial;
                    }
                    else if (parkingLot7.Image == null)
                    {
                        parkingLot7.Image = CarRental.Properties.Resources.Commercial;
                    }
                    else
                    {
                        MessageBox.Show("No place to add new cars");
                    }
                }
                if (car.type() == 4)
                {
                    if (parkingLot0.Image == null)
                    {
                        parkingLot0.Image = CarRental.Properties.Resources.Truck;
                    }
                    else if (parkingLot1.Image == null)
                    {
                        parkingLot1.Image = CarRental.Properties.Resources.Truck;
                    }
                    else if (parkingLot2.Image == null)
                    {
                        parkingLot2.Image = CarRental.Properties.Resources.Truck;
                    }
                    else if (parkingLot3.Image == null)
                    {
                        parkingLot3.Image = CarRental.Properties.Resources.Truck;
                    }
                    else if (parkingLot4.Image == null)
                    {
                        parkingLot4.Image = CarRental.Properties.Resources.Truck;
                    }
                    else if (parkingLot5.Image == null)
                    {
                        parkingLot5.Image = CarRental.Properties.Resources.Truck;
                    }
                    else if (parkingLot6.Image == null)
                    {
                        parkingLot6.Image = CarRental.Properties.Resources.Truck;
                    }
                    else if (parkingLot7.Image == null)
                    {
                        parkingLot7.Image = CarRental.Properties.Resources.Truck;
                    }
                    else
                    {
                        MessageBox.Show("No place to add new cars");
                    }
                }
            }
        }
        private void parkingLot0_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;

            if (parkingLot0Selected == true)
            {
                parkingLot0Selected = false;
                parkingLot0.BorderStyle = BorderStyle.None;
                counter[0] = 0;
                isChecked--;
            }
            else
            {
                parkingLot0Selected = true;
                parkingLot0.BorderStyle = BorderStyle.Fixed3D;
                counter[0] = 1;
                isChecked++;
            }
        }

        private void parkingLot1_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;

            if (parkingLot1Selected == true)
            {
                parkingLot1Selected = false;
                parkingLot1.BorderStyle = BorderStyle.None;
                counter[1] = 0;
                isChecked--;
            }
            else
            {
                parkingLot1Selected = true;
                parkingLot1.BorderStyle = BorderStyle.Fixed3D;
                counter[1] = 1;
                isChecked++;
            }
        }

        private void parkingLot2_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;

            if (parkingLot2Selected == true)
            {
                parkingLot2Selected = false;
                parkingLot2.BorderStyle = BorderStyle.None;
                counter[2] = 0;
                isChecked--;
            }
            else
            {
                parkingLot2Selected = true;
                parkingLot2.BorderStyle = BorderStyle.Fixed3D;
                counter[2] = 1;
                isChecked++;
            }
        }

        private void parkingLot3_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;

            if (parkingLot3Selected == true)
            {
                parkingLot3Selected = false;
                parkingLot3.BorderStyle = BorderStyle.None;
                counter[3] = 0;
                isChecked--;
            }
            else
            {
                parkingLot3Selected = true;
                parkingLot3.BorderStyle = BorderStyle.Fixed3D;
                counter[3] = 1;
                isChecked++;
            }
        }

        private void parkingLot4_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;

            if (parkingLot4Selected == true)
            {
                parkingLot4Selected = false;
                parkingLot4.BorderStyle = BorderStyle.None;
                counter[4] = 0;
                isChecked--;
            }
            else
            {
                parkingLot4Selected = true;
                parkingLot4.BorderStyle = BorderStyle.Fixed3D;
                counter[4] = 1;
                isChecked++;
            }
        }

        private void parkingLot5_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;

            if (parkingLot5Selected == true)
            {
                parkingLot5Selected = false;
                parkingLot5.BorderStyle = BorderStyle.None;
                counter[5] = 0;
                isChecked--;
            }
            else
            {
                parkingLot5Selected = true;
                parkingLot5.BorderStyle = BorderStyle.Fixed3D;
                counter[5] = 1;
                isChecked++;
            }
        }

        private void parkingLot6_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;

            if (parkingLot6Selected == true)
            {
                parkingLot6Selected = false;
                parkingLot6.BorderStyle = BorderStyle.None;
                counter[6] = 0;
                isChecked--;
            }
            else
            {
                parkingLot6Selected = true;
                parkingLot6.BorderStyle = BorderStyle.Fixed3D;
                counter[6] = 1;
                isChecked++;
            }
        }

        private void parkingLot7_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;

            if (parkingLot7Selected == true)
            {
                parkingLot7Selected = false;
                parkingLot7.BorderStyle = BorderStyle.None;
                counter[7] = 0;
                isChecked--;
            }
            else
            {
                parkingLot7Selected = true;
                parkingLot7.BorderStyle = BorderStyle.Fixed3D;
                counter[7] = 1;
                isChecked++;
            }
        }



        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (parkingLot0Selected || parkingLot1Selected || parkingLot2Selected || parkingLot3Selected || parkingLot4Selected || parkingLot5Selected || parkingLot6Selected || parkingLot7Selected)
            {



                for (int i = 7; i >= 0; i--)
                {
                    if (counter[i] != 0)
                    {
                        CarsManager.RemoveCar(i);
                        counter[i] = 0;
                    }

                }
                refreshCars();
                
            }
            else
            {
                MessageBox.Show("Please select the car or cars that you want to remove from your inventory.");
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (carAdd == false)
            {
                CarTypelbl.Show();
                CarTypeCombo.Show();
                Pricelbl.Show();
                Pricetxt.Show();
                Fuellbl.Show();
                Fueltxt.Show();
                CarNumlbl.Show();
                CarNumtxt.Show();
                Companylbl.Show();
                Companytxt.Show();
                CarSpeedlbl.Show();
                CarSpeedtxt.Show();
                AddCar.Show();
                carAdd = true;
            }
            else
            {
                CarTypelbl.Hide();
                CarTypeCombo.Hide();
                Pricelbl.Hide();
                Pricetxt.Hide();
                Fuellbl.Hide();
                Fueltxt.Hide();
                CarNumlbl.Hide();
                CarNumtxt.Hide();
                Companylbl.Hide();
                Companytxt.Hide();
                CarSpeedlbl.Hide();
                CarSpeedtxt.Hide();
                Seatslbl.Hide();
                ScreenscheckBox.Hide();
                Workshopcheckbox.Hide();
                Seatstxt.Hide();
                Licenselbl.Hide();
                Licensetxt.Hide();
                TrunkVolumelbl.Hide();
                TrunkVolumetxt.Hide();
                LoadingCapacitylbl.Hide();
                LoadingCapacitytxt.Hide();
                TowingCapacitylbl.Hide();
                TowingCapacitytxt.Hide();
                AddCar.Hide();
                carAdd = false;
            }

        }

        private void ScreenscheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CarTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CarTypeCombo.SelectedItem.ToString() == "Family Car")
            {
                Seatslbl.Show();
                ScreenscheckBox.Show();
                Workshopcheckbox.Hide();
                Seatstxt.Show();
                Licenselbl.Hide();
                Licensetxt.Hide();
                TrunkVolumelbl.Hide();
                TrunkVolumetxt.Hide();
                LoadingCapacitylbl.Hide();
                LoadingCapacitytxt.Hide();
                TowingCapacitylbl.Hide();
                TowingCapacitytxt.Hide();
                CarSpeedtxt.Text = "260";
            }
            if (CarTypeCombo.SelectedItem.ToString() == "Sport Car")
            {
                Seatslbl.Show();
                ScreenscheckBox.Hide();
                Workshopcheckbox.Show();
                Seatstxt.Show();
                Licenselbl.Hide();
                Licensetxt.Hide();
                TrunkVolumelbl.Hide();
                TrunkVolumetxt.Hide();
                LoadingCapacitylbl.Hide();
                LoadingCapacitytxt.Hide();
                TowingCapacitylbl.Hide();
                TowingCapacitytxt.Hide();
                CarSpeedtxt.Text = "300";
            }
            if (CarTypeCombo.SelectedItem.ToString() == "Commercial Car")
            {
                Seatslbl.Hide();
                ScreenscheckBox.Hide();
                Workshopcheckbox.Hide();
                Seatstxt.Hide();
                Licenselbl.Show();
                Licensetxt.Show();
                TrunkVolumelbl.Show();
                TrunkVolumetxt.Show();
                LoadingCapacitylbl.Hide();
                LoadingCapacitytxt.Hide();
                TowingCapacitylbl.Hide();
                TowingCapacitytxt.Hide();
                CarSpeedtxt.Text = "160";
            }
            if (CarTypeCombo.SelectedItem.ToString() == "Truck")
            {
                Seatslbl.Hide();
                ScreenscheckBox.Hide();
                Workshopcheckbox.Hide();
                Seatstxt.Hide();
                Licenselbl.Show();
                Licensetxt.Show();
                TrunkVolumelbl.Hide();
                TrunkVolumetxt.Hide();
                LoadingCapacitylbl.Show();
                LoadingCapacitytxt.Show();
                TowingCapacitylbl.Show();
                TowingCapacitytxt.Show();
                CarSpeedtxt.Text = "130";
            }
        }

        private bool IsValidForm()
        {
            int carNum;
            return Int32.TryParse(CarNumtxt.Text, out carNum);
        }

        private void AddCar_Click(object sender, EventArgs e)
        {
            if (IsValidForm())
            {
                if (CarTypeCombo.SelectedItem.ToString() == "Family Car")
                {
                    double price;
                    bool isPriceValid = double.TryParse(Pricetxt.Text, out price);

                    string fuel = Fueltxt.Text;

                    int carNum;
                    bool isCarNumValid = int.TryParse(CarNumtxt.Text, out carNum);

                    string company = Companytxt.Text;

                    int seats;
                    bool isSeatsValid = int.TryParse(Seatstxt.Text, out seats);

                    bool screens = ScreenscheckBox.Checked;

                    if (isPriceValid && isCarNumValid && isSeatsValid)
                    {
                        Vehicle family_Car = new FamilyCar(price, fuel, carNum, company, seats, screens);

                        if (parkingLot7.Image == null)
                        {
                            CarsManager.AddCar(family_Car);
                            cars.Add(family_Car);
                            FileUtiles.SaveCarsToFile(cars);
                            MessageBox.Show("Car added successfully to your inventory!");

                            price = 0.0;
                            fuel = "";
                            carNum = 0;
                            company = "";
                            seats = 0;
                            screens = false;

                            Pricetxt.Text = "";
                            Fueltxt.Text = "";
                            CarNumtxt.Text = "";
                            Companytxt.Text = "";
                            Seatstxt.Text = "";
                            ScreenscheckBox.Checked = false;
                        }
                        if (parkingLot0.Image == null)
                        {
                            parkingLot0.Image = CarRental.Properties.Resources.Family;
                        }
                        else if (parkingLot1.Image == null)
                        {
                            parkingLot1.Image = CarRental.Properties.Resources.Family;
                        }
                        else if (parkingLot2.Image == null)
                        {
                            parkingLot2.Image = CarRental.Properties.Resources.Family;
                        }
                        else if (parkingLot3.Image == null)
                        {
                            parkingLot3.Image = CarRental.Properties.Resources.Family;
                        }
                        else if (parkingLot4.Image == null)
                        {
                            parkingLot4.Image = CarRental.Properties.Resources.Family;
                        }
                        else if (parkingLot5.Image == null)
                        {
                            parkingLot5.Image = CarRental.Properties.Resources.Family;
                        }
                        else if (parkingLot6.Image == null)
                        {
                            parkingLot6.Image = CarRental.Properties.Resources.Family;
                        }
                        else if (parkingLot7.Image == null)
                        {
                            parkingLot7.Image = CarRental.Properties.Resources.Family;
                        }
                        else
                        {
                            MessageBox.Show("No place to add new cars");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid input. Please enter valid values for the price, car number, and seats.");
                    }
                }

                if (CarTypeCombo.SelectedItem.ToString() == "Sport Car")
                {
                    double price;
                    bool isPriceValid = double.TryParse(Pricetxt.Text, out price);

                    string fuel = Fueltxt.Text;

                    int carNum;
                    bool isCarNumValid = int.TryParse(CarNumtxt.Text, out carNum);

                    string company = Companytxt.Text;

                    int seats;
                    bool isSeatsValid = int.TryParse(Seatstxt.Text, out seats);

                    bool workshop = Workshopcheckbox.Checked;

                    if (isPriceValid && isCarNumValid && isSeatsValid)
                    {
                        if (parkingLot7.Image == null)
                        {
                            Vehicle Sport_Car = new SportCar(price, fuel, carNum, company, seats, workshop);
                            CarsManager.AddCar(Sport_Car);
                            cars.Add(Sport_Car);
                            FileUtiles.SaveCarsToFile(cars);
                            MessageBox.Show("Car added successfully to your inventory!");

                            price = 0.0;
                            fuel = "";
                            carNum = 0;
                            company = "";
                            seats = 0;
                            workshop = false;

                            Pricetxt.Text = "";
                            Fueltxt.Text = "";
                            CarNumtxt.Text = "";
                            Companytxt.Text = "";
                            Seatstxt.Text = "";
                            Workshopcheckbox.Checked = false;
                        }
                        if (parkingLot0.Image == null)
                        {
                            parkingLot0.Image = CarRental.Properties.Resources.Sport;
                        }
                        else if (parkingLot1.Image == null)
                        {
                            parkingLot1.Image = CarRental.Properties.Resources.Sport;
                        }
                        else if (parkingLot2.Image == null)
                        {
                            parkingLot2.Image = CarRental.Properties.Resources.Sport;
                        }
                        else if (parkingLot3.Image == null)
                        {
                            parkingLot3.Image = CarRental.Properties.Resources.Sport;
                        }
                        else if (parkingLot4.Image == null)
                        {
                            parkingLot4.Image = CarRental.Properties.Resources.Sport;
                        }
                        else if (parkingLot5.Image == null)
                        {
                            parkingLot5.Image = CarRental.Properties.Resources.Sport;
                        }
                        else if (parkingLot6.Image == null)
                        {
                            parkingLot6.Image = CarRental.Properties.Resources.Sport;
                        }
                        else if (parkingLot7.Image == null)
                        {
                            parkingLot7.Image = CarRental.Properties.Resources.Sport;
                        }
                        else
                        {
                            MessageBox.Show("No place to add new cars");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid input. Please enter valid values for the price, car number, and seats.");
                    }
                    
                }

                if (CarTypeCombo.SelectedItem.ToString() == "Commercial Car")
                {
                    double price;
                    bool isPriceValid = double.TryParse(Pricetxt.Text, out price);

                    string fuel = Fueltxt.Text;

                    int carNum;
                    bool isCarNumValid = int.TryParse(CarNumtxt.Text, out carNum);

                    string company = Companytxt.Text;
                    string license = Licensetxt.Text;

                    int trunkVolume;
                    bool isTrunkVolumeValid = int.TryParse(TrunkVolumetxt.Text, out trunkVolume);
                    if (isPriceValid && isCarNumValid && isTrunkVolumeValid)
                    {
                        Vehicle Commercial_Vehicle = new CommercialVehicle(price, fuel, carNum, company, license, trunkVolume);

                        if (parkingLot7.Image == null)
                        {
                            CarsManager.AddCar(Commercial_Vehicle);
                            cars.Add(Commercial_Vehicle);
                            FileUtiles.SaveCarsToFile(cars);
                            MessageBox.Show("Car added successfully to your inventory!");

                            price = 0.0;
                            fuel = "";
                            carNum = 0;
                            company = "";
                            license = "";
                            trunkVolume = 0;

                            Pricetxt.Text = "";
                            Fueltxt.Text = "";
                            CarNumtxt.Text = "";
                            Companytxt.Text = "";
                            Licensetxt.Text = "";
                            TrunkVolumetxt.Text = "";
                        }
                        if (parkingLot0.Image == null)
                        {
                            parkingLot0.Image = CarRental.Properties.Resources.Commercial;
                        }
                        else if (parkingLot1.Image == null)
                        {
                            parkingLot1.Image = CarRental.Properties.Resources.Commercial;
                        }
                        else if (parkingLot2.Image == null)
                        {
                            parkingLot2.Image = CarRental.Properties.Resources.Commercial;
                        }
                        else if (parkingLot3.Image == null)
                        {
                            parkingLot3.Image = CarRental.Properties.Resources.Commercial;
                        }
                        else if (parkingLot4.Image == null)
                        {
                            parkingLot4.Image = CarRental.Properties.Resources.Commercial;
                        }
                        else if (parkingLot5.Image == null)
                        {
                            parkingLot5.Image = CarRental.Properties.Resources.Commercial;
                        }
                        else if (parkingLot6.Image == null)
                        {
                            parkingLot6.Image = CarRental.Properties.Resources.Commercial;
                        }
                        else if (parkingLot7.Image == null)
                        {
                            parkingLot7.Image = CarRental.Properties.Resources.Commercial;
                        }
                        else
                        {
                            MessageBox.Show("No place to add new cars");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid input. Please enter valid values for the price, car number, and trunk volume.");
                    }
                }

                if (CarTypeCombo.SelectedItem.ToString() == "Truck")
                {
                    double price;
                    bool isPriceValid = double.TryParse(Pricetxt.Text, out price);

                    string fuel = Fueltxt.Text;

                    int carNum;
                    bool isCarNumValid = int.TryParse(CarNumtxt.Text, out carNum);

                    string company = Companytxt.Text;

                    string license = Licensetxt.Text;

                    int loadingCapacity;
                    bool isLoadingCapacityValid = int.TryParse(LoadingCapacitytxt.Text, out loadingCapacity);

                    int towingCapacity;
                    bool isTowingCapacityValid = int.TryParse(TowingCapacitytxt.Text, out towingCapacity);
                    if (isPriceValid && isCarNumValid && isLoadingCapacityValid && isTowingCapacityValid)
                    {
                        Vehicle truck = new Truck(price, fuel, carNum, company, license, loadingCapacity, towingCapacity);

                        if (parkingLot7.Image == null)
                        {
                            CarsManager.AddCar(truck);
                            cars.Add(truck);
                            FileUtiles.SaveCarsToFile(cars);
                            MessageBox.Show("Car added successfully to your inventory!");

                            price = 0.0;
                            fuel = "";
                            carNum = 0;
                            company = "";
                            license = "";
                            loadingCapacity = 0;
                            towingCapacity = 0;

                            Pricetxt.Text = "";
                            Fueltxt.Text = "";
                            CarNumtxt.Text = "";
                            Companytxt.Text = "";
                            Licensetxt.Text = "";
                            LoadingCapacitytxt.Text = "";
                            TowingCapacitytxt.Text = "";
                        }
                        if (parkingLot0.Image == null)
                        {
                            parkingLot0.Image = CarRental.Properties.Resources.Truck;
                        }
                        else if (parkingLot1.Image == null)
                        {
                            parkingLot1.Image = CarRental.Properties.Resources.Truck;
                        }
                        else if (parkingLot2.Image == null)
                        {
                            parkingLot2.Image = CarRental.Properties.Resources.Truck;
                        }
                        else if (parkingLot3.Image == null)
                        {
                            parkingLot3.Image = CarRental.Properties.Resources.Truck;
                        }
                        else if (parkingLot4.Image == null)
                        {
                            parkingLot4.Image = CarRental.Properties.Resources.Truck;
                        }
                        else if (parkingLot5.Image == null)
                        {
                            parkingLot5.Image = CarRental.Properties.Resources.Truck;
                        }
                        else if (parkingLot6.Image == null)
                        {
                            parkingLot6.Image = CarRental.Properties.Resources.Truck;
                        }
                        else if (parkingLot7.Image == null)
                        {
                            parkingLot7.Image = CarRental.Properties.Resources.Truck;
                        }
                        else
                        {
                            MessageBox.Show("No place to add new cars");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid input. Please enter valid values for the price, car number, loading capacity, and towing capacity.");
                    }
                }
            }
            else
            {

                MessageBox.Show("One or more of your values in invalid");
            }
      
        }
        private void Swap_Click(object sender, EventArgs e)
        {
            int[] temp = new int[2];
            int i, j=0;
            if (isChecked != 2)
            {
                MessageBox.Show("choose only two cars at a time!");
            }
            else
            {
                for (i = 0; i < 8; i++)
                {
                    if (counter[i] == 1)
                        temp[j++] = i;
                }
                CarsManager.SwapCars(temp[0], temp[1]);
                for (int l = 7; l >= 0; l--)
                {
                    counter[l] = 0;
                }
                refreshCars();
            }

        }


        void refreshCars()
        {
            for (int i = 7; i >= 0; i--)
            {
                if (counter[i] != 0)
                {
                    counter[i] = 0;
                }

            }
            isChecked = 0;
            cars = CarsManager.GetSpecificCars<Vehicle>();
            FileUtiles.SaveCarsToFile(cars);
            parkingLot0.Image = null;
            parkingLot1.Image = null;
            parkingLot2.Image = null;
            parkingLot3.Image = null;
            parkingLot4.Image = null;
            parkingLot5.Image = null;
            parkingLot6.Image = null;
            parkingLot7.Image = null;

            parkingLot0Selected = false;
            parkingLot1Selected = false;
            parkingLot2Selected = false;
            parkingLot3Selected = false;
            parkingLot4Selected = false;
            parkingLot5Selected = false;
            parkingLot6Selected = false;
            parkingLot7Selected = false;

            parkingLot0.BorderStyle = BorderStyle.None;
            parkingLot1.BorderStyle = BorderStyle.None;
            parkingLot2.BorderStyle = BorderStyle.None;
            parkingLot3.BorderStyle = BorderStyle.None;
            parkingLot4.BorderStyle = BorderStyle.None;
            parkingLot5.BorderStyle = BorderStyle.None;
            parkingLot6.BorderStyle = BorderStyle.None;
            parkingLot7.BorderStyle = BorderStyle.None;

            foreach (Vehicle car in cars)
            {
                if (car.type() == 1)
                {
                    if (parkingLot0.Image == null)
                    {
                        parkingLot0.Image = CarRental.Properties.Resources.Family;
                    }
                    else if (parkingLot1.Image == null)
                    {
                        parkingLot1.Image = CarRental.Properties.Resources.Family;
                    }
                    else if (parkingLot2.Image == null)
                    {
                        parkingLot2.Image = CarRental.Properties.Resources.Family;
                    }
                    else if (parkingLot3.Image == null)
                    {
                        parkingLot3.Image = CarRental.Properties.Resources.Family;
                    }
                    else if (parkingLot4.Image == null)
                    {
                        parkingLot4.Image = CarRental.Properties.Resources.Family;
                    }
                    else if (parkingLot5.Image == null)
                    {
                        parkingLot5.Image = CarRental.Properties.Resources.Family;
                    }
                    else if (parkingLot6.Image == null)
                    {
                        parkingLot6.Image = CarRental.Properties.Resources.Family;
                    }
                    else if (parkingLot7.Image == null)
                    {
                        parkingLot7.Image = CarRental.Properties.Resources.Family;
                    }
                    else
                    {
                        MessageBox.Show("No place to add new cars");
                    }
                }
                if (car.type() == 2)
                {
                    if (parkingLot0.Image == null)
                    {
                        parkingLot0.Image = CarRental.Properties.Resources.Sport;
                    }
                    else if (parkingLot1.Image == null)
                    {
                        parkingLot1.Image = CarRental.Properties.Resources.Sport;
                    }
                    else if (parkingLot2.Image == null)
                    {
                        parkingLot2.Image = CarRental.Properties.Resources.Sport;
                    }
                    else if (parkingLot3.Image == null)
                    {
                        parkingLot3.Image = CarRental.Properties.Resources.Sport;
                    }
                    else if (parkingLot4.Image == null)
                    {
                        parkingLot4.Image = CarRental.Properties.Resources.Sport;
                    }
                    else if (parkingLot5.Image == null)
                    {
                        parkingLot5.Image = CarRental.Properties.Resources.Sport;
                    }
                    else if (parkingLot6.Image == null)
                    {
                        parkingLot6.Image = CarRental.Properties.Resources.Sport;
                    }
                    else if (parkingLot7.Image == null)
                    {
                        parkingLot7.Image = CarRental.Properties.Resources.Sport;
                    }
                    else
                    {
                        MessageBox.Show("No place to add new cars");
                    }
                }
                if (car.type() == 3)
                {
                    if (parkingLot0.Image == null)
                    {
                        parkingLot0.Image = CarRental.Properties.Resources.Commercial;
                    }
                    else if (parkingLot1.Image == null)
                    {
                        parkingLot1.Image = CarRental.Properties.Resources.Commercial;
                    }
                    else if (parkingLot2.Image == null)
                    {
                        parkingLot2.Image = CarRental.Properties.Resources.Commercial;
                    }
                    else if (parkingLot3.Image == null)
                    {
                        parkingLot3.Image = CarRental.Properties.Resources.Commercial;
                    }
                    else if (parkingLot4.Image == null)
                    {
                        parkingLot4.Image = CarRental.Properties.Resources.Commercial;
                    }
                    else if (parkingLot5.Image == null)
                    {
                        parkingLot5.Image = CarRental.Properties.Resources.Commercial;
                    }
                    else if (parkingLot6.Image == null)
                    {
                        parkingLot6.Image = CarRental.Properties.Resources.Commercial;
                    }
                    else if (parkingLot7.Image == null)
                    {
                        parkingLot7.Image = CarRental.Properties.Resources.Commercial;
                    }
                    else
                    {
                        MessageBox.Show("No place to add new cars");
                    }
                }
                if (car.type() == 4)
                {
                    if (parkingLot0.Image == null)
                    {
                        parkingLot0.Image = CarRental.Properties.Resources.Truck;
                    }
                    else if (parkingLot1.Image == null)
                    {
                        parkingLot1.Image = CarRental.Properties.Resources.Truck;
                    }
                    else if (parkingLot2.Image == null)
                    {
                        parkingLot2.Image = CarRental.Properties.Resources.Truck;
                    }
                    else if (parkingLot3.Image == null)
                    {
                        parkingLot3.Image = CarRental.Properties.Resources.Truck;
                    }
                    else if (parkingLot4.Image == null)
                    {
                        parkingLot4.Image = CarRental.Properties.Resources.Truck;
                    }
                    else if (parkingLot5.Image == null)
                    {
                        parkingLot5.Image = CarRental.Properties.Resources.Truck;
                    }
                    else if (parkingLot6.Image == null)
                    {
                        parkingLot6.Image = CarRental.Properties.Resources.Truck;
                    }
                    else if (parkingLot7.Image == null)
                    {
                        parkingLot7.Image = CarRental.Properties.Resources.Truck;
                    }
                    else
                    {
                        MessageBox.Show("No place to add new cars");
                    }
                }
            }
        }

        private void InventoryList_Click(object sender, EventArgs e)
        {
            Form inv = new Inventory();
            inv.Show();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Changebtn_Click(object sender, EventArgs e)
        {
            if (isChecked == 1 && changeCar == false)
            {
                Vehicle tempCar = new SportCar(0, "0", 0, "0", 0,false);
                for(int i = 0; i<8; i++)
                {
                    if(counter[i] == 1)
                    {
                        tempCar = CarsManager.GetVehicleByIndex(i);
                    }
                }
                if (tempCar._price != -1) { 
                    changeCar = true;
                    Add.Hide();
                    AddCar.Hide();
                    selectlbl.Show();
                    changecarbtn.Show();
                    CarTypelbl.Show();
                    CarTypeCombo.Show();
                    Pricelbl.Show();
                    Pricetxt.Show();
                    Fuellbl.Show();
                    Fueltxt.Show();
                    CarNumlbl.Show();
                    CarNumtxt.Show();
                    Companylbl.Show();
                    Companytxt.Show();
                    CarSpeedlbl.Show();
                    CarSpeedtxt.Show();
                    DeleteCars.Hide();
                    Swap.Hide();
                }
                else
                {
                    MessageBox.Show("No car was found at the parking lot. Please select a valid parking lot");
                }
            }
            else if (changeCar == true)
            {
                changeCar = false;
                Add.Show();
                AddCar.Show();
                selectlbl.Hide();
                changecarbtn.Hide();
                CarTypelbl.Hide();
                CarTypeCombo.Hide();
                Pricelbl.Hide();
                Pricetxt.Hide();
                Fuellbl.Hide();
                Fueltxt.Hide();
                CarNumlbl.Hide();
                CarNumtxt.Hide();
                Companylbl.Hide();
                Companytxt.Hide();
                CarSpeedlbl.Hide();
                CarSpeedtxt.Hide();
                Seatslbl.Hide();
                ScreenscheckBox.Hide();
                Workshopcheckbox.Hide();
                Seatstxt.Hide();
                Licenselbl.Hide();
                Licensetxt.Hide();
                TrunkVolumelbl.Hide();
                TrunkVolumetxt.Hide();
                LoadingCapacitylbl.Hide();
                LoadingCapacitytxt.Hide();
                TowingCapacitylbl.Hide();
                TowingCapacitytxt.Hide();
                AddCar.Hide();
                DeleteCars.Show();
                Swap.Show();
            }
            else
            {
                MessageBox.Show("Please Select 1 Car To Change");
            }
        }

        private void changecarbtn_Click(object sender, EventArgs e)
        {
            if(isChecked == 1) { 
            Vehicle car;
            int idx = -1;
            for (int i = 0; i < 8; i++)
            {
                if (counter[i] == 1)
                {
                    car = cars[i];
                    idx = i;
                }
            }
            if (IsValidForm())
            {
                if (CarTypeCombo.SelectedItem.ToString() == "Family Car")
                {
                    double price;
                    bool isPriceValid = double.TryParse(Pricetxt.Text, out price);

                    string fuel = Fueltxt.Text;

                    int carNum;
                    bool isCarNumValid = int.TryParse(CarNumtxt.Text, out carNum);

                    string company = Companytxt.Text;

                    int seats;
                    bool isSeatsValid = int.TryParse(Seatstxt.Text, out seats);

                    bool screens = ScreenscheckBox.Checked;

                    if (isPriceValid && isCarNumValid && isSeatsValid)
                    {
                        car = new FamilyCar(price, fuel, carNum, company, seats, screens);
                        CarsManager.ChangeCar(car, idx);
                        FileUtiles.SaveCarsToFile(cars);
                        MessageBox.Show("Car successfully changed! Inventory was updated");

                        price = 0.0;
                        fuel = "";
                        carNum = 0;
                        company = "";
                        seats = 0;
                        screens = false;

                        Pricetxt.Text = "";
                        Fueltxt.Text = "";
                        CarNumtxt.Text = "";
                        Companytxt.Text = "";
                        Seatstxt.Text = "";
                        ScreenscheckBox.Checked = false;
                        refreshCars();
                    }
                    else
                    {
                        MessageBox.Show("Invalid input. Please enter valid values for the price, car number, and seats.");
                    }
                }

                if (CarTypeCombo.SelectedItem.ToString() == "Sport Car")
                {
                    double price;
                    bool isPriceValid = double.TryParse(Pricetxt.Text, out price);

                    string fuel = Fueltxt.Text;

                    int carNum;
                    bool isCarNumValid = int.TryParse(CarNumtxt.Text, out carNum);

                    string company = Companytxt.Text;

                    int seats;
                    bool isSeatsValid = int.TryParse(Seatstxt.Text, out seats);

                    bool workshop = Workshopcheckbox.Checked;

                    if (isPriceValid && isCarNumValid && isSeatsValid)
                    {

                        car = new SportCar(price, fuel, carNum, company, seats, workshop);
                        CarsManager.ChangeCar(car, idx);
                        FileUtiles.SaveCarsToFile(cars);
                        MessageBox.Show("Car successfully changed! Inventory was updated");

                        price = 0.0;
                        fuel = "";
                        carNum = 0;
                        company = "";
                        seats = 0;
                        workshop = false;

                        Pricetxt.Text = "";
                        Fueltxt.Text = "";
                        CarNumtxt.Text = "";
                        Companytxt.Text = "";
                        Seatstxt.Text = "";
                        Workshopcheckbox.Checked = false;
                        refreshCars();
                    }
                    else
                    {
                        MessageBox.Show("Invalid input. Please enter valid values for the price, car number, and seats.");
                    }
                }

                if (CarTypeCombo.SelectedItem.ToString() == "Commercial Car")
                {
                    double price;
                    bool isPriceValid = double.TryParse(Pricetxt.Text, out price);

                    string fuel = Fueltxt.Text;

                    int carNum;
                    bool isCarNumValid = int.TryParse(CarNumtxt.Text, out carNum);

                    string company = Companytxt.Text;
                    string license = Licensetxt.Text;

                    int trunkVolume;
                    bool isTrunkVolumeValid = int.TryParse(TrunkVolumetxt.Text, out trunkVolume);

                    if (isPriceValid && isCarNumValid && isTrunkVolumeValid)
                    {
                        car = new CommercialVehicle(price, fuel, carNum, company, license, trunkVolume);
                        CarsManager.ChangeCar(car, idx);
                        FileUtiles.SaveCarsToFile(cars);
                        MessageBox.Show("Car successfully changed! Inventory was updated");

                        price = 0.0;
                        fuel = "";
                        carNum = 0;
                        company = "";
                        license = "";
                        trunkVolume = 0;

                        Pricetxt.Text = "";
                        Fueltxt.Text = "";
                        CarNumtxt.Text = "";
                        Companytxt.Text = "";
                        Licensetxt.Text = "";
                        TrunkVolumetxt.Text = "";
                        refreshCars();
                    }
                    else
                    {
                        MessageBox.Show("Invalid input. Please enter valid values for the price, car number, and trunk volume.");
                    }
                }

                if (CarTypeCombo.SelectedItem.ToString() == "Truck")
                {
                    double price;
                    bool isPriceValid = double.TryParse(Pricetxt.Text, out price);

                    string fuel = Fueltxt.Text;

                    int carNum;
                    bool isCarNumValid = int.TryParse(CarNumtxt.Text, out carNum);

                    string company = Companytxt.Text;

                    string license = Licensetxt.Text;

                    int loadingCapacity;
                    bool isLoadingCapacityValid = int.TryParse(LoadingCapacitytxt.Text, out loadingCapacity);

                    int towingCapacity;
                    bool isTowingCapacityValid = int.TryParse(TowingCapacitytxt.Text, out towingCapacity);

                    if (isPriceValid && isCarNumValid && isLoadingCapacityValid && isTowingCapacityValid)
                    {
                        car = new Truck(price, fuel, carNum, company, license, loadingCapacity, towingCapacity);
                        CarsManager.ChangeCar(car, idx);
                        FileUtiles.SaveCarsToFile(cars);
                        MessageBox.Show("Car successfully changed! Inventory was updated");

                        price = 0.0;
                        fuel = "";
                        carNum = 0;
                        company = "";
                        license = "";
                        loadingCapacity = 0;
                        towingCapacity = 0;

                        Pricetxt.Text = "";
                        Fueltxt.Text = "";
                        CarNumtxt.Text = "";
                        Companytxt.Text = "";
                        Licensetxt.Text = "";
                        LoadingCapacitytxt.Text = "";
                        TowingCapacitytxt.Text = "";
                        refreshCars();
                    }
                    else
                    {
                        MessageBox.Show("Invalid input. Please enter valid values for the price, car number, loading capacity, and towing capacity.");
                    }
                }
            }
            else
            {

                MessageBox.Show("One or more of your values in invalid");
            }
            }
            else
            {
                MessageBox.Show("Please Choose Only One Car To Change");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            walking_man.Left = walking_man.Left + 2;
        }

        private void walking_man_MarginChanged(object sender, EventArgs e)
        {

        }

        private void walking_man_LocationChanged(object sender, EventArgs e)
        {
            if (walking_man.Left >= panel1.Width)
            {
                walking_man.Left = 0 - walking_man.Width;
            }
        }

        private void timerForTime_Tick(object sender, EventArgs e)
        {
            timeTxt.Text = DateTime.Now.ToLongTimeString();
        }

        private void parkingLot0_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BringToFront();
            isDragging0 = true;
            offset0 = new Point(e.X, e.Y);
        }

        private void parkingLot0_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging0)
            {
                PictureBox pictureBox = (PictureBox)sender;
                Point newLocation = pictureBox.Location;
                newLocation.Offset(e.Location.X - offset0.X, e.Location.Y - offset0.Y);

                newLocation.X = Math.Max(0, Math.Min(panel1.Width - pictureBox.Width, newLocation.X));
                newLocation.Y = Math.Max(0, Math.Min(panel1.Height - pictureBox.Height, newLocation.Y));

                pictureBox.Location = newLocation;
            }
        }

        private void sellPic_DragEnter(object sender, DragEventArgs e)
        {
/*            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Move;
            }*/
        }

        private void sellPic_DragDrop(object sender, DragEventArgs e)
        {
          /*  if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                MessageBox.Show("Image dropped!");

                // Reset the picture to its original location
                parkingLot0.Location = originalparkingLot0Location;
            }*/
        }

        private void parkingLot0_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDragging0)
            {
                PictureBox pictureBox = (PictureBox)sender;
                if (pictureBox.Bounds.IntersectsWith(sellPic.Bounds))
                {
                    CarsManager.RemoveCar(0);
                    refreshCars();
                }
                pictureBox.Location = originalLocation0;
                isDragging0 = false;
            }
        }

        private void walking_man_Click(object sender, EventArgs e)
        {

        }

        private void parkingLot1_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BringToFront();
            isDragging1 = true;
            offset1 = new Point(e.X, e.Y);
        }

        private void parkingLot1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging1)
            {
                PictureBox pictureBox = (PictureBox)sender;
                Point newLocation = pictureBox.Location;
                newLocation.Offset(e.Location.X - offset1.X, e.Location.Y - offset1.Y);

                newLocation.X = Math.Max(0, Math.Min(panel1.Width - pictureBox.Width, newLocation.X));
                newLocation.Y = Math.Max(0, Math.Min(panel1.Height - pictureBox.Height, newLocation.Y));

                pictureBox.Location = newLocation;
            }
        }

        private void parkingLot1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDragging1)
            {
                PictureBox pictureBox = (PictureBox)sender;
                if (pictureBox.Bounds.IntersectsWith(sellPic.Bounds))
                {
                    CarsManager.RemoveCar(1);
                    refreshCars();
                }
                pictureBox.Location = originalLocation1;
                isDragging1 = false;
            }
        }

        private void parkingLot2_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BringToFront();
            isDragging2 = true;
            offset2 = new Point(e.X, e.Y);
        }

        private void parkingLot2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging2)
            {
                PictureBox pictureBox = (PictureBox)sender;
                Point newLocation = pictureBox.Location;
                newLocation.Offset(e.Location.X - offset2.X, e.Location.Y - offset2.Y);

                newLocation.X = Math.Max(0, Math.Min(panel1.Width - pictureBox.Width, newLocation.X));
                newLocation.Y = Math.Max(0, Math.Min(panel1.Height - pictureBox.Height, newLocation.Y));

                pictureBox.Location = newLocation;
            }
        }

        private void parkingLot2_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDragging2)
            {
                PictureBox pictureBox = (PictureBox)sender;
                if (pictureBox.Bounds.IntersectsWith(sellPic.Bounds))
                {
                    CarsManager.RemoveCar(2);
                    refreshCars();
                }
                pictureBox.Location = originalLocation2;
                isDragging2 = false;
            }
        }

        private void parkingLot3_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging3)
            {
                PictureBox pictureBox = (PictureBox)sender;
                Point newLocation = pictureBox.Location;
                newLocation.Offset(e.Location.X - offset3.X, e.Location.Y - offset3.Y);

                newLocation.X = Math.Max(0, Math.Min(panel1.Width - pictureBox.Width, newLocation.X));
                newLocation.Y = Math.Max(0, Math.Min(panel1.Height - pictureBox.Height, newLocation.Y));

                pictureBox.Location = newLocation;
            }
        }

        private void parkingLot3_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDragging3)
            {
                PictureBox pictureBox = (PictureBox)sender;
                if (pictureBox.Bounds.IntersectsWith(sellPic.Bounds))
                {
                    CarsManager.RemoveCar(3);
                    refreshCars();
                }
                pictureBox.Location = originalLocation3;
                isDragging3 = false;
            }
        }

        private void parkingLot4_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BringToFront();
            isDragging4 = true;
            offset4 = new Point(e.X, e.Y);
        }

        private void parkingLot5_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BringToFront();
            isDragging5 = true;
            offset5 = new Point(e.X, e.Y);
        }

        private void parkingLot6_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BringToFront();
            isDragging6 = true;
            offset6 = new Point(e.X, e.Y);
        }

        private void parkingLot7_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BringToFront();
            isDragging7 = true;
            offset7 = new Point(e.X, e.Y);
        }

        private void parkingLot3_1_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BringToFront();
            isDragging3 = true;
            offset3 = new Point(e.X, e.Y);
        }

        private void parkingLot4_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging4)
            {
                PictureBox pictureBox = (PictureBox)sender;
                Point newLocation = pictureBox.Location;
                newLocation.Offset(e.Location.X - offset4.X, e.Location.Y - offset4.Y);

                newLocation.X = Math.Max(0, Math.Min(panel1.Width - pictureBox.Width, newLocation.X));
                newLocation.Y = Math.Max(0, Math.Min(panel1.Height - pictureBox.Height, newLocation.Y));

                pictureBox.Location = newLocation;
            }
        }

        private void parkingLot5_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging5)
            {
                PictureBox pictureBox = (PictureBox)sender;
                Point newLocation = pictureBox.Location;
                newLocation.Offset(e.Location.X - offset5.X, e.Location.Y - offset5.Y);

                newLocation.X = Math.Max(0, Math.Min(panel1.Width - pictureBox.Width, newLocation.X));
                newLocation.Y = Math.Max(0, Math.Min(panel1.Height - pictureBox.Height, newLocation.Y));

                pictureBox.Location = newLocation;
            }
        }

        private void parkingLot6_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging6)
            {
                PictureBox pictureBox = (PictureBox)sender;
                Point newLocation = pictureBox.Location;
                newLocation.Offset(e.Location.X - offset6.X, e.Location.Y - offset6.Y);

                newLocation.X = Math.Max(0, Math.Min(panel1.Width - pictureBox.Width, newLocation.X));
                newLocation.Y = Math.Max(0, Math.Min(panel1.Height - pictureBox.Height, newLocation.Y));

                pictureBox.Location = newLocation;
            }
        }

        private void parkingLot7_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging7)
            {
                PictureBox pictureBox = (PictureBox)sender;
                Point newLocation = pictureBox.Location;
                newLocation.Offset(e.Location.X - offset7.X, e.Location.Y - offset7.Y);

                newLocation.X = Math.Max(0, Math.Min(panel1.Width - pictureBox.Width, newLocation.X));
                newLocation.Y = Math.Max(0, Math.Min(panel1.Height - pictureBox.Height, newLocation.Y));

                pictureBox.Location = newLocation;
            }
        }

        private void parkingLot4_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDragging4)
            {
                PictureBox pictureBox = (PictureBox)sender;
                if (pictureBox.Bounds.IntersectsWith(sellPic.Bounds))
                {
                    CarsManager.RemoveCar(4);
                    refreshCars();
                }
                pictureBox.Location = originalLocation4;
                isDragging4 = false;
            }
        }

        private void parkingLot5_Move(object sender, EventArgs e)
        {
            /************************/
        }

        private void parkingLot5_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDragging5)
            {
                PictureBox pictureBox = (PictureBox)sender;
                if (pictureBox.Bounds.IntersectsWith(sellPic.Bounds))
                {
                    CarsManager.RemoveCar(5);
                    refreshCars();
                }
                pictureBox.Location = originalLocation5;
                isDragging5 = false;
            }
        }

        private void parkingLot6_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDragging6)
            {
                PictureBox pictureBox = (PictureBox)sender;
                if (pictureBox.Bounds.IntersectsWith(sellPic.Bounds))
                {
                    CarsManager.RemoveCar(6);
                    refreshCars();
                }
                pictureBox.Location = originalLocation6;
                isDragging6 = false;
            }
        }

        private void parkingLot7_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDragging7)
            {
                PictureBox pictureBox = (PictureBox)sender;
                if (pictureBox.Bounds.IntersectsWith(sellPic.Bounds))
                {
                    CarsManager.RemoveCar(7);
                    refreshCars();
                }
                pictureBox.Location = originalLocation7;
                isDragging7 = false;
            }
        }

        private string GetCarInfoByPictureBox(PictureBox pictureBox)
        {
            if (pictureBox == parkingLot0 && parkingLot0 != null)
            {
                return cars[0].GetCarInfo();
            }
            else if (pictureBox == parkingLot1 && parkingLot1 != null)
            {
                return cars[1].GetCarInfo();
            }
            else if (pictureBox == parkingLot2 && parkingLot2 != null)
            {
                return cars[2].GetCarInfo();
            }
            else if (pictureBox == parkingLot3 && parkingLot3 != null)
            {
                return cars[3].GetCarInfo();
            }
            else if (pictureBox == parkingLot4 && parkingLot4 != null)
            {
                return cars[4].GetCarInfo();
            }
            else if (pictureBox == parkingLot5 && parkingLot5 != null)
            {
                return cars[5].GetCarInfo();
            }
            else if (pictureBox == parkingLot6 && parkingLot6 != null)
            {
                return cars[6].GetCarInfo();
            }
            else if (pictureBox == parkingLot7 && parkingLot7 != null)
            {
                return cars[7].GetCarInfo();
            }

            return string.Empty;
        }

        private void parkingLot0_MouseHover(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            string carInfo = CarsManager.GetCarInfo(0);

            ToolTip toolTip;
            if (pictureBoxTooltips.ContainsKey(pictureBox))
            {
                toolTip = pictureBoxTooltips[pictureBox];
                toolTip.SetToolTip(pictureBox, carInfo);
            }
            else
            {
                toolTip = new ToolTip();
                toolTip.AutoPopDelay = 5000;
                toolTip.InitialDelay = 500;
                toolTip.ReshowDelay = 500;
                toolTip.SetToolTip(pictureBox, carInfo);
                pictureBoxTooltips.Add(pictureBox, toolTip);
            }

            toolTip.Show(carInfo, pictureBox);
        }

        private void parkingLot1_MouseHover(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            string carInfo = CarsManager.GetCarInfo(1);

            ToolTip toolTip;
            if (pictureBoxTooltips.ContainsKey(pictureBox))
            {
                toolTip = pictureBoxTooltips[pictureBox];
                toolTip.SetToolTip(pictureBox, carInfo);
            }
            else
            {
                toolTip = new ToolTip();
                toolTip.AutoPopDelay = 5000;
                toolTip.InitialDelay = 500;
                toolTip.ReshowDelay = 500;
                toolTip.SetToolTip(pictureBox, carInfo);
                pictureBoxTooltips.Add(pictureBox, toolTip);
            }

            toolTip.Show(carInfo, pictureBox);
        }

        private void parkingLot2_MouseHover(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            string carInfo = CarsManager.GetCarInfo(2);

            ToolTip toolTip;
            if (pictureBoxTooltips.ContainsKey(pictureBox))
            {
                toolTip = pictureBoxTooltips[pictureBox];
                toolTip.SetToolTip(pictureBox, carInfo);
            }
            else
            {
                toolTip = new ToolTip();
                toolTip.AutoPopDelay = 5000;
                toolTip.InitialDelay = 500;
                toolTip.ReshowDelay = 500;
                toolTip.SetToolTip(pictureBox, carInfo);
                pictureBoxTooltips.Add(pictureBox, toolTip);
            }

            toolTip.Show(carInfo, pictureBox);
        }

        private void parkingLot3_MouseHover(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            string carInfo = CarsManager.GetCarInfo(3);

            ToolTip toolTip;
            if (pictureBoxTooltips.ContainsKey(pictureBox))
            {
                toolTip = pictureBoxTooltips[pictureBox];
                toolTip.SetToolTip(pictureBox, carInfo);
            }
            else
            {
                toolTip = new ToolTip();
                toolTip.AutoPopDelay = 5000;
                toolTip.InitialDelay = 500;
                toolTip.ReshowDelay = 500;
                toolTip.SetToolTip(pictureBox, carInfo);
                pictureBoxTooltips.Add(pictureBox, toolTip);
            }

            toolTip.Show(carInfo, pictureBox);
        }

        private void parkingLot4_MouseHover(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            string carInfo = CarsManager.GetCarInfo(4);

            ToolTip toolTip;
            if (pictureBoxTooltips.ContainsKey(pictureBox))
            {
                toolTip = pictureBoxTooltips[pictureBox];
                toolTip.SetToolTip(pictureBox, carInfo);
            }
            else
            {
                toolTip = new ToolTip();
                toolTip.AutoPopDelay = 5000;
                toolTip.InitialDelay = 500;
                toolTip.ReshowDelay = 500;
                toolTip.SetToolTip(pictureBox, carInfo);
                pictureBoxTooltips.Add(pictureBox, toolTip);
            }

            toolTip.Show(carInfo, pictureBox);
        }

        private void parkingLot5_MouseHover(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            string carInfo = CarsManager.GetCarInfo(5);

            ToolTip toolTip;
            if (pictureBoxTooltips.ContainsKey(pictureBox))
            {
                toolTip = pictureBoxTooltips[pictureBox];
                toolTip.SetToolTip(pictureBox, carInfo);
            }
            else
            {
                toolTip = new ToolTip();
                toolTip.AutoPopDelay = 5000;
                toolTip.InitialDelay = 500;
                toolTip.ReshowDelay = 500;
                toolTip.SetToolTip(pictureBox, carInfo);
                pictureBoxTooltips.Add(pictureBox, toolTip);
            }

            toolTip.Show(carInfo, pictureBox); ;
        }

        private void parkingLot6_MouseHover(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            string carInfo = CarsManager.GetCarInfo(6);

            ToolTip toolTip;
            if (pictureBoxTooltips.ContainsKey(pictureBox))
            {
                toolTip = pictureBoxTooltips[pictureBox];
                toolTip.SetToolTip(pictureBox, carInfo);
            }
            else
            {
                toolTip = new ToolTip();
                toolTip.AutoPopDelay = 5000;
                toolTip.InitialDelay = 500;
                toolTip.ReshowDelay = 500;
                toolTip.SetToolTip(pictureBox, carInfo);
                pictureBoxTooltips.Add(pictureBox, toolTip);
            }

            toolTip.Show(carInfo, pictureBox);
        }

        private void parkingLot7_MouseHover(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            string carInfo = CarsManager.GetCarInfo(7);

            ToolTip toolTip;
            if (pictureBoxTooltips.ContainsKey(pictureBox))
            {
                toolTip = pictureBoxTooltips[pictureBox];
                toolTip.SetToolTip(pictureBox, carInfo);
            }
            else
            {
                toolTip = new ToolTip();
                toolTip.AutoPopDelay = 5000;
                toolTip.InitialDelay = 500;
                toolTip.ReshowDelay = 500;
                toolTip.SetToolTip(pictureBox, carInfo);
                pictureBoxTooltips.Add(pictureBox, toolTip);
            }

            toolTip.Show(carInfo, pictureBox);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            Size textSize = TextRenderer.MeasureText(toolTip1.GetToolTip(e.AssociatedControl), e.AssociatedControl.Font);
            int desiredHeight = textSize.Height + 20;

            e.ToolTipSize = new Size(e.ToolTipSize.Width, desiredHeight);
        }

        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            Font font = new Font("Arial", 10, FontStyle.Regular);
            Color textColor = Color.Black;
            string tooltipText = toolTip1.GetToolTip(e.AssociatedControl);
            TextRenderer.DrawText(e.Graphics, tooltipText, font, e.Bounds, textColor);
        }
    }


}
