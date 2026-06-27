# SmartMed Pharmacy Management ERP System

SmartMed is a desktop-based Pharmacy Management ERP System developed using **C# Windows Forms** and **Microsoft SQL Server**. The system is designed to support pharmacy operations such as medicine inventory control, customer registration, cart and checkout, prescription handling, order tracking, invoice generation, reporting, audit logging, role-based access control, and customer loyalty management.

This project was developed as an academic software engineering coursework project using object-oriented programming, layered architecture, repository pattern, service layer separation, and secure authentication practices.

---

## Project Overview

SmartMed provides a complete desktop ERP solution for managing pharmacy workflows. The system supports multiple user roles including Super Admin, Admin and Customer. Admin users can manage medicines, categories, suppliers, customers, orders, prescriptions, reports and audit logs. Customers can register, search medicines, manage a cart, checkout, track orders, view invoices and earn loyalty points.

---

## Main Features

### Authentication and Authorization

* Secure login system
* PBKDF2 password hashing
* Role-based access control
* Super Admin, Admin and Customer roles
* Active and inactive account status handling
* Session management
* Logout with audit logging

### Super Admin Features

* Create admin users
* Reset admin passwords
* Activate or deactivate admin accounts
* View audit logs
* Restrict sensitive modules from normal Admin users

### Admin Features

* Admin dashboard with summary statistics
* Medicine inventory management
* Category management
* Supplier management
* Customer management
* Order management
* Prescription verification
* Payment status update
* Reports and analytics
* Invoice viewing and PDF export
* Low stock alerts
* Medicine expiry alerts

### Customer Features

* Customer registration
* Customer login
* Customer dashboard
* Profile update
* Password change
* Medicine search
* Add medicines to cart
* Update cart quantity
* Remove cart items
* Checkout with delivery details
* Prescription upload
* Order tracking
* Invoice viewing
* Loyalty points and membership level display

### Inventory Management

* Add, update and delete medicines
* Medicine category and supplier linking
* Batch number tracking
* Manufacture and expiry date tracking
* Stock quantity tracking
* Reorder level tracking
* Prescription required flag
* Barcode and QR code fields
* Soft delete for medicines
* Low stock detection
* Expiry alert detection

### Order and Checkout

* Persistent customer cart
* Stock validation before checkout
* Discount calculation
* Tax calculation
* Delivery fee calculation
* Grand total calculation
* Delivery method and delivery note support
* Payment method and payment status support
* Prescription upload for required medicines
* Order status tracking

### Prescription Handling

* Prescription required medicine detection
* Prescription file upload
* Admin prescription review
* Prescription approval and rejection
* Admin note support
* Verified by and verified date tracking

### Reporting and Analytics

* Sales report
* Inventory report
* Low stock report
* Expiry report
* PDF export support
* Admin dashboard statistics

### Audit Logging

* Login logging
* Logout logging
* Admin actions logging
* Customer actions logging
* Order actions logging
* Prescription actions logging
* Machine name tracking
* User role tracking
* Date and time tracking

### Customer Loyalty Programme

* Customers earn points after successful orders
* Rs. 100 spent equals 1 point
* Minimum 1 point for a valid order
* Membership levels:

  * Bronze
  * Silver
  * Gold
  * Platinum
* Loyalty points shown in customer dashboard and profile

---

## Technologies Used

| Technology                   | Purpose                             |
| ---------------------------- | ----------------------------------- |
| C#                           | Main programming language           |
| Windows Forms                | Desktop application interface       |
| .NET Framework               | Application framework               |
| Microsoft SQL Server         | Database management                 |
| ADO.NET                      | Database connectivity               |
| Guna UI                      | Modern user interface components    |
| iTextSharp                   | PDF invoice and report export       |
| Visual Studio                | Development environment             |
| SQL Server Management Studio | Database design and management      |
| GitHub                       | Version control and project hosting |

---

## System Architecture

The project follows a layered architecture to separate responsibilities clearly.

```text
SmartMedERP
│
├── Data
│   └── Database connection class
│
├── Models
│   └── Entity/model classes
│
├── Repositories
│   └── Database access logic
│
├── Services
│   └── Business logic
│
├── Utilities
│   └── Helper classes such as password hashing
│
├── Forms
│   └── Windows Forms user interface
│
└── Program.cs
    └── Application entry point
```

---

## Project Folder Structure

```text
SmartMedERP-Pharmacy-Management-System
│
├── Assets
│   └── Images and UI assets
│
├── Data
│   └── Database.cs
│
├── Forms
│   └── Login, dashboard, inventory, customer, order and report forms
│
├── Models
│   └── User, Customer, Medicine, Order, Cart and related models
│
├── Repositories
│   └── SQL database operation classes
│
├── Services
│   └── Authentication, customer, cart, order, loyalty and audit services
│
├── Utilities
│   └── PasswordHasher.cs
│
├── Database
│   └── SmartMedDB.sql
│
├── App.config
├── Program.cs
├── SmartMedERP.csproj
├── SmartMedERP.sln
├── packages.config
└── README.md
```

---

## Database Setup

### Step 1: Open SQL Server Management Studio

Open SSMS and connect to your SQL Server instance.

Example:

```text
DESKTOP-I9S2DH0\SQLEXPRESS
```

### Step 2: Run Database Script

Open the SQL script:

```text
Database/SmartMedDB.sql
```

Run the script to create the database, tables, relationships and sample data.

### Step 3: Check Database Name

The database should be named:

```text
SmartMedDB
```

### Step 4: Update Connection String

Open:

```text
Data/Database.cs
```

Update the SQL Server name if needed:

```csharp
private static readonly string ConnectionString =
    @"Server=YOUR_SERVER_NAME;
      Database=SmartMedDB;
      Trusted_Connection=True;
      TrustServerCertificate=True;";
```

---

## How to Run the Project

1. Clone the repository.

```bash
git clone https://github.com/MaleeshaDewmina/SmartMedERP-Pharmacy-Management-System.git
```

2. Open the solution file in Visual Studio.

```text
SmartMedERP.sln
```

3. Restore NuGet packages if required.

4. Run the database script in SSMS.

5. Update the connection string in `Data/Database.cs`.

6. Build the solution.

```text
Build > Rebuild Solution
```

7. Run the application.

```text
Start
```

---

## User Roles

| Role        | Access Level                                                      |
| ----------- | ----------------------------------------------------------------- |
| Super Admin | Full access including admin user management and audit logs        |
| Admin       | Access to inventory, customers, orders, reports and prescriptions |
| Customer    | Access to medicine search, cart, checkout, profile and orders     |

---

## Screenshot Placeholders

```text
docs/screenshots/
```

### Login Form

![Login Form](docs/screenshots/login-form.png)

### Admin Dashboard

![Admin Dashboard](docs/screenshots/admin-dashboard.png)

### Customer Dashboard

![Customer Dashboard](docs/screenshots/customer-dashboard.png)

### Medicine Management

![Medicine Management](docs/screenshots/medicine-management.png)

### Category Management

![Category Management](docs/screenshots/category-management.png)

### Supplier Management

![Supplier Management](docs/screenshots/supplier-management.png)

### Customer Management

![Customer Management](docs/screenshots/customer-management.png)

### Customer Medicine Search

![Customer Medicine Search](docs/screenshots/customer-medicine-search.png)

### Customer Cart

![Customer Cart](docs/screenshots/customer-cart.png)

### Checkout Form

![Checkout Form](docs/screenshots/checkout-form.png)

### My Orders

![My Orders](docs/screenshots/my-orders.png)

### Admin Order Management

![Admin Order Management](docs/screenshots/admin-order-management.png)

### Invoice View

![Invoice View](docs/screenshots/invoice-view.png)

### Invoice PDF Export

![Invoice PDF Export](docs/screenshots/invoice-pdf-export.png)

### Reports

![Reports](docs/screenshots/reports.png)

### Audit Logs

![Audit Logs](docs/screenshots/audit-logs.png)

### Database Tables

![Database Tables](docs/screenshots/database-tables.png)

---

## Important Database Tables

| Table      | Purpose                                     |
| ---------- | ------------------------------------------- |
| Users      | Stores login account details                |
| Roles      | Stores system roles                         |
| UserRoles  | Maps users to roles                         |
| Customers  | Stores customer profile and loyalty details |
| Categories | Stores medicine categories                  |
| Suppliers  | Stores supplier details                     |
| Medicines  | Stores medicine inventory details           |
| CartItems  | Stores customer cart items                  |
| Orders     | Stores order header details                 |
| OrderItems | Stores medicines inside each order          |
| AuditLogs  | Stores user activity logs                   |

---

## Security Features

* Passwords are not stored in plain text
* PBKDF2 password hashing is used
* Parameterized SQL queries are used to reduce SQL injection risk
* Role-based access control is implemented
* Inactive accounts cannot log in
* Super Admin-only access is used for sensitive modules
* Audit logs are recorded for important system actions

---

## Object-Oriented Programming Concepts Used

### Classes and Objects

The system uses classes such as `User`, `Customer`, `Medicine`, `Order`, `OrderItem`, `CartItem`, `CustomerService`, `OrderService` and repository classes.

### Encapsulation

Model properties and service methods encapsulate system data and behavior.

### Abstraction

Repository classes hide database operation details from forms.

### Separation of Concerns

Forms handle user interface logic, services handle business logic, repositories handle database access and models represent data.

### Reusability

Common logic such as password hashing, authentication, audit logging, cart handling and order calculations is separated into reusable classes.

---

## Design Patterns Used

### Repository Pattern

Repository classes are used to separate SQL database operations from the user interface.

Examples:

```text
CustomerRepository
MedicineRepository
OrderRepository
CartRepository
AuditLogRepository
DashboardRepository
```

### Service Layer Pattern

Service classes are used to keep business logic separate from forms.

Examples:

```text
AuthenticationService
CustomerService
OrderService
CartService
LoyaltyService
AuditLogService
```

### Session Management

`SessionManager` stores the currently logged-in user details and allows forms to access the active user session.

---

## Example Workflow

### Customer Order Workflow

```text
Customer Login
      ↓
Search Medicines
      ↓
Add Medicines to Cart
      ↓
Checkout
      ↓
Upload Prescription if Required
      ↓
Place Order
      ↓
Admin Reviews Order
      ↓
Prescription Approved or Rejected
      ↓
Order Status Updated
      ↓
Customer Tracks Order
      ↓
Invoice Generated
```

---

## Future Improvements

* Email notification support
* SMS notification support
* Online payment gateway integration
* Barcode scanner integration
* Advanced stock forecasting
* Multi-branch pharmacy support
* Backup and restore module
* More advanced analytics dashboard

---

## Academic Purpose

This project was developed for academic coursework to demonstrate:

* Object-oriented programming
* Windows Forms application development
* SQL Server database integration
* Secure authentication
* Layered software architecture
* CRUD operations
* Report generation
* Audit logging
* Role-based access control
* Real-world pharmacy ERP workflow design

---

## Developer

Developed as a software engineering academic project by Maleesha Dewmina.

Project Name:

```text
SmartMed Pharmacy Management ERP System
```

Technology Stack:

```text
C# Windows Forms, SQL Server, ADO.NET, .NET Framework
```

---

## License

This project was developed for educational and portfolio purposes as part of the BEng (Hons) Software Engineering - Top-up programme.

---

##Author

Maleesha Dewmina

BEng (Hons) Software Engineering - Top-up Student

GitHub: https://github.com/MaleeshaDewmina
