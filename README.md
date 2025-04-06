# WinFormsManual

A simple Windows Forms application created manually using C# and Visual Studio Code (VS Code). This project demonstrates how to create a basic GUI app with a button and a message box, **without using the Visual Studio Designer**.

## 🧩 Features

- Simple Windows Form GUI
- White background form
- One button centered at `(350, 250)`
- When clicked, the button shows a message box: **"Button Clicked!"**

## 📁 Project Structure

```
WinFormsManual/
│
├── Program.cs      # Main C# code for the form and application
├── WinFormsManual.csproj
└── README.md
```

## 🚀 How to Run

1. Make sure you have installed [.NET SDK](https://dotnet.microsoft.com/download).

2. Open terminal in this project folder.

3. Run the following commands:

```bash
dotnet run
```

The application will launch with a white background form and a "Click Me!" button.


## 🧪 Code Preview

```csharp
Button button = new Button();
button.Text = "Click Me!";
button.Location = new System.Drawing.Point(350, 250);
button.Size = new System.Drawing.Size(100, 50);
button.Click += (sender, e) => MessageBox.Show("Button Clicked!");
```

## 🛠️ Requirements

- .NET SDK 6.0 or later
- Visual Studio Code (or any code editor)

## 📌 Notes

- This project does **not** use a visual UI designer.
- All UI components are created and positioned **manually via code**.

---
Created with ❤️ in VS Code @adipramanadev.
