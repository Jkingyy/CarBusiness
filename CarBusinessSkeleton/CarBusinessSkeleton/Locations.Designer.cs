namespace CarBusinessSkeleton
{
    partial class Locations
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
            this.locationsList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.vehiclesInStockLabel = new System.Windows.Forms.Label();
            this.totalValueLabel = new System.Windows.Forms.Label();
            this.mostExpensiveLabel = new System.Windows.Forms.Label();
            this.mostExpensiveTypeLabel = new System.Windows.Forms.Label();
            this.selectLocation = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // locationsList
            // 
            this.locationsList.FormattingEnabled = true;
            this.locationsList.ItemHeight = 20;
            this.locationsList.Location = new System.Drawing.Point(66, 120);
            this.locationsList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.locationsList.Name = "locationsList";
            this.locationsList.Size = new System.Drawing.Size(1051, 384);
            this.locationsList.TabIndex = 0;
            this.locationsList.SelectedIndexChanged += new System.EventHandler(this.locationsList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 509);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vehicles in stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 554);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 602);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Most expensive vehicle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 643);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Most expensive vehicle type";
            // 
            // vehiclesInStockLabel
            // 
            this.vehiclesInStockLabel.AutoSize = true;
            this.vehiclesInStockLabel.Location = new System.Drawing.Point(351, 509);
            this.vehiclesInStockLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vehiclesInStockLabel.Name = "vehiclesInStockLabel";
            this.vehiclesInStockLabel.Size = new System.Drawing.Size(0, 20);
            this.vehiclesInStockLabel.TabIndex = 5;
            // 
            // totalValueLabel
            // 
            this.totalValueLabel.AutoSize = true;
            this.totalValueLabel.Location = new System.Drawing.Point(351, 554);
            this.totalValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalValueLabel.Name = "totalValueLabel";
            this.totalValueLabel.Size = new System.Drawing.Size(0, 20);
            this.totalValueLabel.TabIndex = 6;
            // 
            // mostExpensiveLabel
            // 
            this.mostExpensiveLabel.AutoSize = true;
            this.mostExpensiveLabel.Location = new System.Drawing.Point(351, 598);
            this.mostExpensiveLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mostExpensiveLabel.Name = "mostExpensiveLabel";
            this.mostExpensiveLabel.Size = new System.Drawing.Size(0, 20);
            this.mostExpensiveLabel.TabIndex = 7;
            // 
            // mostExpensiveTypeLabel
            // 
            this.mostExpensiveTypeLabel.AutoSize = true;
            this.mostExpensiveTypeLabel.Location = new System.Drawing.Point(350, 642);
            this.mostExpensiveTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mostExpensiveTypeLabel.Name = "mostExpensiveTypeLabel";
            this.mostExpensiveTypeLabel.Size = new System.Drawing.Size(0, 20);
            this.mostExpensiveTypeLabel.TabIndex = 8;
            // 
            // selectLocation
            // 
            this.selectLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.selectLocation.Location = new System.Drawing.Point(879, 529);
            this.selectLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectLocation.Name = "selectLocation";
            this.selectLocation.Size = new System.Drawing.Size(220, 92);
            this.selectLocation.TabIndex = 9;
            this.selectLocation.Text = "Select";
            this.selectLocation.UseVisualStyleBackColor = true;
            this.selectLocation.Click += new System.EventHandler(this.selectLocation_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.saveButton.Location = new System.Drawing.Point(1012, 14);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(133, 74);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Locations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.selectLocation);
            this.Controls.Add(this.mostExpensiveTypeLabel);
            this.Controls.Add(this.mostExpensiveLabel);
            this.Controls.Add(this.totalValueLabel);
            this.Controls.Add(this.vehiclesInStockLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.locationsList);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Locations";
            this.Text = "Locations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox locationsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label vehiclesInStockLabel;
        private System.Windows.Forms.Label totalValueLabel;
        private System.Windows.Forms.Label mostExpensiveLabel;
        private System.Windows.Forms.Label mostExpensiveTypeLabel;
        private System.Windows.Forms.Button selectLocation;
        private System.Windows.Forms.Button saveButton;
    }
}