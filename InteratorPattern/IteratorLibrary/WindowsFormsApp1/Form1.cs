using IteratorLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_iterateAll_Click(object sender, EventArgs e)
        {
            ConcreteAggregate agg = new ConcreteAggregate();

            PopulateAgg(agg);

            Iterator iter = agg.CreateIterator();

            for(iter.First(); iter.IsDone(); iter.Next())
            {
                listbox_displayAll.Items.Add(iter.CurrentItem() );
            }
        }

        private void PopulateAgg(ConcreteAggregate aggregate)
        {
            aggregate.Add("Item 0");
            aggregate.Add("Item 1");
            aggregate.Add("Item 2");
            aggregate.Add("Item 3");
            aggregate.Add("Item 4");
            aggregate.Add("Item 5");
        }
    }
}
