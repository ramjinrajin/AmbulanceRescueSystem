namespace AmbulanceRescueSystem._1.PresentationLayer
{
    partial class AddVechicle
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.combAddress = new System.Windows.Forms.ComboBox();
            this.combHospital = new System.Windows.Forms.ComboBox();
            this.txtGpsId = new System.Windows.Forms.TextBox();
            this.txtLicenseNo = new System.Windows.Forms.TextBox();
            this.txtDriverName = new System.Windows.Forms.TextBox();
            this.txtVehicleNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 504);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label2.Location = new System.Drawing.Point(3, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(484, 38);
            this.label2.TabIndex = 1;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnAddDriver);
            this.panel2.Controls.Add(this.combAddress);
            this.panel2.Controls.Add(this.combHospital);
            this.panel2.Controls.Add(this.txtGpsId);
            this.panel2.Controls.Add(this.txtLicenseNo);
            this.panel2.Controls.Add(this.txtDriverName);
            this.panel2.Controls.Add(this.txtVehicleNo);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(54, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(388, 339);
            this.panel2.TabIndex = 2;
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddDriver.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDriver.ForeColor = System.Drawing.Color.White;
            this.btnAddDriver.Location = new System.Drawing.Point(117, 282);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(162, 38);
            this.btnAddDriver.TabIndex = 12;
            this.btnAddDriver.Text = "Add driver";
            this.btnAddDriver.UseVisualStyleBackColor = false;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // combAddress
            // 
            this.combAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combAddress.FormattingEnabled = true;
            this.combAddress.Items.AddRange(new object[] {
            "Trivandrum",
            "Kollam",
            "Madurai",
            "Chennai"});
            this.combAddress.Location = new System.Drawing.Point(169, 233);
            this.combAddress.Name = "combAddress";
            this.combAddress.Size = new System.Drawing.Size(150, 27);
            this.combAddress.TabIndex = 11;
            // 
            // combHospital
            // 
            this.combHospital.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combHospital.FormattingEnabled = true;
            this.combHospital.Items.AddRange(new object[] {
            "Kims",
            "Ananthapuri",
            "SP FORT"});
            this.combHospital.Location = new System.Drawing.Point(169, 196);
            this.combHospital.Name = "combHospital";
            this.combHospital.Size = new System.Drawing.Size(150, 27);
            this.combHospital.TabIndex = 10;
            // 
            // txtGpsId
            // 
            this.txtGpsId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGpsId.Location = new System.Drawing.Point(169, 161);
            this.txtGpsId.Name = "txtGpsId";
            this.txtGpsId.Size = new System.Drawing.Size(150, 26);
            this.txtGpsId.TabIndex = 9;
            // 
            // txtLicenseNo
            // 
            this.txtLicenseNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicenseNo.Location = new System.Drawing.Point(169, 129);
            this.txtLicenseNo.Name = "txtLicenseNo";
            this.txtLicenseNo.Size = new System.Drawing.Size(150, 26);
            this.txtLicenseNo.TabIndex = 8;
            // 
            // txtDriverName
            // 
            this.txtDriverName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriverName.Location = new System.Drawing.Point(169, 90);
            this.txtDriverName.Name = "txtDriverName";
            this.txtDriverName.Size = new System.Drawing.Size(150, 26);
            this.txtDriverName.TabIndex = 7;
            // 
            // txtVehicleNo
            // 
            this.txtVehicleNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleNo.Location = new System.Drawing.Point(169, 44);
            this.txtVehicleNo.Name = "txtVehicleNo";
            this.txtVehicleNo.Size = new System.Drawing.Size(150, 26);
            this.txtVehicleNo.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Driver Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "License NO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "GPS ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hospital ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Vehicle No";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(3, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 93);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD DRIVER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddVechicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 522);
            this.Controls.Add(this.panel1);
            this.Name = "AddVechicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddVechicle";
            this.Load += new System.EventHandler(this.AddVechicle_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddDriver;
        private System.Windows.Forms.ComboBox combAddress;
        private System.Windows.Forms.ComboBox combHospital;
        private System.Windows.Forms.TextBox txtGpsId;
        private System.Windows.Forms.TextBox txtLicenseNo;
        private System.Windows.Forms.TextBox txtDriverName;
        private System.Windows.Forms.TextBox txtVehicleNo;
        private System.Windows.Forms.Label label6;
    }
}