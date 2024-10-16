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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_sprite_Click(object sender, EventArgs e)
        {
            Napoj piti = new Napoj("sprite", "", 20);
            piti.vypit();
        }
    }

    class Napoj
    {
        string corp;
        string name;
        string wholeName;
        decimal price;

        public Napoj(string corp, string name, decimal price)
        {
            this.corp = corp;
            this.name = name;
            this.wholeName = corp + (name.Length > 0 ? " " : "") + name;
            this.price = price;
        }
        public void vypit()
        {
            MessageBox.Show("pití " + this.wholeName + " bylo vypito");
        }
    }
}
