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

        #region Delegate


        public delegate void ColorHandlerDelegate(ColorMix myColorMix, ColorArgs myColorArgs);
        //public event         
        ColorHandlerDelegate MyColorHandler;

        public class ColorArgs : EventArgs
        {
            public bool check;
            public string hex;

            public ColorArgs(string new_hex, bool checkb)
            {
                check = checkb;
                hex = new_hex;
            }
        }

        public class ColorEventHandlerClass
        {
            public void SubscribeColorHandler(ColorMix observer, ColorArgs e)
            {
                if (e.check)
                    observer.Add(e.hex);

                else
                    observer.Remove(e.hex);

            }
        }

        ColorEventHandlerClass colorHandler = new ColorEventHandlerClass();
        #endregion
        

        private void checkb_red_CheckedChanged(object sender, EventArgs e)
        {
                ColorArgs args = new ColorArgs(redBox.GetHex(), checkb_red.Checked);

                MyColorHandler += new ColorHandlerDelegate(colorHandler.SubscribeColorHandler);
                MyColorHandler(myColorMixer, args);

            btn_led.BackColor = System.Drawing.ColorTranslator.FromHtml(myColorMixer.Update() );
        }

        private void checkb_green_CheckedChanged(object sender, EventArgs e)
        {
                ColorArgs args = new ColorArgs(greenBox.GetHex(), checkb_green.Checked);

                MyColorHandler += new ColorHandlerDelegate(colorHandler.SubscribeColorHandler);
                MyColorHandler(myColorMixer, args);

            btn_led.BackColor = System.Drawing.ColorTranslator.FromHtml(myColorMixer.Update());
        }

        private void checkb_blue_CheckedChanged(object sender, EventArgs e)
        {
                ColorArgs args = new ColorArgs(blueBox.GetHex(), checkb_blue.Checked);

                MyColorHandler += new ColorHandlerDelegate(colorHandler.SubscribeColorHandler);
                MyColorHandler(myColorMixer, args);

            btn_led.BackColor = System.Drawing.ColorTranslator.FromHtml(myColorMixer.Update());
        }
    }
}
