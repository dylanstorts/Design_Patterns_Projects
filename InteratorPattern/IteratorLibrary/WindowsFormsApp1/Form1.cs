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

            Iterator iter = agg.CreateIterator(IteratorType.completeIterator);

            for(iter.First(); !iter.IsDone(); iter.Next())
            {
                listbox_displayAll.Items.Add(iter.CurrentItem() );
            }
        }

        private void PopulateAgg(ConcreteAggregate aggregate)
        {
            aggregate.Add("Ben");
            aggregate.Add("Abbie");
            aggregate.Add("Anna");
            aggregate.Add("Berry");
            
            aggregate.Add("Balthasar");
            aggregate.Add("Carol");

            aggregate.Add("Camren");
            aggregate.Add("Cori");
            aggregate.Add("Casandra");
            aggregate.Add("David");
            aggregate.Add("Aaron");
            aggregate.Add("Dylan");
        }

        private void btn_IterateA_Click(object sender, EventArgs e)
        {
            ConcreteAggregate agg = new ConcreteAggregate();

            PopulateAgg(agg);

            Iterator iter = agg.CreateIterator(IteratorType.aIterator);

            listbox_selected.ClearSelected();

            for (iter.First(); !iter.IsDone(); iter.Next())
            {
                
                listbox_selected.Items.Add(iter.CurrentItem());
            }
        }

        private void btn_IterateB_Click(object sender, EventArgs e)
        {
            ConcreteAggregate agg = new ConcreteAggregate();

            PopulateAgg(agg);

            Iterator iter = agg.CreateIterator(IteratorType.bIterator);

            listbox_selected.ClearSelected();

            for (iter.First(); !iter.IsDone(); iter.Next())
            {
                
                listbox_selected.Items.Add(iter.CurrentItem());
            }
        }

        private void btn_IterateC_Click(object sender, EventArgs e)
        {
            ConcreteAggregate agg = new ConcreteAggregate();

            PopulateAgg(agg);

            Iterator iter = agg.CreateIterator(IteratorType.cIterator);

            listbox_selected.ClearSelected();

            for (iter.First(); !iter.IsDone(); iter.Next())
            {
                
                listbox_selected.Items.Add(iter.CurrentItem());
            }
        }
    }
}
