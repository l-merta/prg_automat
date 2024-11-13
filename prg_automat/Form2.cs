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

            

            corp_icon.Image = Image.FromFile(GetImage(corps[selectedCorp].fileName, corps[selectedCorp].fileName));
            nadpis_2.Text = corps[selectedCorp].name;
            //
            drinkPic1.Image = Image.FromFile(GetImage(corps[selectedCorp].fileName, corps[selectedCorp].drinks[0].fileName));
            drinkPic2.Image = Image.FromFile(GetImage(corps[selectedCorp].fileName, corps[selectedCorp].drinks[1].fileName));
            drinkPic3.Image = Image.FromFile(GetImage(corps[selectedCorp].fileName, corps[selectedCorp].drinks[2].fileName));
            drinkPic4.Image = Image.FromFile(GetImage(corps[selectedCorp].fileName, corps[selectedCorp].drinks[3].fileName));
            drinkPic5.Image = Image.FromFile(GetImage(corps[selectedCorp].fileName, corps[selectedCorp].drinks[4].fileName));
            //
            label1.Text = corps[selectedCorp].drinks[0].price + ",-";
            label2.Text = corps[selectedCorp].drinks[1].price + ",-";
            label3.Text = corps[selectedCorp].drinks[2].price + ",-";
            label4.Text = corps[selectedCorp].drinks[3].price + ",-";
            label5.Text = corps[selectedCorp].drinks[4].price + ",-";
        }

        public string GetImage(string corpFileName, string fileName)
        {
            // Use a relative path to load an image from the 'Images' folder
            string relativePath = "images\\" + corpFileName + "_obrazky\\" + fileName + ".png";
            string absolutePath = Application.StartupPath + "\\..\\..\\" + relativePath;
            return absolutePath;
        }

        private void drinkPic2_Click(object sender, EventArgs e)
        {

        }
    }
}
