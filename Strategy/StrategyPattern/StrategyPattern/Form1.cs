using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrategyPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Context Multiplier;

        int a; int b;

        private void btn_multiplier_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(txtb_intA.Text);
            b = Convert.ToInt32(txtb_intB.Text);

            if (rbtn_default.Checked)
                Multiplier = new Context(new MultiplyStratA());
            else if (rbtn_recursive.Checked)
                Multiplier = new Context(new MultiplyStratB());
            else
                Multiplier = new Context(new MultiplyStratC());

            lbl_result.Text = Multiplier.ContextMultiplier(a, b).ToString();
        }
    }
}
