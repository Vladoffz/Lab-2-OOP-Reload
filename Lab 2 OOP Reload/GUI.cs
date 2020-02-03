using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using static System.IO.File;

namespace Lab_2_OOP_Reload
{
    public partial class GUI : Form
    {
        public GUI()
        {      
            {
                InitializeComponent();
                Text = "Program";
                this.BackColor = Color.Aquamarine;
                this.Width = 823;
                this.Height = 453;

                InitializeComponent();


                this.StartPosition = FormStartPosition.CenterScreen;

            }
    
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\Влад\source\repos\Lab 2 OOP Reload\Food.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.Default);
            string path = @"C:\Users\Влад\source\repos\Lab 2 OOP Reload\Food.txt";

            path = sr.ReadToEnd();
            char[] chm = path.ToCharArray();
            MessageBox.Show(path);
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\Влад\source\repos\Lab 2 OOP Reload\Animals.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.Default);
            string file = @"C:\Users\Влад\source\repos\Lab 2 OOP Reload\Animals.txt";

            file = sr.ReadToEnd();
            char[] chm = file.ToCharArray();
            MessageBox.Show(file);

        }

        private void GUI_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string writePath = @"C:\Users\Влад\source\repos\Lab 2 OOP Reload\Test.txt";

            Console.WriteLine("Введите строку для записи в файл:");
            string text = Console.ReadLine();
            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(text);
                }

                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(".");
                    sw.Write(4.5);
                }
                MessageBox.Show(text);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}

