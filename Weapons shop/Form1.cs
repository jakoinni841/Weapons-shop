using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Weapons_shop
{
    public partial class Window : Form
    {
        //Global Variables And Constants
        const double axe = 2.49;
        const double shield = 1.89;
        const double hammer = 3.33;
        const double sword = 0.99;
        const double tax = 0.13;

        double axeNumber = 0;
        double shieldNumber = 0;
        double swordNumber = 0;
        double hammerNumber = 0;

        double axeAmount = 0;
        double shieldAmount = 0;
        double hammerAmount = 0;
        double swordAmount = 0;

        double totalCost = 0;
        double taxAmount = 0;
        double totalAltogether = 0;

        double tenderd = 0;
        double change = 0;

        public Window()
        {
            InitializeComponent();
            newOrderButton.Visible = false;
            storeOwnerPic.Visible = false;
            errorLabel.Visible = false;
            receiptPic.Visible = false;
            calculateTotal.Visible = false;
            swordPic.Visible = false;
            axePic.Visible = false;
            hammerPic.Visible = false;
            shieldPic.Visible = false;
            title2.Visible = false;
            swordBox.Visible = false;
            shieldBox.Visible = false;
            battleaxeBox.Visible = false;
            warhammerBox.Visible = false;
            battleaxeBox.Visible = false;
            tenderdBox.Visible = false;
            swordCost.Visible = false;
            shieldCost.Visible = false;
            hammerCost.Visible = false;
            axeCost.Visible = false;
            receiptButton.Visible = false;
            changeButton.Visible = false;
            changeLabel.Visible = false;
            tenderdLabel.Visible = false;
            costText.Visible = false;
            totalLabel.Visible = false;
            taxLabel.Visible = false;
        }

        private void start_Click(object sender, EventArgs e)
        {
            //Enter The Shop
            start.Visible = false;
            title1.Visible = false;
            storeOwnerPic.Visible = true;
            calculateTotal.Visible = true;
            swordPic.Visible = true;
            axePic.Visible = true;
            hammerPic.Visible = true;
            shieldPic.Visible = true;
            title2.Visible = true;
            swordBox.Visible = true;
            shieldBox.Visible = true;
            battleaxeBox.Visible = true;
            warhammerBox.Visible = true;
            battleaxeBox.Visible = true;
            tenderdBox.Visible = true;
            swordCost.Visible = true;
            shieldCost.Visible = true;
            hammerCost.Visible = true;
            axeCost.Visible = true;
            receiptButton.Visible = true;
            changeButton.Visible = true;
            changeLabel.Visible = true;
            tenderdLabel.Visible = true;
            costText.Visible = true;
            totalLabel.Visible = true;
            taxLabel.Visible = true;
        }

        private void calculateTotal_Click(object sender, EventArgs e)
        {
            //Add Shields, Swords, Axes, and Warhammers
            try
            {
                errorLabel.Visible = false;

                axeAmount = Convert.ToDouble(battleaxeBox.Text);
                swordAmount = Convert.ToDouble(swordBox.Text);
                shieldAmount = Convert.ToDouble(shieldBox.Text);
                hammerAmount = Convert.ToDouble(warhammerBox.Text);

                axeNumber = axeAmount * axe;
                swordNumber = swordAmount * sword;
                shieldNumber = shieldAmount * shield;
                hammerNumber = hammerAmount * hammer;

                totalCost = axeNumber + swordNumber + shieldNumber + hammerNumber;
            }
            catch
            {
                errorLabel.Visible = true;
            }

            //Total Before Tax
            costText.Text = "Cost     " + Convert.ToString(totalCost.ToString("C"));
            //Tax Amount
            taxAmount = totalCost * tax;
            taxLabel.Text = "Tax       " + Convert.ToString(taxAmount.ToString("C"));
            //Total Including Tax
            totalAltogether = totalCost + taxAmount;
            totalLabel.Text = "Total   " + totalAltogether.ToString("C");
    
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                tenderd = Convert.ToDouble(tenderdBox.Text);
                change = tenderd - totalAltogether;
                changeLabel.Text = "Change " + change.ToString("C");
            }
            catch
            {
                changeLabel.Text = "Please enter an amount";
            }

        }

        private void receiptButton_Click(object sender, EventArgs e)
        {

            receiptPic.Visible = true;
            newOrderButton.Visible = true;
            storeOwnerPic.Visible = false;
            errorLabel.Visible = false;
            calculateTotal.Visible = false;
            swordPic.Visible = false;
            axePic.Visible = false;
            hammerPic.Visible = false;
            shieldPic.Visible = false;
            title2.Visible = false;
            swordBox.Visible = false;
            shieldBox.Visible = false;
            battleaxeBox.Visible = false;
            warhammerBox.Visible = false;
            battleaxeBox.Visible = false;
            tenderdBox.Visible = false;
            swordCost.Visible = false;
            shieldCost.Visible = false;
            hammerCost.Visible = false;
            axeCost.Visible = false;
            receiptButton.Visible = false;
            changeButton.Visible = false;
            changeLabel.Visible = false;
            tenderdLabel.Visible = false;
            costText.Visible = false;
            totalLabel.Visible = false;
            taxLabel.Visible = false;
            calculateTotal.Visible = false;
            swordPic.Visible = false;
            axePic.Visible = false;
            hammerPic.Visible = false;
            shieldPic.Visible = false;
            title2.Visible = false;
            swordBox.Visible = false;
            shieldBox.Visible = false;
            battleaxeBox.Visible = false;
            warhammerBox.Visible = false;
            battleaxeBox.Visible = false;
            tenderdBox.Visible = false;
            swordCost.Visible = false;
            shieldCost.Visible = false;
            hammerCost.Visible = false;
            axeCost.Visible = false;
            receiptButton.Visible = false;
            changeButton.Visible = false;
            changeLabel.Visible = false;
            tenderdLabel.Visible = false;
            costText.Visible = false;
            totalLabel.Visible = false;
            taxLabel.Visible = false;

            Refresh();

            Graphics fg = receiptPic.CreateGraphics();
            Font drawFont = new Font("Consolas", 14, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            fg.DrawString("Angus's Weapon Shop", drawFont, drawBrush, 55, 50);
            fg.DrawString("Order Number 1000", drawFont, drawBrush, 55, 65);
            fg.DrawString("Oct 13, 2016", drawFont, drawBrush, 55, 80);

            fg.DrawString("Swords   " + swordAmount + " @ " + sword, drawFont, drawBrush, 55, 110);
            fg.DrawString("Shields  " + shieldAmount + " @ " + shield, drawFont, drawBrush, 55, 125);
            fg.DrawString("Axes     " + axeAmount + " @ " + axe, drawFont, drawBrush, 55, 140);
            fg.DrawString("Hammers  " + hammerAmount + " @ " + hammer, drawFont, drawBrush, 55, 155);

            fg.DrawString("Cost     " + totalCost.ToString("C"), drawFont, drawBrush, 55, 185);
            fg.DrawString("Tax      " + taxAmount.ToString("C"), drawFont, drawBrush, 55, 200);
            fg.DrawString("Total    " + totalAltogether.ToString("C"), drawFont, drawBrush, 55, 215);

            fg.DrawString("Tenderd  " + tenderd.ToString("C"), drawFont, drawBrush, 55, 245);
            fg.DrawString("Change   " + change.ToString("C"), drawFont, drawBrush, 55, 260);

            fg.DrawString("Have a great day :)", drawFont, drawBrush, 55, 285);

        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {

            Refresh();

            receiptPic.Visible = true;
            newOrderButton.Visible = true;
            storeOwnerPic.Visible = true;
            calculateTotal.Visible = true;
            swordPic.Visible = true;
            axePic.Visible = true;
            hammerPic.Visible = true;
            shieldPic.Visible = true;
            title2.Visible = true;
            swordBox.Visible = true;
            shieldBox.Visible = true;
            battleaxeBox.Visible = true;
            warhammerBox.Visible = true;
            battleaxeBox.Visible = true;
            tenderdBox.Visible = true;
            swordCost.Visible = true;
            shieldCost.Visible = true;
            hammerCost.Visible = true;
            axeCost.Visible = true;
            receiptButton.Visible = true;
            changeButton.Visible = true;
            changeLabel.Visible = true;
            tenderdLabel.Visible = true;
            costText.Visible = true;
            totalLabel.Visible = true;
            taxLabel.Visible = true;
        }
    }
}
