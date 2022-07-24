namespace CarBusinessSkeleton
{
    partial class VehicleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Make = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Weight = new System.Windows.Forms.Label();
            this.Registration = new System.Windows.Forms.Label();
            this.Colour = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.registrationTextBox = new System.Windows.Forms.TextBox();
            this.colourTextBox = new System.Windows.Forms.TextBox();
            this.numberOfDoors = new System.Windows.Forms.Label();
            this.engineSize = new System.Windows.Forms.Label();
            this.electricWindows = new System.Windows.Forms.Label();
            this.numberOfDoorsTextBox = new System.Windows.Forms.TextBox();
            this.engineSizeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.weightLimitTextBox = new System.Windows.Forms.TextBox();
            this.seatsTextBox = new System.Windows.Forms.TextBox();
            this.enginesTextBox = new System.Windows.Forms.TextBox();
            this.hoursUsedTextBox = new System.Windows.Forms.TextBox();
            this.numberOfWheelsTextBox = new System.Windows.Forms.TextBox();
            this.altitudeLimitTextBox = new System.Windows.Forms.TextBox();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.airworthyComboBox = new System.Windows.Forms.ComboBox();
            this.addVehicleButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.electricWindowsComboBox = new System.Windows.Forms.ComboBox();
            this.carLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Make
            // 
            this.Make.AutoSize = true;
            this.Make.Location = new System.Drawing.Point(46, 66);
            this.Make.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Make.Name = "Make";
            this.Make.Size = new System.Drawing.Size(48, 20);
            this.Make.TabIndex = 0;
            this.Make.Text = "Make";
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Location = new System.Drawing.Point(46, 148);
            this.Model.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(52, 20);
            this.Model.TabIndex = 1;
            this.Model.Text = "Model";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(46, 237);
            this.Type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(43, 20);
            this.Type.TabIndex = 2;
            this.Type.Text = "Type";
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Car",
            "Truck",
            "Helicopter",
            "Plane"});
            this.typeComboBox.Location = new System.Drawing.Point(51, 262);
            this.typeComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(163, 28);
            this.typeComboBox.TabIndex = 3;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(52, 175);
            this.modelTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(160, 26);
            this.modelTextBox.TabIndex = 4;
            // 
            // makeTextBox
            // 
            this.makeTextBox.Location = new System.Drawing.Point(51, 91);
            this.makeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(160, 26);
            this.makeTextBox.TabIndex = 5;
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(321, 66);
            this.Year.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(43, 20);
            this.Year.TabIndex = 6;
            this.Year.Text = "Year";
            this.Year.Click += new System.EventHandler(this.label1_Click);
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(321, 148);
            this.Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(44, 20);
            this.Price.TabIndex = 7;
            this.Price.Text = "Price";
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Location = new System.Drawing.Point(321, 237);
            this.Weight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(59, 20);
            this.Weight.TabIndex = 8;
            this.Weight.Text = "Weight";
            // 
            // Registration
            // 
            this.Registration.AutoSize = true;
            this.Registration.Location = new System.Drawing.Point(321, 328);
            this.Registration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(95, 20);
            this.Registration.TabIndex = 9;
            this.Registration.Text = "Registration";
            // 
            // Colour
            // 
            this.Colour.AutoSize = true;
            this.Colour.Location = new System.Drawing.Point(47, 328);
            this.Colour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Colour.Name = "Colour";
            this.Colour.Size = new System.Drawing.Size(55, 20);
            this.Colour.TabIndex = 10;
            this.Colour.Text = "Colour";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(325, 91);
            this.yearTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(160, 26);
            this.yearTextBox.TabIndex = 11;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(325, 175);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(160, 26);
            this.priceTextBox.TabIndex = 12;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(325, 264);
            this.weightTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(160, 26);
            this.weightTextBox.TabIndex = 13;
            // 
            // registrationTextBox
            // 
            this.registrationTextBox.Location = new System.Drawing.Point(325, 353);
            this.registrationTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registrationTextBox.Name = "registrationTextBox";
            this.registrationTextBox.Size = new System.Drawing.Size(160, 26);
            this.registrationTextBox.TabIndex = 14;
            // 
            // colourTextBox
            // 
            this.colourTextBox.Location = new System.Drawing.Point(50, 353);
            this.colourTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.colourTextBox.Name = "colourTextBox";
            this.colourTextBox.Size = new System.Drawing.Size(160, 26);
            this.colourTextBox.TabIndex = 15;
            // 
            // numberOfDoors
            // 
            this.numberOfDoors.AutoSize = true;
            this.numberOfDoors.Location = new System.Drawing.Point(576, 90);
            this.numberOfDoors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numberOfDoors.Name = "numberOfDoors";
            this.numberOfDoors.Size = new System.Drawing.Size(130, 20);
            this.numberOfDoors.TabIndex = 16;
            this.numberOfDoors.Text = "Number of Doors";
            this.numberOfDoors.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // engineSize
            // 
            this.engineSize.AutoSize = true;
            this.engineSize.Location = new System.Drawing.Point(797, 90);
            this.engineSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.engineSize.Name = "engineSize";
            this.engineSize.Size = new System.Drawing.Size(94, 20);
            this.engineSize.TabIndex = 17;
            this.engineSize.Text = "Engine Size";
            // 
            // electricWindows
            // 
            this.electricWindows.AutoSize = true;
            this.electricWindows.Location = new System.Drawing.Point(1001, 90);
            this.electricWindows.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.electricWindows.Name = "electricWindows";
            this.electricWindows.Size = new System.Drawing.Size(129, 20);
            this.electricWindows.TabIndex = 18;
            this.electricWindows.Text = "Electric Windows";
            // 
            // numberOfDoorsTextBox
            // 
            this.numberOfDoorsTextBox.Location = new System.Drawing.Point(580, 115);
            this.numberOfDoorsTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numberOfDoorsTextBox.Name = "numberOfDoorsTextBox";
            this.numberOfDoorsTextBox.Size = new System.Drawing.Size(160, 26);
            this.numberOfDoorsTextBox.TabIndex = 19;
            // 
            // engineSizeTextBox
            // 
            this.engineSizeTextBox.Location = new System.Drawing.Point(801, 115);
            this.engineSizeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.engineSizeTextBox.Name = "engineSizeTextBox";
            this.engineSizeTextBox.Size = new System.Drawing.Size(160, 26);
            this.engineSizeTextBox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(576, 230);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Weight Limit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 377);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Airworthy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 518);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Seats";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(797, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Number of Wheels";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(799, 377);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Hours Used";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(800, 518);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Engines";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1001, 230);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Length";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1003, 377);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Altitude Limit";
            // 
            // weightLimitTextBox
            // 
            this.weightLimitTextBox.Location = new System.Drawing.Point(580, 257);
            this.weightLimitTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.weightLimitTextBox.Name = "weightLimitTextBox";
            this.weightLimitTextBox.Size = new System.Drawing.Size(160, 26);
            this.weightLimitTextBox.TabIndex = 31;
            // 
            // seatsTextBox
            // 
            this.seatsTextBox.Location = new System.Drawing.Point(583, 543);
            this.seatsTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seatsTextBox.Name = "seatsTextBox";
            this.seatsTextBox.Size = new System.Drawing.Size(160, 26);
            this.seatsTextBox.TabIndex = 33;
            // 
            // enginesTextBox
            // 
            this.enginesTextBox.Location = new System.Drawing.Point(804, 543);
            this.enginesTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enginesTextBox.Name = "enginesTextBox";
            this.enginesTextBox.Size = new System.Drawing.Size(160, 26);
            this.enginesTextBox.TabIndex = 34;
            // 
            // hoursUsedTextBox
            // 
            this.hoursUsedTextBox.Location = new System.Drawing.Point(803, 402);
            this.hoursUsedTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hoursUsedTextBox.Name = "hoursUsedTextBox";
            this.hoursUsedTextBox.Size = new System.Drawing.Size(160, 26);
            this.hoursUsedTextBox.TabIndex = 36;
            // 
            // numberOfWheelsTextBox
            // 
            this.numberOfWheelsTextBox.Location = new System.Drawing.Point(801, 255);
            this.numberOfWheelsTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numberOfWheelsTextBox.Name = "numberOfWheelsTextBox";
            this.numberOfWheelsTextBox.Size = new System.Drawing.Size(160, 26);
            this.numberOfWheelsTextBox.TabIndex = 37;
            // 
            // altitudeLimitTextBox
            // 
            this.altitudeLimitTextBox.Location = new System.Drawing.Point(1007, 402);
            this.altitudeLimitTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.altitudeLimitTextBox.Name = "altitudeLimitTextBox";
            this.altitudeLimitTextBox.Size = new System.Drawing.Size(160, 26);
            this.altitudeLimitTextBox.TabIndex = 38;
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(1005, 255);
            this.lengthTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(160, 26);
            this.lengthTextBox.TabIndex = 39;
            // 
            // airworthyComboBox
            // 
            this.airworthyComboBox.FormattingEnabled = true;
            this.airworthyComboBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.airworthyComboBox.Location = new System.Drawing.Point(582, 404);
            this.airworthyComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.airworthyComboBox.Name = "airworthyComboBox";
            this.airworthyComboBox.Size = new System.Drawing.Size(163, 28);
            this.airworthyComboBox.TabIndex = 40;
            // 
            // addVehicleButton
            // 
            this.addVehicleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.addVehicleButton.Location = new System.Drawing.Point(52, 444);
            this.addVehicleButton.Name = "addVehicleButton";
            this.addVehicleButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addVehicleButton.Size = new System.Drawing.Size(207, 78);
            this.addVehicleButton.TabIndex = 42;
            this.addVehicleButton.Text = "Add";
            this.addVehicleButton.UseVisualStyleBackColor = true;
            this.addVehicleButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.modifyButton.Location = new System.Drawing.Point(314, 444);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.modifyButton.Size = new System.Drawing.Size(207, 78);
            this.modifyButton.TabIndex = 43;
            this.modifyButton.Text = "Modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // electricWindowsComboBox
            // 
            this.electricWindowsComboBox.FormattingEnabled = true;
            this.electricWindowsComboBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.electricWindowsComboBox.Location = new System.Drawing.Point(1005, 115);
            this.electricWindowsComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.electricWindowsComboBox.Name = "electricWindowsComboBox";
            this.electricWindowsComboBox.Size = new System.Drawing.Size(163, 28);
            this.electricWindowsComboBox.TabIndex = 44;
            // 
            // carLabel
            // 
            this.carLabel.AutoSize = true;
            this.carLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.carLabel.Location = new System.Drawing.Point(576, 46);
            this.carLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.carLabel.Name = "carLabel";
            this.carLabel.Size = new System.Drawing.Size(58, 30);
            this.carLabel.TabIndex = 45;
            this.carLabel.Text = "Car";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label9.Location = new System.Drawing.Point(578, 184);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 30);
            this.label9.TabIndex = 46;
            this.label9.Text = "Truck";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label10.Location = new System.Drawing.Point(577, 338);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(270, 30);
            this.label10.TabIndex = 47;
            this.label10.Text = "Helicopter and Plane";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label11.Location = new System.Drawing.Point(578, 473);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 30);
            this.label11.TabIndex = 48;
            this.label11.Text = "Plane";
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.cancelButton.Location = new System.Drawing.Point(173, 568);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cancelButton.Size = new System.Drawing.Size(207, 78);
            this.cancelButton.TabIndex = 49;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // VehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.carLabel);
            this.Controls.Add(this.electricWindowsComboBox);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.addVehicleButton);
            this.Controls.Add(this.airworthyComboBox);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.altitudeLimitTextBox);
            this.Controls.Add(this.numberOfWheelsTextBox);
            this.Controls.Add(this.hoursUsedTextBox);
            this.Controls.Add(this.enginesTextBox);
            this.Controls.Add(this.seatsTextBox);
            this.Controls.Add(this.weightLimitTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.engineSizeTextBox);
            this.Controls.Add(this.numberOfDoorsTextBox);
            this.Controls.Add(this.electricWindows);
            this.Controls.Add(this.engineSize);
            this.Controls.Add(this.numberOfDoors);
            this.Controls.Add(this.colourTextBox);
            this.Controls.Add(this.registrationTextBox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.Colour);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.makeTextBox);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.Make);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VehicleForm";
            this.Text = "Vehicle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Make;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Weight;
        private System.Windows.Forms.Label Registration;
        private System.Windows.Forms.Label Colour;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox registrationTextBox;
        private System.Windows.Forms.TextBox colourTextBox;
        private System.Windows.Forms.Label numberOfDoors;
        private System.Windows.Forms.Label engineSize;
        private System.Windows.Forms.Label electricWindows;
        private System.Windows.Forms.TextBox numberOfDoorsTextBox;
        private System.Windows.Forms.TextBox engineSizeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox weightLimitTextBox;
        private System.Windows.Forms.TextBox seatsTextBox;
        private System.Windows.Forms.TextBox enginesTextBox;
        private System.Windows.Forms.TextBox hoursUsedTextBox;
        private System.Windows.Forms.TextBox numberOfWheelsTextBox;
        private System.Windows.Forms.TextBox altitudeLimitTextBox;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.ComboBox airworthyComboBox;
        private System.Windows.Forms.Button addVehicleButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.ComboBox electricWindowsComboBox;
        private System.Windows.Forms.Label carLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button cancelButton;
    }
}