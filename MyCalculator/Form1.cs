using Guna.UI2.WinForms.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFirstClassLibrary;

namespace MyCalculator
{
    public partial class Form1: Form
    {
        [DllImport("dwmapi", PreserveSig = false)]
        static extern void DwmSetWindowAttribute(IntPtr hwnd, int dwAttribute, in bool pvAttribute, int cbAttribute);

        protected override void OnHandleCreated(EventArgs e)
        {
            const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;
            DwmSetWindowAttribute(Handle, DWMWA_USE_IMMERSIVE_DARK_MODE, true, Marshal.SizeOf<bool>());
        }
        
        

        private decimal FrstNumber=0;
        private decimal ScndNumber=0;
        private string result;
        private string Operation = "";
        public Form1()
        {
            InitializeComponent();
            

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length>0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            if (textBox1.Text=="")
            {
                textBox1.Text = "0";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBoxDis.Text = "";
        }

        private void PosOrMinbtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(-1 * double.Parse(textBox1.Text));
        }

        private void Dotbtn_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
        }

        private void Fourbtn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textBox1.Text=="0")
            {
                textBox1.Text = button.Text;
            }
            else
            {
                textBox1.Text += button.Text;
            }
        }

        private void Subbtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "!")
            {
                textBox1.Text = "0";
            }
            else
            {

                try
                {
                    FrstNumber = Convert.ToDecimal(textBox1.Text);
                    Button button = (Button)sender;
                    Operation = button.Text;
                    textBoxDis.Text = $"{FrstNumber.ToString()} {Operation}";
                    textBox1.Text = "0";

                }
                catch (System.OverflowException)
                {
                    MessageBox.Show("The number is too long", "Error");
                }

            }
        }

        private void Equalbtn_Click(object sender, EventArgs e)
        {
            ScndNumber = decimal.Parse(textBox1.Text);
            
                textBoxDis.Text = $"{textBoxDis.Text} {textBox1.Text} =";
            
            try
                {
                    switch (Operation)
                    {
                        case "+":
                            result = textBox1.Text = (FrstNumber + ScndNumber).ToString();
                            break;
                        case "-":
                            result = textBox1.Text = (FrstNumber - ScndNumber).ToString();
                            break;
                        case "×":
                            result = textBox1.Text = (FrstNumber * ScndNumber).ToString();
                            break;
                        case "÷":
                            try
                            {
                                result = textBox1.Text = (FrstNumber / ScndNumber).ToString();
                            }
                            catch (System.DivideByZeroException)
                            {
                                result = textBox1.Text = "0";
                                MessageBox.Show("you Can't divide on zero!", "Error");
                            }
                            break;
                    }
                

            }
                catch (System.OverflowException)
                {
                    MessageBox.Show("The number is too long", "Error");
                }
        }

        private void Percantagebtn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Operation = button.Text;
            try
            {
                switch (Operation)
                {
                    case "√x":
                        textBoxDis.Text = $"√{textBox1.Text}";
                        result = textBox1.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(textBox1.Text)));
                        break;
                    case "^2":
                        textBoxDis.Text = $"{textBox1.Text}^2";
                        result = textBox1.Text =  Convert.ToString(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text));
                        break;
                    case "¹/x":
                        textBoxDis.Text = $"¹/{textBox1.Text}";
                        result = textBox1.Text = Convert.ToString(1 / (Convert.ToDouble(textBox1.Text)));
                        break;
                    case "%":
                        textBoxDis.Text = $"%{textBox1.Text}";
                        result = textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / 100);                      
                        break;
                }

            }
            catch (System.OverflowException)
            {
                MessageBox.Show("The number is too long", "Error");
            }
        }
    }
}
