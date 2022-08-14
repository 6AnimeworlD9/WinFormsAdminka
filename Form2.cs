using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAdminka
{
    public partial class Form2 : Form
    {
        OpenFileDialog openFileDialog1;
        public string path = "";
        public Form2()
        {
            InitializeComponent();
            openFileDialog1 = new OpenFileDialog();
        }

        private void AddImgBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Выберите картинку";
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            path = openFileDialog1.FileName;
            label3.Text = openFileDialog1.FileName;

        }
    }
}
