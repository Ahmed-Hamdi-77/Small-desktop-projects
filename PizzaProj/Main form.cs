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
    public partial class Pizzafrm: Form
    {
        public Pizzafrm()
        {
            InitializeComponent();                        
            
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new SubForm();
            frm.Show();
        }
    }
}
