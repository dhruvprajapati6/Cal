# 🧮 Cal - Professional Desktop Calculator

A clean, modern, and user-friendly desktop calculator application built with C# and Windows Forms.

## 📖 Overview
**Cal** is a lightweight, efficient desktop calculator designed for quick daily calculations. Built natively for Windows using the .NET Framework, it delivers a responsive and intuitive user experience. Whether you need to perform basic arithmetic or calculate percentages, Cal provides a reliable tool with a polished interface right on your desktop.

## ✨ Features
- **Basic Arithmetic Operations**: Addition, subtraction, multiplication, and division.
- **Percentage Calculation**: Easily compute percentages for discounts, tips, or taxes.
- **Decimal Input**: Full support for decimal numbers for precise calculations.
- **Clear & Reset**: Instantly clear the current entry or reset the entire calculation history.
- **Responsive UI**: A clean, distraction-free interface optimized for desktop use.

## ⚙️ How the Calculator Works
Cal processes mathematical operations sequentially. The user inputs numbers and operators, and the application evaluates the result dynamically or upon pressing the equals (`=`) button. Error handling is built-in to prevent issues like division by zero.

## 🖥️ User Interface and Functionality
The application features a straightforward layout:
- **Display Screen**: Shows the current input and the final result clearly.
- **Number Pad (0-9)**: Standard layout for quick data entry.
- **Operation Keys (+, -, *, /, %)**: Easily accessible on the right side or top.
- **Utility Keys**: 
  - `C` (Clear All): Resets the entire calculator.
  - `CE` (Clear Entry): Clears only the current number.
  - `.` (Decimal): For floating-point numbers.

![Cal Screenshot](screenshots/calculator.png) 
*(Note: Add screenshot to `screenshots/calculator.png`)*

## 🛠️ Technologies Used
- **Language**: C#
- **Framework**: .NET Framework 4.7.2
- **UI Technology**: Windows Forms (WinForms)
- **IDE**: Visual Studio (Recommended)

## 📥 Installation Instructions
1. Ensure you have a Windows PC.
2. Download the `.exe` file from the [Releases](https://github.com/yourusername/Cal/releases) page (if available), OR clone this repository.
3. If running from source, ensure you have the .NET Framework 4.7.2 installed on your machine.

## 🚀 How to Run the Project
To run or modify the source code:
1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/Cal.git
   ```
2. Open the solution file (`Cal.sln`) in **Visual Studio**.
3. Press `F5` or click **Start** to build and run the application.

## 💡 Example Usage
1. Open the **Cal** application.
2. Click or type `1`, `5`, `0`.
3. Click the `+` button.
4. Click or type `5`, `0`.
5. Click the `%` button (calculates 50% of 150 = 75).
6. Click the `=` button to see the final result (`225`).

## 📁 Project Structure
```text
Cal/
│
├── Properties/           # Assembly information and settings
├── Form1.cs              # Main application logic and UI events
├── Form1.Designer.cs     # Auto-generated UI layout code
├── Program.cs            # Entry point of the application
├── Cal.csproj            # Project configuration file
└── README.md             # Project documentation
```

## 🔮 Future Enhancements
- [ ] Add a history panel to view past calculations.
- [ ] Implement scientific calculator mode (trigonometry, logs, etc.).
- [ ] Add support for a Dark Mode theme.
- [ ] Add keyboard shortcut bindings for seamless typing.

## 🤝 Contributing
Contributions are always welcome! If you'd like to improve this project:
1. Fork the repository.
2. Create a new branch (`git checkout -b feature/YourFeatureName`).
3. Commit your changes (`git commit -m 'Add some feature'`).
4. Push to the branch (`git push origin feature/YourFeatureName`).
5. Open a Pull Request.

## 📄 License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 📬 Contact / Author
- **Author**: [Your Name/Handle]
- **GitHub**: [@yourusername](https://github.com/yourusername)
- **Email**: your.email@example.com
