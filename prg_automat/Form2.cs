using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prg_automat
{
    public partial class Form2 : Form
    {
        private Form1 _form1;
        Corp[] corps;
        int selectedCorp = 0;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
            corps = _form1.Corps;
            selectedCorp = _form1.SelectedCorp;

            // Use a relative path to load an image from the 'Images' folder
            string relativePath = "images\\" + corps[selectedCorp].fileName + "_obrazky\\" + corps[selectedCorp].fileName + ".png";
            string absolutePath = Application.StartupPath + "\\..\\..\\" + relativePath;

            corp_icon.Image = Image.FromFile(absolutePath);
            nadpis_2.Text = corps[selectedCorp].name;
            label1.Text = corps[selectedCorp].drinks[0].wholeName;
            label2.Text = corps[selectedCorp].drinks[1].wholeName;
            label3.Text = corps[selectedCorp].drinks[2].wholeName;
            label4.Text = corps[selectedCorp].drinks[3].wholeName;
            label5.Text = corps[selectedCorp].drinks[4].wholeName;
        }
    }
}
