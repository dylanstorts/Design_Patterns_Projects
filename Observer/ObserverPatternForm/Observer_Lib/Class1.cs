using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer_Lib
{
    //my abstract subject
    abstract public class ColorBox : CheckBox
    {
        bool state;

        public abstract void Attach();
        public abstract void Detach();
        public abstract void Notify();
    }

    //one of my concrete subjects
    public class RedBox : ColorBox
    {
        public override void Attach()
        {
            throw new NotImplementedException();
        }

        public override void Detach()
        {
            throw new NotImplementedException();
        }

        public override void Notify()
        {
            throw new NotImplementedException();
        }
    }

    //another concrete subject
    public class GreenBox : ColorBox
    {
        public override void Attach()
        {
            throw new NotImplementedException();
        }

        public override void Detach()
        {
            throw new NotImplementedException();
        }

        public override void Notify()
        {
            throw new NotImplementedException();
        }
    }

    //another concrete subject
    public class BlueBox : ColorBox
    {
        public override void Attach()
        {
            throw new NotImplementedException();
        }

        public override void Detach()
        {
            throw new NotImplementedException();
        }

        public override void Notify()
        {
            throw new NotImplementedException();
        }
    }

    //my abstract observer class
    abstract public class Color
    {
        public List<CheckBox>   colorBoxes = new List<CheckBox>();
        public List<string> colors     = new List<string>();

        abstract public string Update();

    }

    //my concrete observer class
    public class ColorMix : Color
    {
        public ColorMix(CheckBox Red, CheckBox Green, CheckBox Blue)
        {
            colorBoxes.Add(Red);
            colorBoxes.Add(Green);
            colorBoxes.Add(Blue);

            colors.Add("FF0000"); //red    1
            colors.Add("33CC33"); //green  2
            colors.Add("0000FF"); //blue   3
            colors.Add("FFFF00"); //yellow || red & green  3
            colors.Add("9933FF"); //purple || red & blue   4
            colors.Add("00FFFF"); //aqua   || green & blue 5
            
        }

        public override string Update()
        {
            int colorIndex = 0;

            if(    colorBoxes[0].Checked == true 
                && colorBoxes[1].Checked == false
                && colorBoxes[2].Checked == false)
            {
                colorIndex = 0;
            }
            else if(colorBoxes[0].Checked == false
                 && colorBoxes[1].Checked == true
                 && colorBoxes[2].Checked == false)
            {
                colorIndex = 1;
            }
            else if (colorBoxes[0].Checked == false
                  && colorBoxes[1].Checked == false
                  && colorBoxes[2].Checked == true)
            {
                colorIndex = 2;
            }
            else if (colorBoxes[0].Checked == true
                  && colorBoxes[1].Checked == true
                  && colorBoxes[2].Checked == false)
            {
                colorIndex = 3;
            }
            else if (colorBoxes[0].Checked == true
                  && colorBoxes[1].Checked == false
                  && colorBoxes[2].Checked == true)
            {
                colorIndex = 4;
            }
            else
            {
                colorIndex = 5;
            }

            return colors[colorIndex];
        }
    }

}
