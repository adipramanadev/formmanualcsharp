using System;
using System.Windows.Forms;
namespace WinFormsManual;

public class MainForm : Form
{
    public MainForm()
    {
       // membuat form program c# dengan VS Code
        this.BackColor = System.Drawing.Color.White;

        //add button 
        Button button = new Button();
        button.Text = "Click Me!";
        button.Location = new System.Drawing.Point(350, 250);
        button.Size = new System.Drawing.Size(100, 50);
        button.Click += (sender, e) => MessageBox.Show("Button Clicked!");
        this.Controls.Add(button);
        Text = "Main Form - WinForms Manual";
        StartPosition = FormStartPosition.CenterScreen;
        Width = 800;
        Height = 600;
    }
}
static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }
}