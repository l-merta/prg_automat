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
    public partial class Form3 : Form
    {
        private Form2 _form2;

        public Corp[] corps;
        public Corp corpData;
        public Drink drinkData;
        public int selectedCorp;
        public int selectedDrink;
        public int price;
        public bool bought;

        public Form3(Form2 form2)
        {
            InitializeComponent();

            _form2 = form2;
            corps = form2.Corps;
            selectedCorp = form2.SelectedCorp;
            selectedDrink = form2.SelectedDrink;

            corpData = corps[selectedCorp];
            drinkData = corps[selectedCorp].drinks[selectedDrink];

            price = drinkData.price;
            to_pay.Text = "Vhoďte " + price + ",-";

            corp_icon.Image = Image.FromFile(form2.GetImage(corpData.fileName, corpData.fileName));
            nadpis_2.Text = corpData.name;

            drink_icon.Image = Image.FromFile(form2.GetImage(corpData.fileName, drinkData.fileName));
            drink_price.Text = drinkData.price + ",-";
        }

        private void mince_1_Click(object sender, EventArgs e)
        {
            vhoditMinci(1);
        }
        private void mince_2_Click(object sender, EventArgs e)
        {
            vhoditMinci(2);
        }

        private void mince_5_Click(object sender, EventArgs e)
        {
            vhoditMinci(5);
        }

        private void mince_10_Click(object sender, EventArgs e)
        {
            vhoditMinci(10);
        }

        private void mince_20_Click(object sender, EventArgs e)
        {
            vhoditMinci(20);
        }

        private void mince_50_Click(object sender, EventArgs e)
        {
            vhoditMinci(50);
        }
        public void vhoditMinci(int mince)
        {
            if (!bought)
            {
                price -= mince;
                if (price > 0)
                {
                    to_pay.Text = "Vhoďte " + price + ",-";
                }
                else if (price < 0)
                {
                    MessageBox.Show("Vráceno " + Math.Abs(price) + ",-");
                    to_pay.Text = "Dobrou chuť";
                    bought = true;
                }
                else
                {
                    to_pay.Text = "Dobrou chuť";
                    bought = true;
                }
            }
        }
    }
}
