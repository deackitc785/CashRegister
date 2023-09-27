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
        double burgersPrice = 3.25;
        double fryPrice = 2.25;
        double drinksprice = 1.25;
        int burgersInput = 1;
        int fryInput = 1;
        int drinksInput = 1;
        double taxRate = 0.13;
        double subTotal;
        double taxAmount;
        double totalPrice;




        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                burgersInput = Convert.ToInt32(burgerInput.Text);
                fryPrice = Convert.ToInt32(friesInput.Text);
                drinksprice = Convert.ToInt32(drinkInput.Text);

                subTotal = (burgersPrice * burgersInput + fryPrice * fryInput + drinksprice * drinksInput);
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
    }
}