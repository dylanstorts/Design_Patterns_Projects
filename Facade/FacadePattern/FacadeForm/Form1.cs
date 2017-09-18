using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FacadePattern;

namespace FacadeForm
{
    public partial class Form1 : Form
    {
        private int population;
        private TankFilter filter;
        private TankFeeder feeder;
        private TankHeater heater;
        private TankLights lights;

        public Form1()
        {
            InitializeComponent();

            comboColor.SelectedIndex     = 5;
            combobox_color.SelectedIndex = 5;
        }


        private void UpdateFacade()
        {
            UpdateGPM(); UpdateHeat(); UpdateLights(); UpdateFeeder();
        }

        private void UpdateGPM()
        {
            tbox_gpm.Text = (numUpDown_tanksize.Value / 5).ToString();
            filter = new TankFilter( Convert.ToInt32(tbox_gpm.Text) );

            checkbox_filterPower.Checked = filter.getState();

        }

        private void UpdateHeat()
        {
            if(combobox_type.Text == "Freshwater")
                numUpDown_temp.Value   = Convert.ToDecimal(74);
            else
                numUpDown_temp.Value = Convert.ToDecimal(78);

            heater = new TankHeater( Convert.ToInt32(numUpDown_temp.Value), "F");

            checkbox_heaterPower.Checked = heater.getState();
        }

        private void UpdateLights()
        {
            lights = new TankLights(combobox_color.SelectedItem.ToString());
                
            comboColor.Text = lights.Color;//gets the current selected color to the light dropdown

            checkbox_lightPower.Checked = lights.getState();

            switch (comboColor.SelectedItem.ToString())
            {
                case "Red":    btn_color.BackColor = Color.Red;
                    break;
                case "Green":  btn_color.BackColor = Color.Green;
                    break;
                case "Blue":   btn_color.BackColor = Color.Blue;
                    break;
                case "Yellow": btn_color.BackColor = Color.Yellow;
                    break;
                case "White":  btn_color.BackColor = Color.White;
                    break;
                default:       btn_color.BackColor = Color.Black;
                    break;

            }

        }

        private void UpdateFeeder()
        {
            population = Convert.ToInt32(numUpDown_population.Value);

            feeder = new TankFeeder(population);

            if ( feeder.getState() )
            {
                checkbox_feederPower.Checked = feeder.getState();
                
                numUpDown_dose.Value = feeder.getDose();
                numUpDown_frequency.Value = feeder.getFrequency();
            }
            
            else
            {//here if there are no fish so we can turn filter, heater, and feeder off
                checkbox_filterPower.Checked = false;
                filter.setState(false);

                checkbox_heaterPower.Checked = false;
                heater.setState(false);

                checkbox_feederPower.Checked = false;
                feeder.setState(false);
            }
        }

        private void numUpDown_tanksize_ValueChanged(object sender, EventArgs e)
        {
            UpdateFacade();
        }

        private void numUpDown_population_ValueChanged(object sender, EventArgs e)
        {
            UpdateFacade();
        }

        private void combobox_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFacade();
        }

        private void combobox_color_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFacade();
        }

    }
}
