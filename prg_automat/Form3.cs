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
        public int selectedCorp;
        public int selectedDrink;

        public Form3(Form2 form2)
        {
            InitializeComponent();

            _form2 = form2;
            corps = form2.Corps;
            selectedCorp = form2.SelectedCorp;
            selectedDrink = form2.SelectedDrink;

            MessageBox.Show(corps[selectedCorp].name + " - " + corps[selectedCorp].drinks[selectedDrink].name);
        }
    }
}
