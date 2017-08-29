using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SingletonLibrary;

namespace SingletonPattern
{
    public partial class Form1 : Form
    {
        //my variables
        private int caughtFish, smallestFish, largestFish;
        private Random rnd = new Random();
        //

        public Form1()
        {
            InitializeComponent();

            //the following two ints only control the range of random numbers generated as a "fish's length"
            smallestFish = 9;
            largestFish  = 50;
            
        }

        private void Btn_keepfish_Click(object sender, EventArgs e)
        {
            //here we actually call upon the singleton class to be demonstrated with this program
            tb_livewell.Text = LivewellFish.getInstance(tb_justcaught.Text).getFish();

            //now we can set the livewell box again, either populating it with the new fish length or returning the original fish length

        }

        private void Btn_getfish_Click(object sender, EventArgs e)
        {
            caughtFish = rnd.Next(smallestFish, largestFish);
            //now we have generated a new "fish" with a random length and saved it
            //this new "caught" fish will now be printed in the tb_justcaught text box
            tb_justcaught.Text = caughtFish.ToString();

        }

        private void Btn_releasefish_Click(object sender, EventArgs e)
        {
            LivewellFish.getInstance(tb_justcaught.Text).Clear();
            tb_livewell.Text = "";
            //set the current "fish" and its length value to null
            /*
             * the reason behind having a release button is to demonstrate that unless you release
             * your saved fish first, you cannot override, save or make another fish
             */ 
        }
    }
}
