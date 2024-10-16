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
        private Corp[] corps;
        private int selectedCorp = 0;

        public Form1()
        {
            InitializeComponent();

            corps = new Corp[5];
            // Fanta
            corps[0] = new Corp("Fanta");
            corps[0].newDrink("", 20);
            corps[0].newDrink("Zero", 20);
            corps[0].newDrink("Lemon", 20);
            corps[0].newDrink("Grape", 20);
            corps[0].newDrink("Exotic", 20);
            // Coca Cola
            corps[1] = new Corp("Coca Cola");
            corps[1].newDrink("", 20);
            corps[1].newDrink("Zero", 20);
            corps[1].newDrink("Cherry", 20);
            corps[1].newDrink("Vanilla", 20);
            corps[1].newDrink("Oreo", 20);
            // Sprite
            corps[2] = new Corp("Sprite");
            corps[2].newDrink("", 20);
            corps[2].newDrink("Cranberry", 20);
            corps[2].newDrink("Peach", 20);
            corps[2].newDrink("Raspberry", 20);
            corps[2].newDrink("Strawberry", 20);
            // Fuze Tea
            corps[3] = new Corp("Fuze Tea");
            corps[3].newDrink("Forest Fruit", 20);
            corps[3].newDrink("Lemon and Lemongrass", 20);
            corps[3].newDrink("Mango and Pineapple", 20);
            corps[3].newDrink("Peach and Hibicus", 20);
            corps[3].newDrink("Strawberry and Aloe Vera", 20);
            // Minute Maid
            corps[4] = new Corp("Minute Maid");
            corps[4].newDrink("Apple", 20);
            corps[4].newDrink("Multivitamin", 20);
            corps[4].newDrink("Orange", 20);
            corps[4].newDrink("Pink Lemonade", 20);
            corps[4].newDrink("Watermelon Punch", 20);

        }

        public Corp[] Corps
        {
            get { return corps; }
        }
        public int SelectedCorp
        {
            get { return selectedCorp; }
        }

        /// Main corp buttons
        private void button_fanta_Click(object sender, EventArgs e)
        {
            selectedCorp = 0;

            Form2 form2 = new Form2(this);
            form2.Show();
        }
        private void button_cola_Click(object sender, EventArgs e)
        {
            selectedCorp = 1;

            Form2 form2 = new Form2(this);
            form2.Show();
        }
        private void button_sprite_Click(object sender, EventArgs e)
        {
            selectedCorp = 2;

            Form2 form2 = new Form2(this);
            form2.Show();
        }
        private void button_fuze_tea_Click(object sender, EventArgs e)
        {
            selectedCorp = 3;

            Form2 form2 = new Form2(this);
            form2.Show();
        }
        private void button_minute_maid_Click(object sender, EventArgs e)
        {
            selectedCorp = 4;

            Form2 form2 = new Form2(this);
            form2.Show();
        }
    }

    public class Corp
    {
        public string name;
        public List<Drink> drinks;

        public Corp(string name)
        {
            drinks = new List<Drink>();
            this.name = name;
        }
        public void newDrink(string name, decimal price)
        {
            Drink newDrink = new Drink(this, name, price);
            drinks.Add(newDrink);
        }
    }
    public class Drink
    {
        public Corp corp;
        public string name;
        public string wholeName;
        public decimal price;

        public Drink(Corp corp, string name, decimal price)
        {
            this.corp = corp;
            this.name = name;
            this.wholeName = corp.name + (name.Length > 0 ? " " : "") + name;
            this.price = price;
        }
        public void vypit()
        {
            MessageBox.Show("pití " + this.wholeName + " bylo vypito");
        }
    }
}
