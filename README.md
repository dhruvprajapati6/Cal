<div align="center">
  <h1>🧮 Cal - Professional Desktop Calculator</h1>
  <p>A vibrant, feature-rich, and visually striking desktop calculator built with C# and Windows Forms.</p>
  
  <!-- ANIMATION TIP: Replace the image below with a .gif of your calculator working! -->
  <img src="screenshot.png" alt="Calculator Interface" width="600" />
</div>

<br />

## 🌟 Overview
**Cal** is not just an ordinary calculator; it's designed to bring efficiency and style to your daily calculations. With its striking blue interface, neatly categorized color-coded buttons, and intuitive display, it provides a seamless user experience.

## ⌨️ Interactive Button Guide

Cal's interface is divided into logical sections. Here is exactly how every button works:

### 🔢 Number Pad (Gray Buttons)
The primary input area for your calculations.
| | | |
|:---:|:---:|:---:|
| <kbd>7</kbd> | <kbd>8</kbd> | <kbd>9</kbd> |
| <kbd>4</kbd> | <kbd>5</kbd> | <kbd>6</kbd> |
| <kbd>1</kbd> | <kbd>2</kbd> | <kbd>3</kbd> |
| <kbd>0</kbd> | <kbd>00</kbd>| <kbd>.</kbd> |

- **`0-9`**: Standard numeric inputs.
- **`00`**: Quick double-zero entry to speed up typing large numbers (like 100 or 5000).
- **`.`** : Decimal point for precise floating-point math.

### ➕ Basic Operators (Cyan Buttons)
Used for standard mathematical operations.
- <kbd>/</kbd> **Divide**: Divides the first number by the second.
- <kbd>*</kbd> **Multiply**: Multiplies two numbers (e.g., `5000 * 5`).
- <kbd>-</kbd> **Subtract**: Subtracts the second number from the first.
- <kbd>+</kbd> **Add**: Adds numbers together.

### ✨ Special Functions (Purple & Yellow)
- <kbd>%</kbd> **Percentage**: Quickly calculates the percentage value.
- <kbd>√</kbd> **Square Root**: Instantly finds the square root of the number on the screen.
- <kbd>=</kbd> **Equals (Yellow)**: The magic button! Computes your entire equation and displays the final result.

### 🔙 Control Keys (Orange & Red)
Made a mistake? No problem.
- <kbd>BKSP</kbd> **(Backspace - Orange)**: Deletes just the last entered digit. Perfect for quick corrections without starting over.
- <kbd>C</kbd> **(Clear - Red)**: Wipes the entire screen and memory, giving you a fresh start.

## 🚀 How It Works (The Logic)
1. **Input & Display**: As you click buttons, the main white screen at the top dynamically displays your ongoing equation (for example, `5000*5` as seen in the screenshot).
2. **Real-time Updates**: The display handles complex strings of numbers and operators smoothly.
3. **Execution**: Pressing <kbd>=</kbd> parses the string, follows the mathematical order of operations, and outputs the accurate result instantly.

## 🛠️ Technical Specifications
- **Language**: C#
- **Framework**: .NET Framework (Windows Forms)
- **Design**: Custom colored flat-UI design.

## 📥 Getting Started
1. Clone the repository to your local machine:
   ```bash
   git clone https://github.com/dhruvprajapati6/Cal.git
   ```
2. Open the project in **Visual Studio**.
3. Hit `F5` to build and launch the beautifully designed calculator!

<br />

<div align="center">
  <b>Designed with ❤️ for effortless calculations.</b>
</div>
