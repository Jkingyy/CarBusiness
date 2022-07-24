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

    public partial class CustomerVehicleForm : Form
    {
        //creates the dictionay for use in this form
        protected Dictionary<Vehicles, string> CustomerDictionary = new Dictionary<Vehicles, string>();
        protected string customerName;

        public CustomerVehicleForm(Dictionary<Vehicles,string> pTempDictionary, string pCustomerName)
        {
            customerName = pCustomerName;

            //moves all data over to the forms dictionary
            foreach(KeyValuePair<Vehicles,string> v in pTempDictionary)
            {
                CustomerDictionary.Add(v.Key, v.Value);
            }
            InitializeComponent();
        }

        private void addVehicleButton_Click(object sender, EventArgs e)
        {
            //creates the vechicle object based on the type entered on the form
            //it is then added to the dictionary
            try
            {
                if (typeComboBox.Text.ToLower() == "car")
                {
                    Car newVehicle = new Car(makeTextBox.Text, modelTextBox.Text, int.Parse(yearTextBox.Text), decimal.Parse(priceTextBox.Text), decimal.Parse(weightTextBox.Text), colourTextBox.Text, registrationTextBox.Text, int.Parse(numberOfDoorsTextBox.Text), decimal.Parse(engineSizeTextBox.Text), bool.Parse(electricWindowsComboBox.Text));
                    CustomerDictionary.Add(newVehicle,customerName);
                }
                else if (typeComboBox.Text.ToLower() == "truck")
                {
                    Truck newVehicle = new Truck(makeTextBox.Text, modelTextBox.Text, int.Parse(yearTextBox.Text), decimal.Parse(priceTextBox.Text), decimal.Parse(weightTextBox.Text), colourTextBox.Text, registrationTextBox.Text, int.Parse(weightLimitTextBox.Text), int.Parse(numberOfWheelsTextBox.Text), int.Parse(lengthTextBox.Text));
                    CustomerDictionary.Add(newVehicle, customerName);
                }
                else if (typeComboBox.Text.ToLower() == "helicopter")
                {
                    Helicopter newVehicle = new Helicopter(makeTextBox.Text, modelTextBox.Text, int.Parse(yearTextBox.Text), decimal.Parse(priceTextBox.Text), decimal.Parse(weightTextBox.Text), colourTextBox.Text, registrationTextBox.Text, bool.Parse(airworthyComboBox.Text), int.Parse(hoursUsedTextBox.Text), int.Parse(altitudeLimitTextBox.Text));
                    CustomerDictionary.Add(newVehicle, customerName);
                }
                else if (typeComboBox.Text.ToLower() == "plane")
                {
                    Plane newVehicle = new Plane(makeTextBox.Text, modelTextBox.Text, int.Parse(yearTextBox.Text), decimal.Parse(priceTextBox.Text), decimal.Parse(weightTextBox.Text), colourTextBox.Text, registrationTextBox.Text, bool.Parse(airworthyComboBox.Text), int.Parse(hoursUsedTextBox.Text), int.Parse(altitudeLimitTextBox.Text), int.Parse(seatsTextBox.Text), engineSizeTextBox.Text);
                    CustomerDictionary.Add(newVehicle, customerName);
                }
                //the dictionary is sent back to the customer form
                Form myForm = new Customers(CustomerDictionary);
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
            try
            {
                //dictionary is sent back to the customer form and the adding vehicle is cancelled
                Form myForm = new Customers(CustomerDictionary);
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
