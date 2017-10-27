using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdapterLib
{
    public partial class CurrencyConverterForm : Form
    {
        public CurrencyConverterForm()
        {
            InitializeComponent();
        }

        Currencies target = new Currencies();

        CurrenciesConverter adapter = new CurrenciesConverter();

        double temp;

        private void btn_new_calc_Click(object sender, EventArgs e)
        {
            temp = adapter.Convert(Convert.ToDouble(txtb_new_amount.Text),
                             combob_new_from.SelectedItem.ToString(),
                             combob_new_to.SelectedItem.ToString());

            txtb_new_result.Text = temp.ToString();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            string to = combob_to.SelectedItem.ToString();
            double result;

            switch (to)
            {
                case "yen":
                    result = target.toYen(Convert.ToDouble(txtb_amount));
                    break;
                case "pound":
                    result = target.toPound(Convert.ToDouble(txtb_amount));
                    break;
                case "euro":
                    result = target.toEuro(Convert.ToDouble(txtb_amount));
                    break;
                default:
                    result = target.toDollar(Convert.ToDouble(txtb_amount));
                    break;
            }

            txtb_result.Text = result.ToString();
        }
    }
}
