# ParkEase — Parking Management System

A beginner-friendly desktop Parking Management System built with **C# Windows Forms** and **Microsoft SQL Server**. ParkEase supports two user roles (Admin and User) and provides full CRUD functionality for managing parking slots, vehicles, and parking records.

---

## ✨ Features

### Admin
- Dashboard with total slots, available slots, and total earnings
- Manage parking slots (add, edit, delete)
- View all registered vehicles
- View complete parking records (entry, exit, fee)
- Manage user accounts
- System settings

### User
- Personal dashboard with vehicle and active parking summary
- Add and remove personal vehicles
- View available slots in real time
- Park a vehicle (assign a slot)
- Exit a vehicle (auto-calculate fee)
- View parking history
- Process payments

---

## 🛠️ Tech Stack

- **Language:** C# (.NET Framework)
- **UI:** Windows Forms (WinForms)
- **Database:** Microsoft SQL Server Express 2019
- **Data Access:** ADO.NET (`System.Data.SqlClient`)
- **IDE:** Visual Studio 2019 / 2022

---

## 📂 Project Structure

```
ParkEase/
│
├── DataAccess.cs              # Database connection and query helper class
├── Session.cs                 # Stores logged-in user info
├── Program.cs                 # Application entry point
│
├── frmSignIn.cs               # Login form
├── frmSignUp.cs               # Registration form
│
├── frmAdminDashboard.cs       # Admin home screen
├── frmAdminManageSlots.cs     # Add/edit/delete slots
├── frmAdminVehicles.cs        # View all vehicles
├── frmAdminParkingRecords.cs  # View all parking records
├── frmAdminUsers.cs           # Manage users
├── frmAdminSettings.cs        # Admin settings
│
├── frmUserDashboard.cs        # User home screen
├── frmUserVehicles.cs         # Manage personal vehicles
├── frmUserAvailableSlots.cs   # View free slots & park vehicle
├── frmUserParkingHistory.cs   # View parking history
├── frmUserPayment.cs          # Pay parking fees
└── frmUserSettings.cs         # User settings
```

---

## 🗄️ Database Schema (2NF)

| Table | Columns |
|---|---|
| **users** | `user_id` (PK), `username`, `password`, `role` |
| **vehicles** | `vehicle_id` (PK), `user_id` (FK), `plate_number`, `vehicle_type` |
| **parking_slots** | `slot_id` (PK), `slot_number`, `status` |
| **parking_records** | `record_id` (PK), `vehicle_id` (FK), `slot_id` (FK), `entry_time`, `exit_time`, `fee` |

---

## 🚀 Getting Started

### Prerequisites
- Visual Studio 2019 or 2022 (with .NET desktop development workload)
- SQL Server Express 2019 (or later)
- SQL Server Management Studio (SSMS)

### Setup

**1. Clone the repository**

```bash
git clone https://github.com/SamJU25/ParkEase-.git
```

**2. Restore the database**

- Open SSMS
- Run the SQL script located in the `Database` folder to create the database and tables
- (Optional) Insert a default admin account

**3. Update the connection string**

Open `DataAccess.cs` and edit this line to match your SQL Server instance:

```csharp
this.Sqlcon = new SqlConnection(
    @"Data Source=YOUR-SERVER-NAME;Initial Catalog=DSummerDB;Integrated Security=True"
);
```

**4. Build and run**

- Open `ParkEase.slnx` in Visual Studio
- Press **F5** to build and run

---

## 🔐 Default Login

| Role  | Username | Password   |
|-------|----------|------------|
| Admin | `admin`  | `admin123` |
| User  | `john`   | `12345`    |

> Update these credentials in the `users` table after first login.

---

## 🧱 Design Notes

- **OOP-based design** with separate concerns (UI, data access, session)
- **Single `DataAccess` class** handles all database connections and queries
- **Try-catch blocks** wrap all DB operations and login checks
- **Form validation** prevents empty fields and invalid input
- **Clean UI** — white background, light purple buttons, rectangular controls, no animations

---

## 📝 License

This project is created for academic purposes.

---

## 👤 Author

**SamJU25** — Built as part of a coursework submission.