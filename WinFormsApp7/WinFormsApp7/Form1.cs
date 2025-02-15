using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        private string imageFile = @"C:\Users\lavro\OneDrive\e (2)\images.jpg";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowImage();
        }

        private void ShowImage()
        {
            if (File.Exists(imageFile))
            {
                pictureBox1.Image = Image.FromFile(imageFile);
            }
            else
            {
                MessageBox.Show("Зображення не знайдено.");
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            ShowImage();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            ShowImage();
        }
    }
}
