# 🏦 Parabank Automation - Login Flow (SDET Assignment)

## 📌 Project Overview
This project is developed as part of an SDET take-home assignment.  
It automates the Login functionality of the Parabank demo application using Selenium with C#.

---

## 🌐 Application Under Test
https://parabank.parasoft.com/

---

## 🛠️ Tech Stack
- Language: C#
- Framework: .NET 8
- Automation Tool: Selenium WebDriver
- Test Framework: NUnit
- Assertion Library: FluentAssertions

---

## 🧱 Framework Design

This project follows a clean and scalable automation framework design:

- Page Object Model (POM)
- Base Test class for browser setup and teardown
- Explicit waits (WebDriverWait) for synchronization
- Reusable methods for maintainability

### 📁 Project Structure
│
├── Base
│ └── BaseTest.cs
│
├── Pages
│ └── LoginPage.cs
│
├── Tests
│ └── LoginTests.cs
│
├── Utilities


---

## 🧪 Test Scenarios Covered

### ✅ Positive Test
- Login with valid username and password

### ❌ Negative Tests
- Login with empty username and password
- Login with only username
- Login with only password

---

## 🔍 Observations

- The application allows login with any non-empty username and password
- There is no validation for incorrect credentials
- Validation is implemented only for empty fields
- Error message displayed:
  "Please enter a username and password."

---

## ⚙️ Setup Instructions

1. Install Visual Studio 2022
2. Install .NET 8 SDK
3. Install the following NuGet packages:
   - Selenium.WebDriver
   - Selenium.WebDriver.ChromeDriver
   - Selenium.Support
   - NUnit
   - FluentAssertions

---

## ▶️ How to Run the Tests

1. Open the solution in Visual Studio
2. Build the solution
3. Go to Test Explorer
4. Click on "Run All Tests"

---

## 🚀 Automation Approach

- Designed using Page Object Model for better maintainability
- Implemented BaseTest class for driver initialization and cleanup
- Used explicit waits to handle synchronization issues
- Used FluentAssertions for readable and robust assertions

---

## ⚠️ Assumptions

- The application is a demo version with simplified authentication
- UI elements remain stable during execution
- No backend validation is implemented

---

## 👨‍💻 Author

**Ajay Khairnar**