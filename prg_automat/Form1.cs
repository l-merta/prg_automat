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
            corps[0].newDrink("", 28);
            corps[0].newDrink("Zero", 28);
            corps[0].newDrink("Lemon", 30);
            corps[0].newDrink("Grape", 30);
            corps[0].newDrink("Exotic", 30);
            // Coca Cola
            corps[1] = new Corp("Coca Cola");
            corps[1].newDrink("", 28);
            corps[1].newDrink("Zero", 28);
            corps[1].newDrink("Cherry", 30);
            corps[1].newDrink("Vanilla", 30);
            corps[1].newDrink("Oreo", 32);
            // Sprite
            corps[2] = new Corp("Sprite");
            corps[2].newDrink("", 28);
            corps[2].newDrink("Cranberry", 35);
            corps[2].newDrink("Peach", 30);
            corps[2].newDrink("Raspberry", 30);
            corps[2].newDrink("Strawberry", 30);
            // Fuze Tea
            corps[3] = new Corp("Fuze Tea");
            corps[3].newDrink("Forest Fruit", 28);
            corps[3].newDrink("Lemon and Lemongrass", 28);
            corps[3].newDrink("Mango and Pineapple", 28);
            corps[3].newDrink("Peach and Hibicus", 28);
            corps[3].newDrink("Strawberry and Aloe Vera", 28);
            // Minute Maid
            corps[4] = new Corp("Minute Maid");
            corps[4].newDrink("Apple", 25);
            corps[4].newDrink("Multivitamin", 25);
            corps[4].newDrink("Orange", 25);
            corps[4].newDrink("Pink Lemonade", 25);
            corps[4].newDrink("Watermelon Punch", 25);
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

        private void nadpis_1_Click(object sender, EventArgs e)
        {

        }
    }

    public class Corp
    {
        public string name;
        public string fileName;
        public List<Drink> drinks;

        public Corp(string name)
        {
            drinks = new List<Drink>();
            this.name = name;
            this.fileName = ConvertToSnakeCase(name);
        }
        public void newDrink(string name, int price)
        {
            Drink newDrink = new Drink(this, name, price);
            drinks.Add(newDrink);
        }
        public static string ConvertToSnakeCase(string input)
        {
            // Convert to lowercase
            string lowercase = input.ToLower();

            // Replace spaces with underscores
            string snakeCase = lowercase.Replace(" ", "_");

            // Optionally, remove or replace other characters if needed
            // For example, you can remove non-alphabetical characters (if any)
            // snakeCase = Regex.Replace(snakeCase, @"[^a-z0-9_]", "");

            return snakeCase;
        }
    }
    public class Drink
    {
        public Corp corp;
        public string name;
        public string fileName;
        public string wholeName;
        public int price;

        public Drink(Corp corp, string name, int price)
        {
            this.corp = corp;
            this.name = name;
            this.wholeName = corp.name + (name.Length > 0 ? " " : "") + name;
            this.fileName = ConvertToSnakeCase(this.wholeName);
            this.price = price;
        }
        public int vhoditMinci(int currentPrice, int mince)
        {
            return currentPrice - mince;
        }
        public static string ConvertToSnakeCase(string input)
        {
            // Convert to lowercase
            string lowercase = input.ToLower();

            // Replace spaces with underscores
            string snakeCase = lowercase.Replace(" ", "_");

            // Optionally, remove or replace other characters if needed
            // For example, you can remove non-alphabetical characters (if any)
            // snakeCase = Regex.Replace(snakeCase, @"[^a-z0-9_]", "");

            return snakeCase;
        }
    }
}
