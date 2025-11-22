# Student Bus Fare Management System (C# WinForms)

[![C#](https://img.shields.io/badge/C%23-.NET-blue)](https://dotnet.microsoft.com/)

## Project Overview
This project is a **Windows Forms Application** developed in C# for managing student bus fare details. It allows users to enter, calculate, and display student travel data including **bus fare, season ticket fare, and travel routes**. The data is displayed in a **DataGridView** for easy management and visualization.

---

## Features
- **Add Student Details:** Add student name, ID, NIC, and travel details.
- **Calculate Season Ticket Fare:** Automatically calculates season ticket fare based on bus fare.
- **View in DataGrid:** All entries are displayed in a **DataGridView**.
- **Clear Input Fields:** Easily reset all input fields for new entries.
- **Simple GUI:** User-friendly interface built using WinForms.

---

## Functionality

### Input Fields
- **Student Name**
- **Student ID**
- **NIC**
- **Bus Fare**
- **Travel From**
- **Transit**
- **Travel To**
- **Bus Route No.**

### Buttons
- **Add Student:** Adds student details to the table and calculates season ticket fare.
- **Clear:** Clears all input fields for new entry.

### Season Ticket Calculation
The season ticket fare is calculated using the formula:
Season Ticket Fare = (Bus Fare / 4) * 2 * 23
This calculation automatically updates the **Season Ticket Fare** field when adding a student.

---

## Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/student-bus-fare.git


2. Open the solution file (.sln) in Visual Studio.

3. Build and run the application.

## Usage

- Enter the student details in the input fields.

- Enter the bus fare.

- Click the Add Student button. The season ticket fare will be automatically calculated and all data will appear in the DataGridView.

- Click Clear to reset the input fields for the next entry.

## Screenshots

<img width="944" height="545" alt="image" src="https://github.com/user-attachments/assets/c02a7de4-9a1c-4f7e-add2-33b3235c3792" />

## Notes

- Ensure numeric values are entered for Bus Fare to avoid parsing errors.

- Data is stored temporarily in a DataTable; closing the application will clear all entries.

- This project can be extended to save data to a database or export to Excel/XML.

## Author

Sanjana Thilakasiri


