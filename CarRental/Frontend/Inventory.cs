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
    public partial class Inventory : Form
    {
        BindingList<Vehicle> carList = CarsManager.GetSpecificCars<Vehicle>();
        public Inventory()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = carList;

            DataGridViewTextBoxColumn carNumColumn = new DataGridViewTextBoxColumn();
            carNumColumn.DataPropertyName = "_carNum";
            carNumColumn.HeaderText = "Car Number";
            carNumColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            dataGridView1.Columns.Add(carNumColumn);

            DataGridViewTextBoxColumn companyColumn = new DataGridViewTextBoxColumn();
            companyColumn.DataPropertyName = "_company";
            companyColumn.HeaderText = "Company";
            companyColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            dataGridView1.Columns.Add(companyColumn);

            DataGridViewTextBoxColumn priceColumn = new DataGridViewTextBoxColumn();
            priceColumn.DataPropertyName = "_price";
            priceColumn.HeaderText = "Price";
            priceColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            dataGridView1.Columns.Add(priceColumn);

            DataGridViewTextBoxColumn fuelColumn = new DataGridViewTextBoxColumn();
            fuelColumn.DataPropertyName = "_fuel";
            fuelColumn.HeaderText = "Fuel type";
            fuelColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            dataGridView1.Columns.Add(fuelColumn);

            DataGridViewTextBoxColumn carTypeColumn = new DataGridViewTextBoxColumn();
            carTypeColumn.DataPropertyName = "_carType";
            carTypeColumn.HeaderText = "Car Type";
            carTypeColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            dataGridView1.Columns.Add(carTypeColumn);

            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.ColumnHeaderMouseClick += dataGridView1_ColumnHeaderMouseClick;

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                Vehicle car = (Vehicle)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                string carType = GetCarTypeName(car.type());
                e.Value = carType;
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;
            SortCars(columnName);
        }

        private void SortCars(string columnName)
        {
            ListSortDirection direction = ListSortDirection.Ascending;

            if (dataGridView1.Columns[columnName].HeaderCell.SortGlyphDirection == SortOrder.Ascending)
            {
                direction = ListSortDirection.Descending;
            }

            List<Vehicle> sortedList;
            switch (columnName)
            {
                case "_carNum":
                    sortedList = carList.OrderBy(v => v._carNum).ToList();
                    break;
                case "_company":
                    sortedList = carList.OrderBy(v => v._company).ToList();
                    break;
                case "_price":
                    sortedList = carList.OrderBy(v => v._price).ToList();
                    break;
                case "_fuel":
                    sortedList = carList.OrderBy(v => v._fuel).ToList();
                    break;
                default:
                    return;
            }

            if (direction == ListSortDirection.Descending)
            {
                sortedList.Reverse();
            }

            carList.Clear();
            foreach (Vehicle vehicle in sortedList)
            {
                carList.Add(vehicle);
            }

            dataGridView1.Columns[columnName].HeaderCell.SortGlyphDirection = direction == ListSortDirection.Ascending ? SortOrder.Ascending : SortOrder.Descending;
        }
        private string GetCarTypeName(int carType)
        {
            switch (carType)
            {
                case 1:
                    return "Family Car";
                case 2:
                    return "Sport Car";
                case 3:
                    return "Commercial Car";
                case 4:
                    return "Truck";
                default:
                    return "Unknown";
            }
        }

        private void dataGridView1_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Name == "_carType")
            {
                string carType1 = GetCarTypeName(Convert.ToInt32(e.CellValue1));
                string carType2 = GetCarTypeName(Convert.ToInt32(e.CellValue2));
                e.SortResult = String.Compare(carType1, carType2, StringComparison.Ordinal);
                e.Handled = true;
            }
        }
    }
}
