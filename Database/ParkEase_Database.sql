USE master;
GO

-- Drop existing database to ensure a clean build
IF DB_ID('ParkEaseDB') IS NOT NULL
BEGIN
    ALTER DATABASE ParkEaseDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE ParkEaseDB;
END
GO

CREATE DATABASE ParkEaseDB;
GO

USE ParkEaseDB;
GO

-- Users Table
CREATE TABLE users (
    user_id INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(30) NOT NULL UNIQUE,
    password VARCHAR(50) NOT NULL,
    role VARCHAR(10) NOT NULL CHECK (role IN ('Admin', 'User')),
    status VARCHAR(20) NOT NULL DEFAULT 'Active',
    full_name VARCHAR(100) NULL,
    email VARCHAR(100) NULL,
    phone VARCHAR(20) NULL
);
GO

-- Parking Slots
CREATE TABLE parking_slots (
    slot_id INT IDENTITY(1,1) PRIMARY KEY,
    slot_number VARCHAR(10) NOT NULL UNIQUE,
    vehicle_type VARCHAR(20) NOT NULL DEFAULT 'Car',
    status VARCHAR(15) NOT NULL DEFAULT 'Available'
        CHECK (status IN ('Available', 'Booked', 'Maintenance'))
);
GO

-- User Vehicles
CREATE TABLE vehicles (
    vehicle_id INT IDENTITY(1,1) PRIMARY KEY,
    user_id INT NOT NULL,
    plate_number VARCHAR(20) NOT NULL UNIQUE,
    vehicle_type VARCHAR(20) NOT NULL,
    FOREIGN KEY (user_id) REFERENCES users(user_id)
);
GO

-- Parking Entry/Exit Records
CREATE TABLE parking_records (
    record_id INT IDENTITY(1,1) PRIMARY KEY,
    vehicle_id INT NOT NULL,
    slot_id INT NOT NULL,
    entry_time DATETIME NOT NULL,
    exit_time DATETIME NULL,
    fee DECIMAL(10, 2) NULL,
    is_paid BIT NOT NULL DEFAULT 0,
    FOREIGN KEY (vehicle_id) REFERENCES vehicles(vehicle_id),
    FOREIGN KEY (slot_id) REFERENCES parking_slots(slot_id)
);
GO

-- Insert Default Accounts
INSERT INTO users (username, password, role, status, full_name, email, phone) VALUES 
('admin', 'admin', 'Admin', 'Active', 'System Administrator', 'admin@parkease.com', '01700000000'),
('john', '12345', 'User', 'Active', 'John Doe', 'john@example.com', '01711111111'),
('sampad', '12345', 'User', 'Active', 'Sampad Roy', 'sampad@example.com', '01722222222');
GO

-- Insert Default Slots
INSERT INTO parking_slots (slot_number, vehicle_type, status) VALUES
('S-01', 'Car', 'Available'),
('S-02', 'Car', 'Available'),
('S-03', 'Car', 'Available'),
('S-04', 'Car', 'Available'),
('S-05', 'Car', 'Available'),
('S-06', 'Car', 'Available'),
('S-07', 'Car', 'Available'),
('S-08', 'Car', 'Available'),
('S-09', 'Car', 'Available'),
('S-10', 'Car', 'Available'),
('A-01', 'Motorcycle', 'Available'),
('A-02', 'Motorcycle', 'Available');
GO

-- Insert Sample Vehicles (Mapped to user_id 2 and 3)
INSERT INTO vehicles (user_id, plate_number, vehicle_type) VALUES
(2, 'DHA-1234', 'Car'),
(2, 'DHA-5678', 'Bike'),
(2, 'CHT-9999', 'Car'),
(3, 'BAR-1111', 'Car');
GO

-- Verify Data Setup
SELECT user_id, username, role, status, full_name FROM users;
SELECT * FROM parking_slots;
SELECT * FROM vehicles;
SELECT * FROM parking_records;
GO