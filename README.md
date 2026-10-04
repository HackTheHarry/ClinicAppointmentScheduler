# Clinic Appointment Scheduler

## Project Description

## Features

## Technologies Used

## Project Structure

## Database Design

## Requirements

## Setup Instructions

## How to Run

## How to Use

## Validation

## OOP Concepts Demonstrated

## Screenshots

## References and Tools Used

## Milestone 1 Proposal

## Author

# Clinic Appointment Scheduler

A desktop clinic appointment management application developed using **C# Windows Forms** and **SQLite**. The application provides a simple interface for managing patients, doctors, and clinic appointments.

## Project Description

The Clinic Appointment Scheduler is designed to help a small clinic manage patient, doctor, and appointment information in one application.

The application allows users to:

* Add, update, view, and delete patient records
* Add, update, view, and delete doctor records
* Book appointments
* Update appointments
* Cancel appointments
* Store information using an SQLite database

## Features

### Patient Management

* Add patient
* View patient records
* Update patient information
* Delete patient
* Validate patient information

Patient information includes:

* Patient ID
* Full Name
* Age
* Gender
* Phone
* Address

### Doctor Management

* Add doctor
* View doctor records
* Update doctor information
* Delete doctor
* Manage doctor specialization

### Appointment Management

* Select a patient
* Select a doctor
* Select appointment date and time
* Enter appointment reason
* Set appointment status
* Book appointment
* Update appointment
* Cancel appointment
* View appointment records

## Technologies Used

* C#
* .NET
* Windows Forms
* SQLite
* Microsoft.Data.Sqlite
* Visual Studio
* Git
* GitHub

## Database

The application uses SQLite to store application data.

The database contains:

* `Patients`
* `Doctors`
* `Appointments`

Appointments use patient and doctor IDs to connect appointment records with the corresponding patient and doctor.

## Requirements

To run the application, you need:

* Windows
* Visual Studio
* .NET SDK compatible with the project
* Windows Forms development support

## Setup Instructions

1. Clone the repository:

```bash
git clone https://github.com/HackTheHarry/ClinicAppointmentScheduler.git
```

2. Open the solution in Visual Studio.

3. Restore the required NuGet packages.

4. Build the solution.

5. Run the application.

The application initializes the SQLite database when it starts.

## How to Use

### Patients

Open the **Patients** section to add, update, view, or delete patient records.

### Doctors

Open the **Doctors** section to add, update, view, or delete doctor records.

### Appointments

Open the **Appointments** section, select a patient and doctor, choose the appointment date and time, enter the reason, and book the appointment.

## Validation

The application includes validation for user input.

Examples include:

* Checking that required fields are not empty
* Checking that patient age is a valid number
* Checking that a record is selected before updating or deleting it
* Confirming deletion or cancellation operations

## Screenshots

The repository includes screenshots of the main application forms:

* `MainForm.png`
* `PatientForm.png`
* `DoctorForm.png`
* `AppointmentForm.png`

## OOP Concepts

The application is developed using object-oriented programming in C#.

The project contains classes such as:

* `MainForm`
* `PatientForm`
* `DoctorForm`
* `AppointmentForm`
* `Database`

The final OOP description should correspond to the actual implementation in the submitted source code.

## References and Tools Used

### Development Tools

* Microsoft Visual Studio
* C#
* .NET Windows Forms
* SQLite
* Microsoft.Data.Sqlite
* Git
* GitHub

### Learning Resources

* Microsoft C# documentation
* Microsoft Windows Forms documentation
* SQLite documentation
* Microsoft.Data.Sqlite documentation
* GitHub documentation

### Generative AI

ChatGPT was used as a learning and development support tool during the project for understanding programming concepts, troubleshooting errors, discussing implementation approaches, and reviewing parts of the project.

All final code and documentation were reviewed by the student, who remains responsible for understanding and explaining the submitted project.

## Milestone 1 Proposal

The approved Milestone 1 proposal should be included in the repository or referenced here.

**Proposal:** `[ITS203 Milestone 1 Proposal](ITS203_Milestone1_S2500248.docx)`

## GitHub Repository

https://github.com/HackTheHarry/ClinicAppointmentScheduler

## Author

Abiral Tiwari
