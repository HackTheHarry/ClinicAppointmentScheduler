namespace ClinicAppointmentScheduler
{
    partial class AppointmentForm
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
            lblPatient = new Label();
            lblDoctor = new Label();
            lblDate = new Label();
            lblTime = new Label();
            lblReason = new Label();
            lblStatus = new Label();
            cmbPatient = new ComboBox();
            cmbDoctor = new ComboBox();
            cmbStatus = new ComboBox();
            dtpDate = new DateTimePicker();
            dtpTime = new DateTimePicker();
            txtReason = new TextBox();
            dgvAppointments = new DataGridView();
            btnUpdateAppointment = new Button();
            btnDeleteAppointment = new Button();
            btnClearAppointment = new Button();
            btnBookAppointment = new Button();
            lblTitle = new Label();
            lblList = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            SuspendLayout();
            // 
            // lblPatient
            // 
            lblPatient.AutoSize = true;
            lblPatient.Location = new Point(91, 46);
            lblPatient.Name = "lblPatient";
            lblPatient.Size = new Size(44, 15);
            lblPatient.TabIndex = 0;
            lblPatient.Text = "Patient";
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.Location = new Point(91, 75);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(43, 15);
            lblDoctor.TabIndex = 1;
            lblDoctor.Text = "Doctor";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(91, 107);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(31, 15);
            lblDate.TabIndex = 2;
            lblDate.Text = "Date";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(91, 136);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(33, 15);
            lblTime.TabIndex = 3;
            lblTime.Text = "Time";
            // 
            // lblReason
            // 
            lblReason.AutoSize = true;
            lblReason.Location = new Point(91, 162);
            lblReason.Name = "lblReason";
            lblReason.Size = new Size(45, 15);
            lblReason.TabIndex = 4;
            lblReason.Text = "Reason";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(91, 191);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Status";
            // 
            // cmbPatient
            // 
            cmbPatient.FormattingEnabled = true;
            cmbPatient.Location = new Point(214, 43);
            cmbPatient.Name = "cmbPatient";
            cmbPatient.Size = new Size(121, 23);
            cmbPatient.TabIndex = 6;
            cmbPatient.Text = "Select patient";
            // 
            // cmbDoctor
            // 
            cmbDoctor.FormattingEnabled = true;
            cmbDoctor.Location = new Point(214, 72);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.Size = new Size(121, 23);
            cmbDoctor.TabIndex = 7;
            cmbDoctor.Text = "Select doctor";
            // 
            // cmbStatus
            // 
            cmbStatus.AutoCompleteCustomSource.AddRange(new string[] { "Scheduled", "Completed", "Cancelled" });
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(214, 188);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 23);
            cmbStatus.TabIndex = 8;
            cmbStatus.Text = "Status";
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(214, 101);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(121, 23);
            dtpDate.TabIndex = 9;
            // 
            // dtpTime
            // 
            dtpTime.Format = DateTimePickerFormat.Time;
            dtpTime.Location = new Point(214, 130);
            dtpTime.Name = "dtpTime";
            dtpTime.ShowUpDown = true;
            dtpTime.Size = new Size(121, 23);
            dtpTime.TabIndex = 10;
            // 
            // txtReason
            // 
            txtReason.Location = new Point(214, 159);
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(121, 23);
            txtReason.TabIndex = 11;
            txtReason.Text = "Reason";
            // 
            // dgvAppointments
            // 
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.Location = new Point(12, 309);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.Size = new Size(547, 129);
            dgvAppointments.TabIndex = 12;
            dgvAppointments.CellClick += dgvAppointments_CellClick;
            // 
            // btnUpdateAppointment
            // 
            btnUpdateAppointment.Location = new Point(174, 227);
            btnUpdateAppointment.Name = "btnUpdateAppointment";
            btnUpdateAppointment.Size = new Size(75, 23);
            btnUpdateAppointment.TabIndex = 13;
            btnUpdateAppointment.Text = "Update";
            btnUpdateAppointment.UseVisualStyleBackColor = true;
            btnUpdateAppointment.Click += btnUpdateAppointment_Click;
            // 
            // btnDeleteAppointment
            // 
            btnDeleteAppointment.Location = new Point(281, 227);
            btnDeleteAppointment.Name = "btnDeleteAppointment";
            btnDeleteAppointment.Size = new Size(105, 23);
            btnDeleteAppointment.TabIndex = 14;
            btnDeleteAppointment.Text = "Cancel/Delete";
            btnDeleteAppointment.UseVisualStyleBackColor = true;
            btnDeleteAppointment.Click += btnDeleteAppointment_Click;
            // 
            // btnClearAppointment
            // 
            btnClearAppointment.Location = new Point(415, 227);
            btnClearAppointment.Name = "btnClearAppointment";
            btnClearAppointment.Size = new Size(75, 23);
            btnClearAppointment.TabIndex = 15;
            btnClearAppointment.Text = "Clear";
            btnClearAppointment.UseVisualStyleBackColor = true;
            btnClearAppointment.Click += btnClearAppointment_Click;
            // 
            // btnBookAppointment
            // 
            btnBookAppointment.Location = new Point(69, 227);
            btnBookAppointment.Name = "btnBookAppointment";
            btnBookAppointment.Size = new Size(75, 23);
            btnBookAppointment.TabIndex = 16;
            btnBookAppointment.Text = "Book Appointment";
            btnBookAppointment.UseVisualStyleBackColor = true;
            btnBookAppointment.Click += btnBookAppointment_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F);
            lblTitle.Location = new Point(69, 3);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(386, 37);
            lblTitle.TabIndex = 17;
            lblTitle.Text = "APPOINTMENT MANAGEMENT";
            // 
            // lblList
            // 
            lblList.AutoSize = true;
            lblList.Font = new Font("Segoe UI", 15F);
            lblList.Location = new Point(214, 278);
            lblList.Name = "lblList";
            lblList.Size = new Size(196, 28);
            lblList.TabIndex = 18;
            lblList.Text = "APPOINTMENT LISTS";
            // 
            // AppointmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 450);
            Controls.Add(lblList);
            Controls.Add(lblTitle);
            Controls.Add(btnBookAppointment);
            Controls.Add(btnClearAppointment);
            Controls.Add(btnDeleteAppointment);
            Controls.Add(btnUpdateAppointment);
            Controls.Add(dgvAppointments);
            Controls.Add(txtReason);
            Controls.Add(dtpTime);
            Controls.Add(dtpDate);
            Controls.Add(cmbStatus);
            Controls.Add(cmbDoctor);
            Controls.Add(cmbPatient);
            Controls.Add(lblStatus);
            Controls.Add(lblReason);
            Controls.Add(lblTime);
            Controls.Add(lblDate);
            Controls.Add(lblDoctor);
            Controls.Add(lblPatient);
            Name = "AppointmentForm";
            Text = "AppointmentForm";
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPatient;
        private Label lblDoctor;
        private Label lblDate;
        private Label lblTime;
        private Label lblReason;
        private Label lblStatus;
        private ComboBox cmbPatient;
        private ComboBox cmbDoctor;
        private ComboBox cmbStatus;
        private DateTimePicker dtpDate;
        private DateTimePicker dtpTime;
        private TextBox txtReason;
        private DataGridView dgvAppointments;
        private Button btnUpdateAppointment;
        private Button btnDeleteAppointment;
        private Button btnClearAppointment;
        private Button btnBookAppointment;
        private Label lblTitle;
        private Label lblList;
    }
}