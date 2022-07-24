using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarBusinessSkeleton
{
    public partial class Locations : Form
    {
        // creates 4 lists for the 4 locations and a string array for the location names
        protected List<Vehicles> location1 = new List<Vehicles>();
        protected List<Vehicles> location2 = new List<Vehicles>();
        protected List<Vehicles> location3 = new List<Vehicles>();
        protected List<Vehicles> location4 = new List<Vehicles>();
        protected string[] locations = new string[4];


        public Locations()
        {        
            InitializeComponent();

            readInData();
            
            // adds the location names to the loistbox to be displayed on the form
            for(int i = 0; i < locations.Length;i++)
            {
                locationsList.Items.Add(locations[i]);
            }
            
        }

        //the return mehtod that is used when the back button is clicked in the vehicles form
        public Locations(List<Vehicles> tempVehicleList, int pLocationNumber)
        {
            InitializeComponent();
            //reads in the location information from the files
            readInData();
            // and then updates the changed location list 
            readInData(tempVehicleList, pLocationNumber);

            //displays the location names
            for (int i = 0; i < locations.Length; i++)
            {
                locationsList.Items.Add(locations[i]);
            }
        }

        // the method called when the svae button is clicked in the vehicles list
        public Locations(List<Vehicles> vehicleList, int pLocationNumber, int a)
        {
            try
            {
                //reads in the data and updates the changed list
                readInData();
                readInData(vehicleList, pLocationNumber);

                //saves the changes
                saveData();
            }
            catch(Exception)
            {
                MessageBox.Show("An error occured while saving the Vehicles Form");
            }
        }    

        //recreates each loation file with the whatever changes were made 
        public void saveData()
        {
            
            StreamWriter sw = new StreamWriter("Location1.csv");
            sw.WriteLine(locations[0]);
            for (int i = 0; i < location1.Count; i++)
            {
                sw.WriteLine(location1[i].ToString());
            }
            sw.Flush();
            sw.Close();


            sw = new StreamWriter("Location2.csv");
            sw.WriteLine(locations[1]);
            for (int i = 0; i < location2.Count; i++)
            {
                sw.WriteLine(location2[i].ToString());
            }
            sw.Flush();
            sw.Close();


            sw = new StreamWriter("Location3.csv");
            sw.WriteLine(locations[2]);
            for (int i = 0; i < location3.Count; i++)
            {
                sw.WriteLine(location3[i].ToString());
            }
            sw.Flush();
            sw.Close();


            sw = new StreamWriter("Location4.csv");
            sw.WriteLine(locations[3]);
            for (int i = 0; i < location4.Count; i++)
            {
                sw.WriteLine(location4[i].ToString());
            }
            sw.Flush();
            sw.Close();

            
            MessageBox.Show("Save Completed");
        }

        //method called when the search button is clicked in the customer form
        public Locations(List<Vehicles> pCustomerVehicleList)
        {
            InitializeComponent();
            // it send the list of the cutomers vehicles and reads in the location data to search through
            readInData();

            //place to store vehicle matches and their respective location names
            Dictionary<Vehicles, string> VehicleMatches = new Dictionary<Vehicles, string>();


            //searches location 1 using the specified requirements
            for(int i = 0; i < location1.Count;i++)
            {
                for(int j = 0; j < pCustomerVehicleList.Count;j++)
                {
                    if (location1[i].ToString().Split(',')[0].ToLower() == pCustomerVehicleList[j].ToString().Split(',')[0].ToLower())
                    {
                        if (location1[i].ToString().Split(',')[1].ToLower() == pCustomerVehicleList[j].ToString().Split(',')[1].ToLower())
                        {
                            if (location1[i].ToString().Split(',')[2].ToLower() == pCustomerVehicleList[j].ToString().Split(',')[2].ToLower())
                            {
                                if(int.Parse(location1[i].ToString().Split(',')[3]) >= int.Parse(pCustomerVehicleList[j].ToString().Split(',')[3]))
                                {
                                    if (decimal.Parse(location1[i].ToString().Split(',')[4]) < decimal.Parse(pCustomerVehicleList[j].ToString().Split(',')[4]))
                                    {
                                        VehicleMatches.Add(location1[i], locations[0]);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //searches location 2 using the specified requirements
            for (int i = 0; i < location2.Count; i++)
            {
                for (int j = 0; j < pCustomerVehicleList.Count; j++)
                {
                    if (location2[i].ToString().Split(',')[0].ToLower() == pCustomerVehicleList[j].ToString().Split(',')[0].ToLower())
                    {
                        if (location2[i].ToString().Split(',')[1].ToLower() == pCustomerVehicleList[j].ToString().Split(',')[1].ToLower())
                        {
                            if (location2[i].ToString().Split(',')[2].ToLower() == pCustomerVehicleList[j].ToString().Split(',')[2].ToLower())
                            {
                                if (int.Parse(location2[i].ToString().Split(',')[3]) >= int.Parse(pCustomerVehicleList[j].ToString().Split(',')[3]))
                                {
                                    if (decimal.Parse(location2[i].ToString().Split(',')[4]) < decimal.Parse(pCustomerVehicleList[j].ToString().Split(',')[4]))
                                    {
                                        VehicleMatches.Add(location2[i], locations[1]);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //searches location 3 using the specified requirements
            for (int i = 0; i < location3.Count; i++)
            {
                for (int j = 0; j < pCustomerVehicleList.Count; j++)
                {
                    if (location3[i].ToString().Split(',')[0].ToLower() == pCustomerVehicleList[j].ToString().Split(',')[0].ToLower())
                    {
                        if (location3[i].ToString().Split(',')[1].ToLower() == pCustomerVehicleList[j].ToString().Split(',')[1].ToLower())
                        {
                            if (location3[i].ToString().Split(',')[2].ToLower() == pCustomerVehicleList[j].ToString().Split(',')[2].ToLower())
                            {
                                if (int.Parse(location3[i].ToString().Split(',')[3]) >= int.Parse(pCustomerVehicleList[j].ToString().Split(',')[3]))
                                {
                                    if (decimal.Parse(location3[i].ToString().Split(',')[4]) < decimal.Parse(pCustomerVehicleList[j].ToString().Split(',')[4]))
                                    {
                                        VehicleMatches.Add(location3[i], locations[2]);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //searches location 4 using the specified requirements
            for (int i = 0; i < location4.Count; i++)
            {
                for (int j = 0; j < pCustomerVehicleList.Count; j++)
                {
                    if (location4[i].ToString().Split(',')[0].ToLower() == pCustomerVehicleList[j].ToString().Split(',')[0].ToLower())
                    {
                        if (location4[i].ToString().Split(',')[1].ToLower() == pCustomerVehicleList[j].ToString().Split(',')[1].ToLower())
                        {
                            if (location4[i].ToString().Split(',')[2].ToLower() == pCustomerVehicleList[j].ToString().Split(',')[2].ToLower())
                            {
                                if (int.Parse(location4[i].ToString().Split(',')[3]) >= int.Parse(pCustomerVehicleList[j].ToString().Split(',')[3]))
                                {
                                    if (decimal.Parse(location4[i].ToString().Split(',')[4]) < decimal.Parse(pCustomerVehicleList[j].ToString().Split(',')[4]))
                                    {
                                        VehicleMatches.Add(location4[i], locations[3]);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //sends the vehicle matches back to the customer form
            Form myForm = new Customers(VehicleMatches, 1);

        }

        public void readInData(List<Vehicles> tempVehicleList, int pLocationNumber)
        {
            //clears the chosen location data
            if (pLocationNumber == 1)
            {
                location1.Clear();
            }
            else if (pLocationNumber == 2)
            {
                location2.Clear();
            }
            else if (pLocationNumber == 3)
            {
                location3.Clear();
            }
            else if (pLocationNumber == 4)
            {
                location4.Clear();
            }

            //and then readds it with the changes made
            for (int i = 0; i < tempVehicleList.Count; i++)
            {
                if (pLocationNumber == 1)
                {
                    location1.Add(tempVehicleList[i]);
                }
                else if (pLocationNumber == 2)
                {
                    location2.Add(tempVehicleList[i]);
                }
                else if (pLocationNumber == 3)
                {
                    location3.Add(tempVehicleList[i]);
                }
                else if (pLocationNumber == 4)
                {
                    location4.Add(tempVehicleList[i]);
                }
            }

        }

        //displays the information about the location
        public void locationData()
        {
            //sum of the toatl value
            decimal totalValue = 0;
            //highest total to be added
            decimal mostExpensiveVehicle = 0;
            //the type of the vehicle when the highest total is added
            string mostExpensiveVehicleType = "";

            //location 1 data
            if (locationsList.SelectedIndex == 0)
            {
                vehiclesInStockLabel.Text = location1.Count().ToString();
                for (int i = 0; i < location1.Count;i++)
                {
                    totalValue += decimal.Parse(location1[i].ToString().Split(',')[4]);

                    if (decimal.Parse(location1[i].ToString().Split(',')[4]) > mostExpensiveVehicle)
                    {
                        mostExpensiveVehicle = decimal.Parse(location1[i].ToString().Split(',')[4]);
                        mostExpensiveVehicleType = location1[i].ToString().Split(',')[0];
                    }
                }

                totalValueLabel.Text = "£" + totalValue.ToString();
                mostExpensiveLabel.Text = "£" + mostExpensiveVehicle.ToString();
                mostExpensiveTypeLabel.Text = mostExpensiveVehicleType;

                totalValue = 0;
                mostExpensiveVehicle = 0;
            }
            //location 2 data
            else if (locationsList.SelectedIndex == 1)
            {
                vehiclesInStockLabel.Text = location2.Count().ToString();
                for (int i = 0; i < location2.Count; i++)
                {
                    totalValue += decimal.Parse(location2[i].ToString().Split(',')[4]);

                    if (decimal.Parse(location2[i].ToString().Split(',')[4]) > mostExpensiveVehicle)
                    {
                        mostExpensiveVehicle = decimal.Parse(location2[i].ToString().Split(',')[4]);
                        mostExpensiveVehicleType = location2[i].ToString().Split(',')[0];
                    }                                       
                }

                totalValueLabel.Text = "£" + totalValue.ToString();
                mostExpensiveLabel.Text = "£" + mostExpensiveVehicle.ToString();
                mostExpensiveTypeLabel.Text = mostExpensiveVehicleType;

                totalValue = 0;
                mostExpensiveVehicle = 0;
            }
            //location 3 data
            else if (locationsList.SelectedIndex == 2)
            {
                vehiclesInStockLabel.Text = location3.Count().ToString();
                for (int i = 0; i < location3.Count; i++)
                {
                    totalValue += decimal.Parse(location3[i].ToString().Split(',')[4]);

                    if (decimal.Parse(location3[i].ToString().Split(',')[4]) > mostExpensiveVehicle)
                    {
                        mostExpensiveVehicle = decimal.Parse(location3[i].ToString().Split(',')[4]);
                        mostExpensiveVehicleType = location3[i].ToString().Split(',')[0];
                    }
                }

                totalValueLabel.Text = "£" + totalValue.ToString();
                mostExpensiveLabel.Text = "£" + mostExpensiveVehicle.ToString();
                mostExpensiveTypeLabel.Text = mostExpensiveVehicleType;

                totalValue = 0;
                mostExpensiveVehicle = 0;
            }
            //location 4 data
            else if (locationsList.SelectedIndex == 3)
            {
                vehiclesInStockLabel.Text = location4.Count().ToString();
                for (int i = 0; i < location4.Count; i++)
                {
                    totalValue += decimal.Parse(location4[i].ToString().Split(',')[4]);

                    if (decimal.Parse(location4[i].ToString().Split(',')[4]) > mostExpensiveVehicle)
                    {
                        mostExpensiveVehicle = decimal.Parse(location4[i].ToString().Split(',')[4]);
                        mostExpensiveVehicleType = location4[i].ToString().Split(',')[0];
                    }
                }

                totalValueLabel.Text = "£" + totalValue.ToString();
                mostExpensiveLabel.Text = "£" + mostExpensiveVehicle.ToString();
                mostExpensiveTypeLabel.Text = mostExpensiveVehicleType;

                totalValue = 0;
                mostExpensiveVehicle = 0;
            }
        }

        public void readInData()
        {
            //loads the location files into lists
            string[] Location1 = new string[1];
            try
            {
                Location1 = File.ReadAllLines("Location1.CSV");
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show("Location1.CSV File Not Found");
                Application.Exit();
            }
            catch (DirectoryNotFoundException e)
            {
                MessageBox.Show("The File Directory was Not Found");
                Application.Exit();
            }
            catch(Exception e)
            {
                MessageBox.Show("There was an error when opening the Location1 File");
                Application.Exit();
            }

            string[] Location2 = new string[1];
            try
            {
                Location2 = File.ReadAllLines("Location2.CSV");
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show("Location2.CSV File Not Found");
                Application.Exit();
            }
            catch (DirectoryNotFoundException e)
            {
                MessageBox.Show("The File Directory was Not Found");
                Application.Exit();
            }
            catch (Exception e)
            {
                MessageBox.Show("There was an error when opening the Location2 File");
                Application.Exit();
            }

            string[] Location3 = new string[1];
            try
            {
                Location3 = File.ReadAllLines("Location3.CSV");
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show("Location3.CSV File Not Found");
                Application.Exit();
            }
            catch (DirectoryNotFoundException e)
            {
                MessageBox.Show("The File Directory was Not Found");
                Application.Exit();
            }
            catch (Exception e)
            {
                MessageBox.Show("There was an error when opening the Location3 File");
                Application.Exit();
            }

            string[] Location4 = new string[1];
            try
            {
                Location4 = File.ReadAllLines("Location4.CSV");
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show("Location4.CSV File Not Found");
                Application.Exit();
            }
            catch (DirectoryNotFoundException e)
            {
                MessageBox.Show("The File Directory was Not Found");
                Application.Exit();
            }
            catch (Exception e)
            {
                MessageBox.Show("There was an error when opening the Location4 File");
                Application.Exit();
            }
            

            //for each location the line is split accordign to the comma and the object is created and added to the list
            for (int i = 0; i < Location1.Length; i++)
            {
                //the first item in the location is the location name so that is added to the string array
                if (i == 0)
                {
                    locations[0] = Location1[i];
                }
                else
                {

                    string[] vehicle = Location1[i].Split(',');
                    if (vehicle[0].ToLower() == "car")
                    {
                        location1.Add(new Car(vehicle[1], vehicle[2], int.Parse(vehicle[3]), decimal.Parse(vehicle[4]), int.Parse(vehicle[5]), vehicle[6], vehicle[7], int.Parse(vehicle[8]), decimal.Parse(vehicle[9]), bool.Parse(vehicle[10])));
                    }
                    else if (vehicle[0].ToLower() == "truck")
                    {
                        location1.Add(new Truck(vehicle[1], vehicle[2], int.Parse(vehicle[3]), decimal.Parse(vehicle[4]), int.Parse(vehicle[5]), vehicle[6], vehicle[7], int.Parse(vehicle[8]), int.Parse(vehicle[9]), int.Parse(vehicle[10])));
                    }
                    else if (vehicle[0].ToLower() == "helicopter")
                    {
                        location1.Add(new Helicopter(vehicle[1], vehicle[2], int.Parse(vehicle[3]), decimal.Parse(vehicle[4]), int.Parse(vehicle[5]), vehicle[6], vehicle[7], bool.Parse(vehicle[8]), int.Parse(vehicle[9]), int.Parse(vehicle[10])));
                    }
                    else if (vehicle[0].ToLower() == "plane")
                    {
                        location1.Add(new Plane(vehicle[1], vehicle[2], int.Parse(vehicle[3]), decimal.Parse(vehicle[4]), int.Parse(vehicle[5]), vehicle[6], vehicle[7], bool.Parse(vehicle[8]), int.Parse(vehicle[9]), int.Parse(vehicle[10]), int.Parse(vehicle[11]), vehicle[12]));
                    }

                }
            }

            //repeated for each location
            for (int i = 0; i < Location2.Length; i++)
            {
                if (i == 0)
                {
                    locations[1] = Location2[i];
                }
                else
                {

                    string[] vehicle = Location2[i].Split(',');
                    if (vehicle[0].ToLower() == "car")
                    {
                        location2.Add(new Car(vehicle[1], vehicle[2], int.Parse(vehicle[3]), decimal.Parse(vehicle[4]), int.Parse(vehicle[5]), vehicle[6], vehicle[7], int.Parse(vehicle[8]), decimal.Parse(vehicle[9]), bool.Parse(vehicle[10])));
                    }
                    else if (vehicle[0].ToLower() == "truck")
                    {
                        location2.Add(new Truck(vehicle[1], vehicle[2], int.Parse(vehicle[3]), decimal.Parse(vehicle[4]), int.Parse(vehicle[5]), vehicle[6], vehicle[7], int.Parse(vehicle[8]), int.Parse(vehicle[9]), int.Parse(vehicle[10])));
                    }
                    else if (vehicle[0].ToLower() == "helicopter")
                    {
                        location2.Add(new Helicopter(vehicle[1], vehicle[2], int.Parse(vehicle[3]), decimal.Parse(vehicle[4]), int.Parse(vehicle[5]), vehicle[6], vehicle[7], bool.Parse(vehicle[8]), int.Parse(vehicle[9]), int.Parse(vehicle[10])));
                    }
                    else if (vehicle[0].ToLower() == "plane")
                    {
                        location2.Add(new Plane(vehicle[1], vehicle[2], int.Parse(vehicle[3]), decimal.Parse(vehicle[4]), int.Parse(vehicle[5]), vehicle[6], vehicle[7], bool.Parse(vehicle[8]), int.Parse(vehicle[9]), int.Parse(vehicle[10]), int.Parse(vehicle[11]), vehicle[12]));
                    }

                }
            }

            for (int i = 0; i < Location3.Length; i++)
            {
                if (i == 0)
                {
                    locations[2] = Location3[i];
                }
                else
                {

                    string[] vehicle = Location3[i].Split(',');
                    if (vehicle[0].ToLower() == "car")
                    {
                        location3.Add(new Car(vehicle[1], vehicle[2], int.Parse(vehicle[3]), decimal.Parse(vehicle[4]), int.Parse(vehicle[5]), vehicle[6], vehicle[7], int.Parse(vehicle[8]), decimal.Parse(vehicle[9]), bool.Parse(vehicle[10])));
                    }
                    else if (vehicle[0].ToLower() == "truck")
                    {
                        location3.Add(new Truck(vehicle[1], vehicle[2], int.Parse(vehicle[3]), decimal.Parse(vehicle[4]), int.Parse(vehicle[5]), vehicle[6], vehicle[7], int.Parse(vehicle[8]), int.Parse(vehicle[9]), int.Parse(vehicle[10])));
                    }
                    else if (vehicle[0].ToLower() == "helicopter")
                    {
                        location3.Add(new Helicopter(vehicle[1], vehicle[2], int.Parse(vehicle[3]), decimal.Parse(vehicle[4]), int.Parse(vehicle[5]), vehicle[6], vehicle[7], bool.Parse(vehicle[8]), int.Parse(vehicle[9]), int.Parse(vehicle[10])));
                    }
                    else if (vehicle[0].ToLower() == "plane")
                    {
                        location3.Add(new Plane(vehicle[1], vehicle[2], int.Parse(vehicle[3]), decimal.Parse(vehicle[4]), int.Parse(vehicle[5]), vehicle[6], vehicle[7], bool.Parse(vehicle[8]), int.Parse(vehicle[9]), int.Parse(vehicle[10]), int.Parse(vehicle[11]), vehicle[12]));
                    }

                }
            }
            for (int i = 0; i < Location4.Length; i++)
            {
                if (i == 0)
                {
                    locations[3] = Location4[i];
                }
                else
                {

                    string[] vehicle = Location4[i].Split(',');
                    if (vehicle[0].ToLower() == "car")
                    {
                        location4.Add(new Car(vehicle[1], vehicle[2], int.Parse(vehicle[3]), decimal.Parse(vehicle[4]), int.Parse(vehicle[5]), vehicle[6], vehicle[7], int.Parse(vehicle[8]), decimal.Parse(vehicle[9]), bool.Parse(vehicle[10])));
                    }
                    else if (vehicle[0].ToLower() == "truck")
                    {
                        location4.Add(new Truck(vehicle[1], vehicle[2], int.Parse(vehicle[3]), decimal.Parse(vehicle[4]), int.Parse(vehicle[5]), vehicle[6], vehicle[7], int.Parse(vehicle[8]), int.Parse(vehicle[9]), int.Parse(vehicle[10])));
                    }
                    else if (vehicle[0].ToLower() == "helicopter")
                    {
                        location4.Add(new Helicopter(vehicle[1], vehicle[2], int.Parse(vehicle[3]), decimal.Parse(vehicle[4]), int.Parse(vehicle[5]), vehicle[6], vehicle[7], bool.Parse(vehicle[8]), int.Parse(vehicle[9]), int.Parse(vehicle[10])));
                    }
                    else if (vehicle[0].ToLower() == "plane")
                    {
                        location4.Add(new Plane(vehicle[1], vehicle[2], int.Parse(vehicle[3]), decimal.Parse(vehicle[4]), int.Parse(vehicle[5]), vehicle[6], vehicle[7], bool.Parse(vehicle[8]), int.Parse(vehicle[9]), int.Parse(vehicle[10]), int.Parse(vehicle[11]), vehicle[12]));
                    }

                }
            }
        }

        //takes the selected location and sends it to the vehicles form with the location number so it can be updated later
        private void selectLocation_Click(object sender, EventArgs e)
        {
            try
            {
                if (locationsList.SelectedItem.ToString().ToUpper() == locations[0].ToUpper())
                {
                    Form myForm = new VehiclesForm(location1, 1);
                    myForm.Show();
                    this.Close();
                }

                if (locationsList.SelectedItem.ToString().ToUpper() == locations[1].ToUpper())
                {
                    Form myForm = new VehiclesForm(location2, 2);
                    myForm.Show();
                    this.Close();
                }

                if (locationsList.SelectedItem.ToString().ToUpper() == locations[2].ToUpper())
                {
                    Form myForm = new VehiclesForm(location3, 3);
                    myForm.Show();
                    this.Close();
                }

                if (locationsList.SelectedItem.ToString().ToUpper() == locations[3].ToUpper())
                {
                    Form myForm = new VehiclesForm(location4, 4);
                    myForm.Show();
                    this.Close();
                }

            
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("An item wasn't selcted");
            }
            catch(Exception)
            {
                MessageBox.Show("An error occured while selecting a location");
            }

        }

        //everytime the selected index chages the new location data is called
        private void locationsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            locationData();

        }

        //saves the location data 
        private void saveButton_Click(object sender, EventArgs e)
        {


                try
                {
                    saveData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error While Saving");
             
                }

        }        
    }
}
