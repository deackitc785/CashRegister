using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        double burgersPrice = 3;
        double fryPrice = 2;
        double drinksPrice = 1;
        int burgersInput = 1;
        int fryInput = 1;
        int drinksInput = 1;
        double taxRate = 0.13;
        double subTotal;
        double taxAmount;
        double totalPrice;
        double tenderInput;
        double moneyAmount;


        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                burgersInput = Convert.ToInt32(burgerInput.Text);
                fryInput = Convert.ToInt32(friesInput.Text);
                drinksInput = Convert.ToInt32(drinkInput.Text);

                subTotal = (burgersPrice * burgersInput + fryPrice * fryInput + drinksPrice * drinksInput);
                taxAmount = (subTotal * taxRate);
                totalPrice = (subTotal + taxAmount);

                subtotalOutput.Text = subTotal.ToString("C");
                taxOutput.Text = taxAmount.ToString("C");
                totalOutput.Text = totalPrice.ToString("C");
            }
            catch
            {
                subtotalOutput.Text = "ERROR";
                taxOutput.Text = "";
                totalOutput.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                tenderInput = Convert.ToInt32(tenderedInput.Text);

                moneyAmount = (tenderInput - totalPrice);

                changeOutput.Text = moneyAmount.ToString("C");

            }
            catch
            {
                changeOutput.Text = "ERROR";
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {         
            printOutput.Text = $"Burger Time Inc.";
            printOutput.Text += $"\n\nOrder Number 1076\nOctober 4, 2012";
            printOutput.Text += $"\n\nHamburger   x{burgersInput} @ {burgersPrice}";
            printOutput.Text += $"\nFries   x{fryInput} @ {fryPrice}";
            printOutput.Text += $"\nDrinks   x{drinksInput} @ {drinksPrice}";
            printOutput.Text += $"\n\nSub Total    ${subTotal}";
            printOutput.Text += $"\nTax    ${taxAmount}";
            printOutput.Text += $"\nTotal    ${totalPrice}";
            printOutput.Text += $"\n\nTendered    ${tenderInput}";
            printOutput.Text += $"\nChange    ${moneyAmount}";
            printOutput.Text += $"\n\nHave a Nice Day";
        }
    }
}
          
    
