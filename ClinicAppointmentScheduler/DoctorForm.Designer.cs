namespace ClinicAppointmentScheduler
{
    partial class DoctorForm
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
            lblDoctorName = new Label();
            lblSpecialization = new Label();
            lblDoctorPhone = new Label();
            lblDoctorTitle = new Label();
            lblList = new Label();
            txtDoctorName = new TextBox();
            txtSpecialization = new TextBox();
            txtDoctorPhone = new TextBox();
            btnAddDoctor = new Button();
            btnUpdateDoctor = new Button();
            btnDeleteDoctor = new Button();
            btnClearDoctor = new Button();
            dgvDoctors = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).BeginInit();
            SuspendLayout();
            // 
            // lblDoctorName
            // 
            lblDoctorName.AutoSize = true;
            lblDoctorName.Location = new Point(95, 64);
            lblDoctorName.Name = "lblDoctorName";
            lblDoctorName.Size = new Size(61, 15);
            lblDoctorName.TabIndex = 0;
            lblDoctorName.Text = "Full Name";
            // 
            // lblSpecialization
            // 
            lblSpecialization.AutoSize = true;
            lblSpecialization.Location = new Point(95, 98);
            lblSpecialization.Name = "lblSpecialization";
            lblSpecialization.Size = new Size(79, 15);
            lblSpecialization.TabIndex = 1;
            lblSpecialization.Text = "Specialization";
            // 
            // lblDoctorPhone
            // 
            lblDoctorPhone.AutoSize = true;
            lblDoctorPhone.Location = new Point(95, 133);
            lblDoctorPhone.Name = "lblDoctorPhone";
            lblDoctorPhone.Size = new Size(41, 15);
            lblDoctorPhone.TabIndex = 2;
            lblDoctorPhone.Text = "Phone";
            // 
            // lblDoctorTitle
            // 
            lblDoctorTitle.AutoSize = true;
            lblDoctorTitle.Font = new Font("Segoe UI", 20F);
            lblDoctorTitle.Location = new Point(95, 9);
            lblDoctorTitle.Name = "lblDoctorTitle";
            lblDoctorTitle.Size = new Size(311, 37);
            lblDoctorTitle.TabIndex = 3;
            lblDoctorTitle.Text = "DOCTOR MANAGEMENT";
            // 
            // lblList
            // 
            lblList.AutoSize = true;
            lblList.Font = new Font("Segoe UI", 15F);
            lblList.Location = new Point(239, 217);
            lblList.Name = "lblList";
            lblList.Size = new Size(140, 28);
            lblList.TabIndex = 4;
            lblList.Text = "DOCTORS LIST";
            // 
            // txtDoctorName
            // 
            txtDoctorName.Location = new Point(292, 56);
            txtDoctorName.Name = "txtDoctorName";
            txtDoctorName.Size = new Size(100, 23);
            txtDoctorName.TabIndex = 5;
            // 
            // txtSpecialization
            // 
            txtSpecialization.Location = new Point(292, 90);
            txtSpecialization.Name = "txtSpecialization";
            txtSpecialization.Size = new Size(100, 23);
            txtSpecialization.TabIndex = 6;
            // 
            // txtDoctorPhone
            // 
            txtDoctorPhone.Location = new Point(292, 125);
            txtDoctorPhone.Name = "txtDoctorPhone";
            txtDoctorPhone.Size = new Size(100, 23);
            txtDoctorPhone.TabIndex = 7;
            // 
            // btnAddDoctor
            // 
            btnAddDoctor.Location = new Point(95, 173);
            btnAddDoctor.Name = "btnAddDoctor";
            btnAddDoctor.Size = new Size(94, 23);
            btnAddDoctor.TabIndex = 8;
            btnAddDoctor.Text = "Add Doctor";
            btnAddDoctor.UseVisualStyleBackColor = true;
            btnAddDoctor.Click += btnAddDoctor_Click;
            // 
            // btnUpdateDoctor
            // 
            btnUpdateDoctor.Location = new Point(220, 173);
            btnUpdateDoctor.Name = "btnUpdateDoctor";
            btnUpdateDoctor.Size = new Size(75, 23);
            btnUpdateDoctor.TabIndex = 9;
            btnUpdateDoctor.Text = "Update";
            btnUpdateDoctor.UseVisualStyleBackColor = true;
            btnUpdateDoctor.Click += btnUpdateDoctor_Click;
            // 
            // btnDeleteDoctor
            // 
            btnDeleteDoctor.Location = new Point(317, 173);
            btnDeleteDoctor.Name = "btnDeleteDoctor";
            btnDeleteDoctor.Size = new Size(75, 23);
            btnDeleteDoctor.TabIndex = 10;
            btnDeleteDoctor.Text = "Delete";
            btnDeleteDoctor.UseVisualStyleBackColor = true;
            btnDeleteDoctor.Click += btnDeleteDoctor_Click;
            // 
            // btnClearDoctor
            // 
            btnClearDoctor.Location = new Point(417, 173);
            btnClearDoctor.Name = "btnClearDoctor";
            btnClearDoctor.Size = new Size(75, 23);
            btnClearDoctor.TabIndex = 11;
            btnClearDoctor.Text = "Clear";
            btnClearDoctor.UseVisualStyleBackColor = true;
            btnClearDoctor.Click += btnClearDoctor_Click;
            // 
            // dgvDoctors
            // 
            dgvDoctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoctors.Location = new Point(82, 248);
            dgvDoctors.Name = "dgvDoctors";
            dgvDoctors.Size = new Size(459, 126);
            dgvDoctors.TabIndex = 12;
            dgvDoctors.CellClick += dgvDoctors_CellClick;
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 396);
            Controls.Add(dgvDoctors);
            Controls.Add(btnClearDoctor);
            Controls.Add(btnDeleteDoctor);
            Controls.Add(btnUpdateDoctor);
            Controls.Add(btnAddDoctor);
            Controls.Add(txtDoctorPhone);
            Controls.Add(txtSpecialization);
            Controls.Add(txtDoctorName);
            Controls.Add(lblList);
            Controls.Add(lblDoctorTitle);
            Controls.Add(lblDoctorPhone);
            Controls.Add(lblSpecialization);
            Controls.Add(lblDoctorName);
            Name = "DoctorForm";
            Text = "DoctorForm";
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDoctorName;
        private Label lblSpecialization;
        private Label lblDoctorPhone;
        private Label lblDoctorTitle;
        private Label lblList;
        private TextBox txtDoctorName;
        private TextBox txtSpecialization;
        private TextBox txtDoctorPhone;
        private Button btnAddDoctor;
        private Button btnUpdateDoctor;
        private Button btnDeleteDoctor;
        private Button btnClearDoctor;
        private DataGridView dgvDoctors;
    }
}