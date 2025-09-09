# 💻 FAHVType – Smart Typing Test App

![FAHVType Logo](https://dummyimage.com/800x200/cccccc/000000&text=FAHVType+Typing+Test+App)

FAHVType is a modern typing test application built using **C# WinForms** and **SQLExpress**. It helps users improve their typing speed and accuracy through customizable and role-based features. Built with simplicity and flexibility in mind, FAHVType is perfect for students, professionals, and typing enthusiasts.

---

## 🚀 Features

### 🕒 Flexible Typing Durations
Choose your preferred test duration:
- `15 seconds`
- `30 seconds` (default)
- `60 seconds`

Switch durations easily using a ComboBox – no extra buttons required!

---

### 👤 Role-Based Access
- **User:**  
  Default role for general users. Can perform standard typing tests.

- **VVIP:**  
  Special role assigned **only by Admin** via `AdminForm`.  
  Comes with exclusive features and **1-month access limit**.

---

### ✨ VVIP Exclusive: Custom Typing Text
VVIP users can type using custom practice texts written inside a RichTextBox named `TextTypedLabel`. Ideal for focused learning and personal content input.

---

### 🔐 Secure Login & Registration
- Integrated login & registration system.
- Connected to **SQLExpress** database.
- Table: `dboLogin` with fields:
  - `username`
  - `password`
  - `type` (`User`, `VVIP`)
  - `ExpiredDate` (for VVIP)

---

## 🛠️ Built With

- **C# WinForms**
- **.NET Framework**
- **SQLExpress (LocalDB)**
- Visual Studio IDE

---

## 📂 Database Schema

**dboLogin**
| Field        | Type        | Description                  |
|--------------|-------------|------------------------------|
| username     | `VARCHAR`   | User's login name            |
| password     | `VARCHAR`   | User's password              |
| type         | `VARCHAR`   | Role (`User`, `VVIP`)        |
| ExpiredDate  | `DATETIME`  | Expiration for VVIP account  |

---

## ⚙️ How to Run

1. Clone this repository  
   `git clone https://github.com/zuckclaw/FAHVType.git`

2. Open the solution in Visual Studio

3. Set up SQLExpress and ensure the `typing_test` database exists

4. Build and run the project

---

## 🔮 Upcoming Features

- 🎨 Dark Mode
- 📊 Typing statistics (WPM, accuracy, etc.)
- 💾 Save test history
- 🔊 Sound feedback

---

## 🤝 Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you'd like to change or improve.

---

## 📧 Contact

**Made with ❤️ by Finn, Virza & Haekal**
git acc haekal : https://github.com/Muhamad-Haekal
git acc virza :

contact:
📮 Instagram: [@voenx424](https://instagram.com/voenx424)  
📮 YouTube: [Anzenity](https://youtube.com/@anzenity)

---

## ⭐ License

This project is licensed under the MIT License – see the `LICENSE` file for details.
