namespace CarBusinessSkeleton
{
    partial class VehiclesForm
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
            this.vehiclesListBox = new System.Windows.Forms.ListBox();
            this.add = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.modify = new System.Windows.Forms.Button();
            this.vehicleRestorationButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vehiclesListBox
            // 
            this.vehiclesListBox.FormattingEnabled = true;
            this.vehiclesListBox.ItemHeight = 20;
            this.vehiclesListBox.Location = new System.Drawing.Point(52, 117);
            this.vehiclesListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vehiclesListBox.Name = "vehiclesListBox";
            this.vehiclesListBox.Size = new System.Drawing.Size(1093, 384);
            this.vehiclesListBox.TabIndex = 0;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.add.Location = new System.Drawing.Point(57, 540);
            this.add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(213, 108);
            this.add.TabIndex = 1;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.removeButton.Location = new System.Drawing.Point(342, 540);
            this.removeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(213, 108);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // modify
            // 
            this.modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.modify.Location = new System.Drawing.Point(912, 540);
            this.modify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(213, 108);
            this.modify.TabIndex = 3;
            this.modify.Text = "Modify";
            this.modify.UseVisualStyleBackColor = true;
            this.modify.Click += new System.EventHandler(this.modify_Click);
            // 
            // vehicleRestorationButton
            // 
            this.vehicleRestorationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.vehicleRestorationButton.Location = new System.Drawing.Point(630, 540);
            this.vehicleRestorationButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vehicleRestorationButton.Name = "vehicleRestorationButton";
            this.vehicleRestorationButton.Size = new System.Drawing.Size(213, 108);
            this.vehicleRestorationButton.TabIndex = 4;
            this.vehicleRestorationButton.Text = "Restore Vehicle";
            this.vehicleRestorationButton.UseVisualStyleBackColor = true;
            this.vehicleRestorationButton.Click += new System.EventHandler(this.vehicleRestorationButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(52, 14);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(113, 73);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.saveButton.Location = new System.Drawing.Point(1012, 13);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(133, 74);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // VehiclesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.vehicleRestorationButton);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.add);
            this.Controls.Add(this.vehiclesListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VehiclesForm";
            this.Text = "Vehicles";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox vehiclesListBox;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button modify;
        private System.Windows.Forms.Button vehicleRestorationButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button saveButton;
    }
}