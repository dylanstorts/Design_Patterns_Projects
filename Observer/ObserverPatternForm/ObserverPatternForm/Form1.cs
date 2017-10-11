using Observer_Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverPatternForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            redBox.State   = checkb_red.Checked;
            greenBox.State = checkb_green.Checked;
            blueBox.State  = checkb_blue.Checked;
        }

        ColorMix myColorMixer = new ColorMix();

        RedBox redBox     = new RedBox();
        GreenBox greenBox = new GreenBox();
        BlueBox  blueBox  = new BlueBox();

        #region Delegate Attempt

        //public delegate void ColorHandler(ColorBox myBox, ColorMix colorMix);
        public EventHandler colorHandler;
        //ColorHandler colorHandler;

        public class ColorArgs : EventArgs
        {
            public bool   checkb;
            public string hex;
        }
        ColorArgs myColorArgs;
        #endregion

        private void AttachThis(ColorBox myBox, ColorMix myMix)
        {
            myBox.Attach(myMix);
        }

        private void DetachThis(ColorBox myBox, ColorMix myMix)
        {
            myBox.Detach(myMix);
        }

        private void checkb_red_CheckedChanged(object sender, EventArgs e)
        {
            redBox.State = checkb_red.Checked;

            if (checkb_red.Checked)
            {
                AttachThis(redBox, myColorMixer);
                //colorHandler += redBox.Attach(redBox, myColorMixer);
            }
            else
                DetachThis(redBox, myColorMixer);

            btn_led.BackColor = System.Drawing.ColorTranslator.FromHtml(myColorMixer.Update() );
        }

        private void checkb_green_CheckedChanged(object sender, EventArgs e)
        {
            greenBox.State = checkb_green.Checked;

            if (checkb_green.Checked)
            {
                AttachThis(greenBox, myColorMixer);
            }
            else
                DetachThis(greenBox, myColorMixer);

            btn_led.BackColor = System.Drawing.ColorTranslator.FromHtml(myColorMixer.Update());
        }

        private void checkb_blue_CheckedChanged(object sender, EventArgs e)
        {
            blueBox.State = checkb_blue.Checked;

            if (checkb_blue.Checked)
            {
                AttachThis(blueBox, myColorMixer);
            }
            else
                DetachThis(blueBox, myColorMixer);

            btn_led.BackColor = System.Drawing.ColorTranslator.FromHtml(myColorMixer.Update());
        }
    }
}
