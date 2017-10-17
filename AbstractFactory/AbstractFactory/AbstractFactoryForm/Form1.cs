using AbstractFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactoryForm
{
    public partial class Form1 : Form
    {

        JapanBlade JapanBladeFactory;
        RomeBlade RomeBladeFactory;

        public Form1()
        {
            InitializeComponent();

            JapanBladeFactory = new JapanBlade();
            RomeBladeFactory = new RomeBlade();

        }

        private void btn_naginata_Click(object sender, EventArgs e)
        {

            Lance JLance = JapanBladeFactory.CreateLance();

            txtb_desc.Text = JLance.Description();
        }

        private void btn_pilum_Click(object sender, EventArgs e)
        { 

            Lance RLance = RomeBladeFactory.CreateLance();

            txtb_desc.Text = RLance.Description();
        }

        private void btn_katana_Click(object sender, EventArgs e)
        {

            Sword JSword = JapanBladeFactory.CreateSword();

            txtb_desc.Text = JSword.Description();
        }

        private void btn_gladius_Click(object sender, EventArgs e)
        {

            Sword RSword = RomeBladeFactory.CreateSword();

            txtb_desc.Text = RSword.Description();
        }
    }
}
