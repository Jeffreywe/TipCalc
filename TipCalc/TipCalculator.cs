using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalc {
    public partial class TipCalculator : Form {
        public TipCalculator() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            decimal Dinnerbill = Convert.ToDecimal(txtDinnerbill.Text);

            decimal Tippercent = 0.2m;
            txtTippercent.Text = Tippercent.ToString("p1");

            decimal TipAmount = Dinnerbill * Tippercent;
            txtTipAmount.Text = TipAmount.ToString("c");

            txtDinnerbill.Focus();
        }

        private void button2_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
