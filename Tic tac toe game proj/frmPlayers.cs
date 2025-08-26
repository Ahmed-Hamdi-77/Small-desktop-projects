using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_tac_toe_game_proj
{
    public partial class frmChooseSigns: Form
    {
        public frmChooseSigns()
        {
            InitializeComponent();
        }
        public string Sign = "X";

        private void btn_X_Click(object sender, EventArgs e)
        {
            Sign = btn_X.Tag.ToString();
        }

        private void btn_O_Click(object sender, EventArgs e)
        {
            Sign = btn_O.Tag.ToString();
        }
    }
}
