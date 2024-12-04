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
    public partial class Form4 : Form
    {
        private Form2 _form2;

        public Corp[] corps;
        public Corp corpData;
        public Drink drinkData;
        public int selectedCorp;
        public int selectedDrink;
        public bool bought;

        public Form4(Form2 form2)
        {
            InitializeComponent();

            _form2 = form2;
            corps = form2.Corps;
            selectedCorp = form2.SelectedCorp;
            selectedDrink = form2.SelectedDrink;

            corpData = corps[selectedCorp];
            drinkData = corps[selectedCorp].drinks[selectedDrink];

            corp_icon.Image = Image.FromFile(form2.GetImage(corps[selectedCorp].fileName, corps[selectedCorp].fileName));
            nadpis_2.Text = corps[selectedCorp].name;

            drink_icon.Image = Image.FromFile(form2.GetImage(corpData.fileName, drinkData.fileName));
            drink_price.Text = drinkData.price + ",-";
        }

        private void pay_button_Click(object sender, EventArgs e)
        {
            if (!bought)
            {
                to_pay.Text = "Dobrou chuť";
                bought = true;
            }
            else
            {
                to_pay.Text = "Jděte pryč";
            }
        }
    }
}
