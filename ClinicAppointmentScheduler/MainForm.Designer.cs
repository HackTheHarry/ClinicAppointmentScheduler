namespace ClinicAppointmentScheduler
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            btnPatients = new Button();
            btnDoctor = new Button();
            btnAppointment = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Teal;
            lblTitle.Font = new Font("Segoe UI", 20F);
            lblTitle.Location = new Point(71, 36);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(369, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Clinic Appointment Scheduler";
            // 
            // btnPatients
            // 
            btnPatients.BackColor = Color.IndianRed;
            btnPatients.Location = new Point(43, 112);
            btnPatients.Name = "btnPatients";
            btnPatients.Size = new Size(103, 34);
            btnPatients.TabIndex = 1;
            btnPatients.Text = "Patients";
            btnPatients.UseVisualStyleBackColor = false;
            btnPatients.Click += btnPatients_Click;
            // 
            // btnDoctor
            // 
            btnDoctor.BackColor = Color.LimeGreen;
            btnDoctor.Location = new Point(207, 112);
            btnDoctor.Name = "btnDoctor";
            btnDoctor.Size = new Size(107, 34);
            btnDoctor.TabIndex = 2;
            btnDoctor.Text = "Doctors";
            btnDoctor.UseVisualStyleBackColor = false;
            btnDoctor.Click += btnDoctors_Click;
            // 
            // btnAppointment
            // 
            btnAppointment.Location = new Point(362, 112);
            btnAppointment.Name = "btnAppointment";
            btnAppointment.Size = new Size(109, 34);
            btnAppointment.TabIndex = 3;
            btnAppointment.Text = "Appointments";
            btnAppointment.UseVisualStyleBackColor = true;
            btnAppointment.Click += btnAppointments_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 397);
            Controls.Add(btnAppointment);
            Controls.Add(btnDoctor);
            Controls.Add(btnPatients);
            Controls.Add(lblTitle);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnPatients;
        private Button btnDoctor;
        private Button btnAppointment;
    }
}
