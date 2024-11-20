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
        int selectedDrink = -1;

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
        public int SelectedCorp
        {
            get { return selectedCorp; }
        }
        public Corp[] Corps
        {
            get { return corps; }
        }
        public int SelectedDrink
        {
            get { return selectedDrink; }
        }

        public string GetImage(string corpFileName, string fileName)
        {
            // Use a relative path to load an image from the 'Images' folder
            string relativePath = "images\\" + corpFileName + "_obrazky\\" + fileName + ".png";
            string absolutePath = Application.StartupPath + "\\..\\..\\" + relativePath;
            return absolutePath;
        }

        private void drinkPic1_Click(object sender, EventArgs e)
        {
            selectedDrink = 0;
            drinkPicClick(sender);
        }

        private void drinkPic2_Click(object sender, EventArgs e)
        {
            selectedDrink = 1;
            drinkPicClick(sender);
        }

        private void drinkPic3_Click(object sender, EventArgs e)
        {
            selectedDrink = 2;
            drinkPicClick(sender);
        }

        private void drinkPic4_Click(object sender, EventArgs e)
        {
            selectedDrink = 3;
            drinkPicClick(sender);
        }

        private void drinkPic5_Click(object sender, EventArgs e)
        {
            selectedDrink = 4;
            drinkPicClick(sender);
        }

        public void drinkPicClick(object sender)
        {
            // Assuming the sender is a PictureBox, you can cast it
            PictureBox drinkButton = sender as PictureBox;

            if (drinkButton != null)
            {
                drinkPic1.BorderStyle = BorderStyle.None;
                drinkPic2.BorderStyle = BorderStyle.None;
                drinkPic3.BorderStyle = BorderStyle.None;
                drinkPic4.BorderStyle = BorderStyle.None;
                drinkPic5.BorderStyle = BorderStyle.None;

                drinkButton.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void platbaButton1_Click(object sender, EventArgs e)
        {
            if (selectedDrink >= 0)
            {
                Form3 form3 = new Form3(this);
                form3.Show();
            }
        }
    }
}
