namespace AmbulanceRescueSystem._1.PresentationLayer.UserDetails
{
    partial class loadUpdate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UserGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddHospital = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ColFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UserGridView
            // 
            this.UserGridView.AllowUserToAddRows = false;
            this.UserGridView.BackgroundColor = System.Drawing.Color.White;
            this.UserGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColFirstName,
            this.ColLastName,
            this.ColEmail,
            this.ColMobile,
            this.ColUserName});
            this.UserGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.UserGridView.EnableHeadersVisualStyles = false;
            this.UserGridView.GridColor = System.Drawing.SystemColors.Highlight;
            this.UserGridView.Location = new System.Drawing.Point(53, 96);
            this.UserGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserGridView.MultiSelect = false;
            this.UserGridView.Name = "UserGridView";
            this.UserGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserGridView.Size = new System.Drawing.Size(1124, 230);
            this.UserGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1207, 60);
            this.label1.TabIndex = 3;
            this.label1.Text = "MANAGE USERS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label2.Location = new System.Drawing.Point(0, 482);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1207, 23);
            this.label2.TabIndex = 4;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddHospital
            // 
            this.btnAddHospital.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddHospital.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHospital.ForeColor = System.Drawing.Color.White;
            this.btnAddHospital.Location = new System.Drawing.Point(391, 373);
            this.btnAddHospital.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddHospital.Name = "btnAddHospital";
            this.btnAddHospital.Size = new System.Drawing.Size(216, 47);
            this.btnAddHospital.TabIndex = 13;
            this.btnAddHospital.Text = "EDIT";
            this.btnAddHospital.UseVisualStyleBackColor = false;
            this.btnAddHospital.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(624, 373);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 47);
            this.button2.TabIndex = 14;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // ColFirstName
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            this.ColFirstName.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColFirstName.HeaderText = "FirstName";
            this.ColFirstName.Name = "ColFirstName";
            this.ColFirstName.ReadOnly = true;
            this.ColFirstName.Width = 200;
            // 
            // ColLastName
            // 
            this.ColLastName.HeaderText = "LastName";
            this.ColLastName.Name = "ColLastName";
            this.ColLastName.ReadOnly = true;
            this.ColLastName.Width = 200;
            // 
            // ColEmail
            // 
            this.ColEmail.HeaderText = "Email";
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.ReadOnly = true;
            this.ColEmail.Width = 200;
            // 
            // ColMobile
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColMobile.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColMobile.HeaderText = "Mobile";
            this.ColMobile.Name = "ColMobile";
            this.ColMobile.ReadOnly = true;
            // 
            // ColUserName
            // 
            this.ColUserName.HeaderText = "UserName";
            this.ColUserName.Name = "ColUserName";
            this.ColUserName.ReadOnly = true;
            // 
            // loadUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 505);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddHospital);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "loadUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loadUpdate";
            this.Load += new System.EventHandler(this.loadUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UserGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddHospital;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUserName;
    }
}