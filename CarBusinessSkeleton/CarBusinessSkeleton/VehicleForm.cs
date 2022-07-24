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
    public partial class VehicleForm : Form
    {
        protected List<Vehicles> vehicleList = new List<Vehicles>();
        protected int selectedLocation;

        //opened when the add button was clicked
        public VehicleForm(List<Vehicles> pTempVehicleList, int pSelectedLocation)
        {
            selectedLocation = pSelectedLocation;
            InitializeComponent();
            vehicleList.Clear();
            //loads vehicle list into a protected list
            for(int i = 0; i < pTempVehicleList.Count;i++)
            {
                vehicleList.Add(pTempVehicleList[i]);
            }
            
        }

        protected int selectedVehicleIndex;
        //opened when the modify button was clicked
        public VehicleForm(List<Vehicles> pTempVehicleList, int pSelctedVehicleIndex, int pSelectedLocation)
        {
            InitializeComponent();
            selectedLocation = pSelectedLocation;

            vehicleList.Clear();
            for (int i = 0; i < pTempVehicleList.Count; i++)
            {
                vehicleList.Add(pTempVehicleList[i]);
            }

            selectedVehicleIndex = pSelctedVehicleIndex;
            //displays the chosen vehicles information into the text boxes
            displayVehicle();
        }
        
        private void displayVehicle()
        {
            try
            {
                string[] chosenVehicle = vehicleList[selectedVehicleIndex].ToString().Split(',');
                //adds the chosen vehicle based on vehicle type 

                makeTextBox.Text = chosenVehicle[1];
                modelTextBox.Text = chosenVehicle[2];
                yearTextBox.Text = chosenVehicle[3].ToString();
                priceTextBox.Text = chosenVehicle[4].ToString();
                weightTextBox.Text = chosenVehicle[5].ToString();
                colourTextBox.Text = chosenVehicle[6];
                registrationTextBox.Text = chosenVehicle[7];

                if (chosenVehicle[0].ToLower() == "car")
                {
                    typeComboBox.Text = "Car";
                    numberOfDoorsTextBox.Text = chosenVehicle[8].ToString();
                    engineSizeTextBox.Text = chosenVehicle[9].ToString();
                    electricWindowsComboBox.Text = chosenVehicle[10].ToString();
                }
                else if (chosenVehicle[0].ToLower() == "truck")
                {
                    typeComboBox.Text = "Truck";
                    weightLimitTextBox.Text = chosenVehicle[8].ToString();
                    numberOfWheelsTextBox.Text = chosenVehicle[9].ToString();
                    lengthTextBox.Text = chosenVehicle[10].ToString();
                }
                else if (chosenVehicle[0].ToLower() == "helicopter")
                {
                    typeComboBox.Text = "Helicopter";
                    airworthyComboBox.Text = chosenVehicle[8].ToString();
                    hoursUsedTextBox.Text = chosenVehicle[9].ToString();
                    altitudeLimitTextBox.Text = chosenVehicle[10].ToString();
                }
                else if (chosenVehicle[0].ToLower() == "plane")
                {
                    typeComboBox.Text = "Plane";
                    airworthyComboBox.Text = chosenVehicle[8].ToString();
                    hoursUsedTextBox.Text = chosenVehicle[9].ToString();
                    altitudeLimitTextBox.Text = chosenVehicle[10].ToString();
                    seatsTextBox.Text = chosenVehicle[11].ToString();
                    enginesTextBox.Text = chosenVehicle[12].ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured while loading in the selected vehicle");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //takes the information from the text boxes and creates a new vehicle of that type and adds it to the list
            try
            {
                if (typeComboBox.Text.ToLower() == "car")
                {
                    Car newVehicle = new Car(makeTextBox.Text, modelTextBox.Text, int.Parse(yearTextBox.Text), decimal.Parse(priceTextBox.Text), decimal.Parse(weightTextBox.Text), colourTextBox.Text, registrationTextBox.Text, int.Parse(numberOfDoorsTextBox.Text), decimal.Parse(engineSizeTextBox.Text), bool.Parse(electricWindowsComboBox.Text));
                    vehicleList.Add(newVehicle);
                }
                else if (typeComboBox.Text.ToLower() == "truck")
                {
                    Truck newVehicle = new Truck(makeTextBox.Text, modelTextBox.Text, int.Parse(yearTextBox.Text), decimal.Parse(priceTextBox.Text), decimal.Parse(weightTextBox.Text), colourTextBox.Text, registrationTextBox.Text, int.Parse(weightLimitTextBox.Text), int.Parse(numberOfWheelsTextBox.Text), int.Parse(lengthTextBox.Text));
                    vehicleList.Add(newVehicle);
                }
                else if (typeComboBox.Text.ToLower() == "helicopter")
                {
                    Helicopter newVehicle = new Helicopter(makeTextBox.Text, modelTextBox.Text, int.Parse(yearTextBox.Text), decimal.Parse(priceTextBox.Text), decimal.Parse(weightTextBox.Text), colourTextBox.Text, registrationTextBox.Text, bool.Parse(airworthyComboBox.Text), int.Parse(hoursUsedTextBox.Text), int.Parse(altitudeLimitTextBox.Text));
                    vehicleList.Add(newVehicle);
                }
                else if (typeComboBox.Text.ToLower() == "plane")
                {
                    Plane newVehicle = new Plane(makeTextBox.Text, modelTextBox.Text, int.Parse(yearTextBox.Text), decimal.Parse(priceTextBox.Text), decimal.Parse(weightTextBox.Text), colourTextBox.Text, registrationTextBox.Text, bool.Parse(airworthyComboBox.Text), int.Parse(hoursUsedTextBox.Text), int.Parse(altitudeLimitTextBox.Text), int.Parse(seatsTextBox.Text), engineSizeTextBox.Text);
                    vehicleList.Add(newVehicle);
                }

                Form myForm = new VehiclesForm(vehicleList, selectedLocation);
                myForm.Show();
                this.Close();
            }
            catch(FormatException)
            {
                MessageBox.Show("Data was entered in the incorrect format");
            }
            catch(Exception)
            {
                MessageBox.Show("An error occured while adding the vehicle");
            }
        }


        private void modifyButton_Click(object sender, EventArgs e)
        {
            //removes the selected vehicle and creates the modified version in its place
            try
            { 
            List<Vehicles> tempVehicleList = new List<Vehicles>();
            for(int i = 0; i < vehicleList.Count;i++)
            {
                if(i != selectedVehicleIndex)
                {
                    tempVehicleList.Add(vehicleList[i]);
                }
            }

            if (typeComboBox.Text.ToLower() == "car")
            {
                Car newVehicle = new Car(makeTextBox.Text, modelTextBox.Text, int.Parse(yearTextBox.Text), decimal.Parse(priceTextBox.Text), decimal.Parse(weightTextBox.Text), colourTextBox.Text, registrationTextBox.Text, int.Parse(numberOfDoorsTextBox.Text), decimal.Parse(engineSizeTextBox.Text), bool.Parse(electricWindowsComboBox.Text));
                tempVehicleList.Add(newVehicle);
            }
            else if (typeComboBox.Text.ToLower() == "truck")
            {
                Truck newVehicle = new Truck(makeTextBox.Text, modelTextBox.Text, int.Parse(yearTextBox.Text), decimal.Parse(priceTextBox.Text), decimal.Parse(weightTextBox.Text), colourTextBox.Text, registrationTextBox.Text, int.Parse(weightLimitTextBox.Text), int.Parse(numberOfWheelsTextBox.Text), int.Parse(lengthTextBox.Text));
                tempVehicleList.Add(newVehicle);
            }
            else if (typeComboBox.Text.ToLower() == "helicopter")
            {
                Helicopter newVehicle = new Helicopter(makeTextBox.Text, modelTextBox.Text, int.Parse(yearTextBox.Text), decimal.Parse(priceTextBox.Text), decimal.Parse(weightTextBox.Text), colourTextBox.Text, registrationTextBox.Text, bool.Parse(airworthyComboBox.Text), int.Parse(hoursUsedTextBox.Text), int.Parse(altitudeLimitTextBox.Text));
                tempVehicleList.Add(newVehicle);
            }
            else if (typeComboBox.Text.ToLower() == "plane")
            {
                Plane newVehicle = new Plane(makeTextBox.Text, modelTextBox.Text, int.Parse(yearTextBox.Text), decimal.Parse(priceTextBox.Text), decimal.Parse(weightTextBox.Text), colourTextBox.Text, registrationTextBox.Text, bool.Parse(airworthyComboBox.Text), int.Parse(hoursUsedTextBox.Text), int.Parse(altitudeLimitTextBox.Text), int.Parse(seatsTextBox.Text), engineSizeTextBox.Text);
                tempVehicleList.Add(newVehicle);
            }

            Form myForm = new VehiclesForm(tempVehicleList, selectedLocation);
            myForm.Show();
            this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Data was entered in the incorrect format");
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured while adding the vehicle");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //opens the previous form and cancels the add/modify
            try
            {
                Form myForm = new VehiclesForm(vehicleList, selectedLocation);
                myForm.Show();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured while cancelling");
            }
        }
    }
}
