using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarBusinessSkeleton
{
    public partial class VehiclesForm : Form
    {
        protected List<Vehicles> vehiclesFormList = new List<Vehicles>();
        protected int locationNumber;

        public VehiclesForm(List<Vehicles> vehiclesList, int pLocationNumber)
        {
            InitializeComponent();
            locationNumber = pLocationNumber;
            //adds the vehicle list to the protected list that can be used throughout this form
            for(int i = 0; i < vehiclesList.Count;i++)
            {
                vehiclesFormList.Add(vehiclesList[i]);
            }
            //displays the chosen vehicle list
            displayVehicleList();
        }


        public void displayVehicleList()
        {
            //clears the list box and adds each vehicle form the list
            vehiclesListBox.Items.Clear();
            for(int i = 0; i < vehiclesFormList.Count;i++)
            {
                vehiclesListBox.Items.Add(vehiclesFormList[i]);
            }

        }


        private void add_Click(object sender, EventArgs e)
        {
            //opens the vehicle form to add a vehicle
            Form myform = new VehicleForm(vehiclesFormList,locationNumber);
            myform.Show();
            this.Close();
        }


        private void modify_Click(object sender, EventArgs e)
        {
            //opens and sends the new vehicles form the list of vehicles and the selected vehicel so the information can be there to modify
            Form myform = new VehicleForm(vehiclesFormList, vehiclesListBox.SelectedIndex, locationNumber);
            myform.Show();
            this.Close();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            //removes the selected vehicle 
            try
            {
                List<Vehicles> tempVehicleList = new List<Vehicles>();
                for (int i = 0; i < vehiclesFormList.Count; i++)
                {
                    if (vehiclesListBox.SelectedIndex != i)
                    {
                        tempVehicleList.Add(vehiclesFormList[i]);
                    }
                }
                vehiclesFormList.Clear();
                for (int i = 0; i < tempVehicleList.Count; i++)
                {
                    vehiclesFormList.Add(tempVehicleList[i]);
                }

                vehiclesListBox.Items.Clear();
                displayVehicleList();
            }
            catch(Exception)
            {
                MessageBox.Show("An error occured while removing that Vehicle");
            }
        }

        private void vehicleRestorationButton_Click(object sender, EventArgs e)
        {
            //restores the vehicle based on the type
            try
            {
                List<Vehicles> tempVehicleList = new List<Vehicles>();

                for (int i = 0; i < vehiclesFormList.Count; i++)
                {
                    if (i != vehiclesListBox.SelectedIndex)
                    {
                        tempVehicleList.Add(vehiclesFormList[i]);
                    }
                }

                if (vehiclesListBox.SelectedItem.ToString().Split(',')[0].ToLower() == "car")
                {
                    Car a = (Car)vehiclesListBox.SelectedItem;
                    a.vehicleRestoration();
                    tempVehicleList.Add(a);
                }
                else if (vehiclesListBox.SelectedItem.ToString().Split(',')[0].ToLower() == "truck")
                {
                    Truck a = (Truck)vehiclesListBox.SelectedItem;
                    a.vehicleRestoration();
                    tempVehicleList.Add(a);
                }
                else if (vehiclesListBox.SelectedItem.ToString().Split(',')[0].ToLower() == "helicopter")
                {
                    Helicopter a = (Helicopter)vehiclesListBox.SelectedItem;
                    a.vehicleRestoration();
                    tempVehicleList.Add(a);
                }
                else if (vehiclesListBox.SelectedItem.ToString().Split(',')[0].ToLower() == "plane")
                {
                    Helicopter a = (Helicopter)vehiclesListBox.SelectedItem;
                    a.vehicleRestoration();
                    tempVehicleList.Add(a);
                }

                vehiclesFormList.Clear();
                for (int i = 0; i < tempVehicleList.Count; i++)
                {
                    vehiclesFormList.Add(tempVehicleList[i]);
                }

                displayVehicleList();
            }
            catch(Exception)
            {
                MessageBox.Show("An Error occured while restoring that vehicle");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //goes back to the previous form
            try
            {
                Form myForm = new Locations(vehiclesFormList, locationNumber);
                myForm.Show();
                this.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("An error occured while going back");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //sends the data back to the location form so it can be saved
            Form myForm = new Locations(vehiclesFormList, locationNumber, 1);
        }
    }
}
