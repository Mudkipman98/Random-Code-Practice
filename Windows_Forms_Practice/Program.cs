using System.Windows.Forms;
using System;




static void Main(string[] args)
{
    Console.WriteLine("Hello, World!");
}

void MakeForm()
{
    Form form1 = new Form();
    Button button1 = new Button();
    button1.Text = "Okay";
    button1.Position = new Point(10, 10);
    form1.Text = "This is a test form";
    form1.MaximizeBox = false;
    form1.MinimizeBox = false;
    form1.CancelButton = button1;
    form1.StartPosition = FormStartPosition.CenterScreen;
    form1.Controls.Add(button1);
    form1.ShowDialog();
}