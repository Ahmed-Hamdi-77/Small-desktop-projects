using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProj
{
    public partial class SubForm: Form
    {
        int NumOfPizzas = 0;
        public SubForm()
        {
            InitializeComponent();
        }

        float GetSelectedSizePrice()
        {
            if (btnSmall.Checked)
                return Convert.ToSingle(btnSmall.Tag);
            else if(btnMedium.Checked)
                return Convert.ToSingle(btnMedium.Tag);
            else 
                return Convert.ToSingle(btnLarg.Tag);
        }
        
        float CalculateCrustPrice()
        {
            if (btnThin.Checked)
                return Convert.ToSingle(btnThin.Tag);
            else
                return Convert.ToSingle(btnThick.Tag);
        }

        float CalculateToppingsPrice()
        {
            float TotalToppingPrice = 0;
            if(chkExtraCheese.Checked)
                TotalToppingPrice+= Convert.ToSingle(chkExtraCheese.Tag);

             if (chkGreenPepper.Checked)
                TotalToppingPrice += Convert.ToSingle(chkGreenPepper.Tag);

             if (chkOnion.Checked)
                TotalToppingPrice += Convert.ToSingle(chkOnion.Tag);

             if (chkOlives.Checked)
                TotalToppingPrice += Convert.ToSingle(chkOlives.Tag);

             if (chkTomatoes.Checked)
                TotalToppingPrice += Convert.ToSingle(chkTomatoes.Tag);

             if (chkMushrooms.Checked)
                TotalToppingPrice += Convert.ToSingle(chkMushrooms.Tag);

            return TotalToppingPrice;

        }

        float CalculateTotalPrice()
        {
            
                return (GetSelectedSizePrice() + CalculateCrustPrice() + CalculateToppingsPrice()) * (float)numericUpDown1.Value;
            
        }

        void UpdateTotalPrice()
        {
            lblTotalPrice.Text = "$"+CalculateTotalPrice().ToString();
        }

        void UpdateSize()
        {
            UpdateTotalPrice();

            if (btnSmall.Checked)
                lblSummarySize.Text = "Small";
            else if (btnMedium.Checked)
                lblSummarySize.Text = "Medium";
            else 
                lblSummarySize.Text = "Larg";
        }

        void UpdateCrust()
        {
            UpdateTotalPrice();

            if (btnThin.Checked)
                lblSummaryCrust.Text = "Thin Crust";
            else
                lblSummaryCrust.Text = "Thick Crust";
        }

        void UpdateToppings()
        {
            UpdateTotalPrice();
            string sToppings = "";

            if (chkExtraCheese.Checked)
                sToppings += "Extra Cheese";

            if (chkGreenPepper.Checked)
                sToppings +="," + "Green Pepper" ;

            if (chkOnion.Checked)
                sToppings +="," + "Onion";

            if (chkOlives.Checked)
                sToppings +="," + "Olives";

            if (chkTomatoes.Checked)
                sToppings +="," + "Tomatoes";

            if (chkMushrooms.Checked)
                sToppings +="," + "Mushrooms";

            if (sToppings.StartsWith(","))
                sToppings = sToppings.Substring(1, sToppings.Length - 1).Trim();

            if (sToppings == "")
                sToppings = "No Toppings";

            labelToppings.Text = sToppings;

        }

        void UpdateWhereToEat()
        {
            if (btnEatIn.Checked)
                lblSummaryWhereToEat.Text = "Eat In";
            else
                lblSummaryWhereToEat.Text = "Take away";
        }

        void UpdateOrderSummary()
        {
            UpdateCrust();
            UpdateSize();
            UpdateToppings();
            UpdateWhereToEat();
           
        }

        void ResetForm()
        {
            btnOrderPizza.Enabled = true;
            gbCrustType.Enabled = true;
            gbToppings.Enabled = true;
            gbSize.Enabled = true;
            gbWheretoEat.Enabled = true;

            btnMedium.Checked= true;

            chkExtraCheese.Checked = false;
            chkGreenPepper.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chkTomatoes.Checked = false;

            btnEatIn.Checked = true;

            numericUpDown1.Enabled = true;
            numericUpDown1.Value = 0;
            lblNumOfPizzas.Text = "0";
        }
        

       

      

       


        private void SubForm_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }
       
        private void SetNumbersOfPizzas()
        {
            float totalPrice = CalculateTotalPrice();
            lblTotalPrice.Text = "$" + totalPrice.ToString();
            lblNumOfPizzas.Text = numericUpDown1.Value.ToString();
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 0)
            {
                if (MessageBox.Show("Confirm Order", "Conferm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    MessageBox.Show("Order Placed Successfully:-)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnOrderPizza.Enabled = false;
                    gbCrustType.Enabled = false;
                    gbToppings.Enabled = false;
                    gbSize.Enabled = false;
                    gbWheretoEat.Enabled = false;
                    numericUpDown1.Enabled = false;

                }
            }
            else
            {
                
                numericUpDown1.Focus();
                errorProvider1.SetError(numericUpDown1, "Please enter the number of pizzas you want");
                
            }
                
            
        }

        private void btnSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void btnMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void btnLarg_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void btnThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void btnThick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void btnEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void btnTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkGreenPepper_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            SetNumbersOfPizzas();
            errorProvider1.SetError(numericUpDown1, "");
        }
    }
}
