using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CarBusinessSkeleton
{
    public partial class Customers : Form
    {
        //dictionary of the vehicle and the customers name to keep track of whose vehicle is on whos wishlist
        protected Dictionary<Vehicles, string> customerInformation = new Dictionary<Vehicles, string>();
        //list of customer names, can be used to look at how many customers there are in total
        protected List<string> listOfCustomers = new List<string>();

        public Customers(Dictionary<Vehicles, string> pCustomerDictionary)
        {
            InitializeComponent();
            //loads in the changes made to the protected dictionary after clearing its contents
            customerInformation.Clear();
            foreach(KeyValuePair<Vehicles, string> v in pCustomerDictionary)
            {
                customerInformation.Add(v.Key, v.Value);
            }
            //displays the customers names
            displayCustomers();
        }



        public Customers()
        {
            InitializeComponent();
            //reads in customer data from the customer file
            readInData();
            //displayst the customers names
            displayCustomers();
        }



        private void readInData()
        {
            try
            {
                int customerIndex = 0;
                int vehicleCount = 0;
                string currentCustomer = "";
                string[] customerData = File.ReadAllLines("Customer.csv");
                //adds a blank string onto the end of the array is one isnt already present
                if (customerData[customerData.Length - 1] != "")
                {
                    string[] newCustomerData = new string[customerData.Length + 1];

                    for (int i = 0; i < customerData.Length; i++)
                    {
                        newCustomerData[i] = customerData[i];
                    }
                    newCustomerData[newCustomerData.Length - 1] = "";

                    for (int i = 1; i < newCustomerData.Length; i++)
                    {
                        //sets customer name
                        currentCustomer = newCustomerData[customerIndex];
                        
                        if ((newCustomerData[i].Split(',')[0].ToLower() == "car") || (newCustomerData[i].Split(',')[0].ToLower() == "truck") || (newCustomerData[i].Split(',')[0].ToLower() == "helicopter") || (newCustomerData[i].Split(',')[0].ToLower() == "plane"))
                        {

                            //counts the number of vehicles between current customer and next
                            vehicleCount++;
                        }
                        else
                        {
                            //loops over the current customers vehicles and creates the vehicle and adds them to the dictionary
                            for (int j = customerIndex + 1; j < (vehicleCount + customerIndex + 1); j++)
                            {
                                string[] vehicle = newCustomerData[j].Split(',');
                                if (vehicle[0].ToLower() == "car")
                                {
                                    customerInformation.Add(new Car(vehicle[1], vehicle[2], int.Parse(vehicle[3]), decimal.Parse(vehicle[4]), int.Parse(vehicle[5]), vehicle[6], vehicle[7], int.Parse(vehicle[8]), decimal.Parse(vehicle[9]), bool.Parse(vehicle[10])), currentCustomer);
                                }
                                else if (vehicle[0].ToLower() == "truck")
                                {
                                    customerInformation.Add(new Truck(vehicle[1], vehicle[2], int.Parse(vehicle[3]), decimal.Parse(vehicle[4]), int.Parse(vehicle[5]), vehicle[6], vehicle[7], int.Parse(vehicle[8]), int.Parse(vehicle[9]), int.Parse(vehicle[10])), currentCustomer);
                                }
                                else if (vehicle[0].ToLower() == "helicopter")
                                {
                                    customerInformation.Add(new Helicopter(vehicle[1], vehicle[2], int.Parse(vehicle[3]), decimal.Parse(vehicle[4]), int.Parse(vehicle[5]), vehicle[6], vehicle[7], bool.Parse(vehicle[8]), int.Parse(vehicle[9]), int.Parse(vehicle[10])), currentCustomer);
                                }
                                else if (vehicle[0].ToLower() == "plane")
                                {
                                    customerInformation.Add(new Plane(vehicle[1], vehicle[2], int.Parse(vehicle[3]), decimal.Parse(vehicle[4]), int.Parse(vehicle[5]), vehicle[6], vehicle[7], bool.Parse(vehicle[8]), int.Parse(vehicle[9]), int.Parse(vehicle[10]), int.Parse(vehicle[11]), vehicle[12]), currentCustomer);
                                }
                            }
                            //sets next customer index and resets the vehicle count
                            customerIndex += vehicleCount + 1;
                            vehicleCount = 0;
                        }
                    }

                }
                else
                {
                    for (int i = 1; i < customerData.Length; i++)
                    {
                        currentCustomer = customerData[customerIndex];
                        if ((customerData[i].Split(',')[0].ToLower() == "car") || (customerData[i].Split(',')[0].ToLower() == "truck") || (customerData[i].Split(',')[0].ToLower() == "helicopter") || (customerData[i].Split(',')[0].ToLower() == "plane"))
                        {
                            vehicleCount++;
                        }
                        else
                        {
                            for (int j = customerIndex + 1; j < (vehicleCount + customerIndex + 1); j++)
                            {
                                string[] vehicle = customerData[j].Split(',');
                                if (vehicle[0].ToLower() == "car")
                                {
                                    customerInformation.Add(new Car(vehicle[1], vehicle[2], int.Parse(vehicle[3]), decimal.Parse(vehicle[4]), int.Parse(vehicle[5]), vehicle[6], vehicle[7], int.Parse(vehicle[8]), decimal.Parse(vehicle[9]), bool.Parse(vehicle[10])), currentCustomer);
                                }
                                else if (vehicle[0].ToLower() == "truck")
                                {
                                    customerInformation.Add(new Truck(vehicle[1], vehicle[2], int.Parse(vehicle[3]), decimal.Parse(vehicle[4]), int.Parse(vehicle[5]), vehicle[6], vehicle[7], int.Parse(vehicle[8]), int.Parse(vehicle[9]), int.Parse(vehicle[10])), currentCustomer);
                                }
                                else if (vehicle[0].ToLower() == "helicopter")
                                {
                                    customerInformation.Add(new Helicopter(vehicle[1], vehicle[2], int.Parse(vehicle[3]), decimal.Parse(vehicle[4]), int.Parse(vehicle[5]), vehicle[6], vehicle[7], bool.Parse(vehicle[8]), int.Parse(vehicle[9]), int.Parse(vehicle[10])), currentCustomer);
                                }
                                else if (vehicle[0].ToLower() == "plane")
                                {
                                    customerInformation.Add(new Plane(vehicle[1], vehicle[2], int.Parse(vehicle[3]), decimal.Parse(vehicle[4]), int.Parse(vehicle[5]), vehicle[6], vehicle[7], bool.Parse(vehicle[8]), int.Parse(vehicle[9]), int.Parse(vehicle[10]), int.Parse(vehicle[11]), vehicle[12]), currentCustomer);
                                }
                            }

                            customerIndex += vehicleCount + 1;
                            vehicleCount = 0;
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("The Customer.CSV file could not be found");
                Application.Exit();
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("The directory was not found");
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured while reading in the Customer.CSV File");
            }
        }



        private void displayCustomers()
        {

            int counter = 0;
            string currentCustomer = "";
            string previousCustomer = "";
            //loops over dictionary and loads each different customer name into a customer list
            foreach(KeyValuePair<Vehicles,string > v in customerInformation)
            {
                bool alreadyExists = true;
                previousCustomer = currentCustomer;
                currentCustomer = v.Value;
                if (counter == 0)
                {
                    listOfCustomers.Add(currentCustomer);
                    counter++;
                }
                for (int i = 0; i < listOfCustomers.Count(); i++)
                { 

                    if(currentCustomer.ToLower() == listOfCustomers[i].ToLower())
                    {
                        alreadyExists = false;
                        break;
                    }
                }

                if(alreadyExists == true)
                {
                    listOfCustomers.Add(currentCustomer);
                }
            }

            //displays the customer list in the list box
            for(int i = 0; i < listOfCustomers.Count;i++)
            {
                customerListBox1.Items.Add(listOfCustomers[i]);
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //opens new vehicle form to add the new vehicle
            try
            {
                Form myform = new CustomerVehicleForm(customerInformation, customerListBox1.SelectedItem.ToString().ToLower());
                myform.Show();
                this.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("An error occured while opening the add vehicle form");
            }
        }
        protected string selectedCustomer;
        private void selectCustomerButton_Click(object sender, EventArgs e)
        {
        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }


        //list of vehicle matches
        Dictionary<Vehicles, string> SearchResults = new Dictionary<Vehicles, string>();

        //the constructor called by locations after the locations are searched against the wishlist
        public Customers(Dictionary<Vehicles,string> pSearchResults, int a)
        {
            
            InitializeComponent();
            foreach(KeyValuePair<Vehicles, string> v in pSearchResults)
            {
                SearchResults.Add(v.Key, v.Value);
            }
            int counter = 0;
            string displayMessage = "";
            foreach (KeyValuePair<Vehicles, string> v in SearchResults)
            {
                //list the vehicles found with the location name of where to find them 
                if(counter == 0)
                {
                    displayMessage += "Vehicle(s) Found: \n\r \n\r";
                    counter++;
                }
                displayMessage += (v.Key.ToString() + " in " + v.Value + "\n\r \n\r");
            }
            if(displayMessage == "")
            {
                //displays if nothing is found
                displayMessage = "No Matches Found";
            }
            MessageBox.Show(displayMessage);
        }

        private void searchVehicleButton_Click(object sender, EventArgs e)
        {
            //sends the selected customers list to the locations form to search for wishlist matches
            try
            {
                List<Vehicles> selectedCustomerVehicles = new List<Vehicles>();

                foreach (KeyValuePair<Vehicles, string> v in customerInformation)
                {

                    if (selectedCustomer.ToLower() == v.Value.ToLower())
                    {
                        selectedCustomerVehicles.Add(v.Key);
                    }
                }
                Form myForm = new Locations(selectedCustomerVehicles);

            }
            catch (Exception)
            {
                MessageBox.Show("An error occured while searching for vehicles");
            }
        }




        public void saveData()
        {
            //removes and creates a new customer form so it re adds all the modified information
            StreamWriter sw = new StreamWriter("Customer.csv");

            string currentCustomer = "";


            for (int i = 0; i < listOfCustomers.Count; i++)
            {
                currentCustomer = listOfCustomers[i];
                sw.WriteLine(currentCustomer);
                foreach (KeyValuePair<Vehicles, string> v in customerInformation)
                {
                    if (currentCustomer.ToLower() == v.Value.ToLower())
                    {
                        sw.WriteLine(v.Key.ToString());
                    }
                }


            }
            sw.Flush();
            sw.Close();
            MessageBox.Show("Save Completed");
        }


        private void customerListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void customerListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //displays thhe selected customers wishlist
            try
            {
                vehiclesListBox.Items.Clear();
                selectedCustomer = customerListBox1.SelectedItem.ToString();
                foreach (KeyValuePair<Vehicles, string> v in customerInformation)
                {

                    if (customerListBox1.SelectedItem.ToString().ToLower() == v.Value.ToLower())
                    {
                        vehiclesListBox.Items.Add(v.Key);
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("An item wasn't selected");
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured while selecting the customer");
            }
        }



        private void removeButton_Click_1(object sender, EventArgs e)
        {
            //removes the chosen vehicle from the wishlist
            try
            {
                Dictionary<Vehicles, string> tempDictionary = new Dictionary<Vehicles, string>();

                foreach (KeyValuePair<Vehicles, string> v in customerInformation)
                {
                    if (vehiclesListBox.SelectedItem.ToString().ToLower() != v.Key.ToString().ToLower())
                    {
                        tempDictionary.Add(v.Key, v.Value);
                    }
                }

                customerInformation.Clear();
                vehiclesListBox.Items.Clear();

                foreach (KeyValuePair<Vehicles, string> v in tempDictionary)
                {
                    customerInformation.Add(v.Key, v.Value);
                }

                foreach (KeyValuePair<Vehicles, string> v in customerInformation)
                {

                    if (customerListBox1.SelectedItem.ToString().ToLower() == v.Value.ToLower())
                    {
                        vehiclesListBox.Items.Add(v.Key);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured while removing that vehicle");
            }
        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            saveData();
        }
    }
}
