using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
GET the number of coffee drinkers
GET the number of tea drinkers

CALCULATE the amount of coffee required (in kg)
( = number of coffee drinkers * amount of coffee
 grounds for a cup * number of cups drunk per week)

CALCULATE the number of teabags required
( = number of tea drinkers * number of cups drunk per week)

CALCULATE the cost of the coffee for the week
( = amount of coffee required in kg * cost of 1kg coffee)

CALCULATE the cost of the tea for the week
( = number of teabags required / 100 * cost of box of tea)

CALCULATE the total weekly cost of coffee and tea
( = cost of coffee for week + cost of tea for week)
   
DISPLAY the amount of coffee required (in kg)
DISPLAY the number of teabags required
DISPLAY the cost of coffee required, formatted as currency
DISPLAY the cost of teabags required, formatted as currency
DISPLAY the cost of the weeks coffee and tea, as currency
*/


namespace Practice1
{
    public partial class Form1 : Form
    {
        //Name: Zac Pini
        //Student ID: 1266745

        //Assuming everyone drinks two cups per day for 5 days (i.e. morning and afternoon tea/coffee break)
        const int CUPS_PER_WEEK = 10;
        //Average amount of coffee grounds required to make a cup of coffee
        //Assume this is also the amount of beans required, i.e. no wastage when grinding
        const double COFFEE_GROUNDS_PER_CUP = 0.015;
        //Cost of a 1kg bag of coffee beans is $25.00
        const decimal COFFEE_COST = 25m;
        //Cost of a box of 100 teabags is $4.50
        const decimal TEA_COST = 4.50m;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }







        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //DECLARE LOCAL VARIABLES
                int numberOfCoffeeDrinkers;
                int numberofTeaDrinkers;

                decimal coffeeRequired;
                int teaBagsRequired;

                decimal costOfCoffee;
                decimal costOfTeaBags;
                decimal totalCost;

                //PARSE INPUT VALUES
                 numberOfCoffeeDrinkers = int.Parse(coffeeDrinkersTextBox.Text);
                 numberofTeaDrinkers = int.Parse(teaDrinkersTextBox.Text);

                //NUMBER OF COFFEE DRINKERS
                coffeeRequired = (decimal)numberOfCoffeeDrinkers * (decimal)COFFEE_GROUNDS_PER_CUP *(decimal)CUPS_PER_WEEK;
                //NUMBER OF TEA DRINKERS
                teaBagsRequired = numberofTeaDrinkers * CUPS_PER_WEEK;
                //COFFEE REQUIRED
                costOfCoffee = coffeeRequired * COFFEE_COST;
                //TEA_COST REQUIRED
                costOfTeaBags = (decimal)teaBagsRequired / 100 * TEA_COST;
                //TOTAL COST
                totalCost = costOfCoffee + costOfTeaBags;

                //SET OUTPUT VALUES
                coffeeRequiredTextBox.Text = coffeeRequired.ToString() + " kgs";
                teaBagsRequiredTextBox.Text = teaBagsRequired.ToString();
                costOfCoffeeTextBox.Text = costOfCoffee.ToString("c");
                costOfTeaBagsTextBox.Text = costOfTeaBags.ToString("c");
                totalCostTextBox.Text = totalCost.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            coffeeDrinkersTextBox.Clear();
            teaDrinkersTextBox.Clear(); 
            coffeeRequiredTextBox.Clear();
            teaBagsRequiredTextBox.Clear();
            costOfCoffeeTextBox.Clear();
            costOfTeaBagsTextBox.Clear();
            totalCostTextBox.Clear();   
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}










                


                




                
