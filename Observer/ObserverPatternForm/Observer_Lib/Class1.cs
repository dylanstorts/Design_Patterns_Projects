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
        public bool State;

        public abstract void Attach(ColorMix colorMix);
        public abstract void Detach(ColorMix colorMix);
        public abstract void Notify();
    }

    //one of my concrete subjects
    public class RedBox : ColorBox
    {
        public RedBox()
        {
            this.State = false;
        }

        public override void Attach(ColorMix colorMix)
        {
            colorMix.redCheck = this.State;
        }

        public override void Detach(ColorMix colorMix)
        {
            colorMix.redCheck = false;
        }

        public override void Notify()
        {
            throw new NotImplementedException();
        }
    }

    //another concrete subject
    public class GreenBox : ColorBox
    {
        public GreenBox()
        {
            this.State = false;
        }

        public override void Attach(ColorMix colorMix)
        {
            colorMix.greenCheck = this.State;
        }

        public override void Detach(ColorMix colorMix)
        {
            colorMix.greenCheck = false;
        }

        public override void Notify()
        {
            throw new NotImplementedException();
        }
    }

    //another concrete subject
    public class BlueBox : ColorBox
    {
        public BlueBox()
        {
            this.State = false;
        }

        public override void Attach(ColorMix colorMix)
        {
            colorMix.blueCheck = this.State;
        }

        public override void Detach(ColorMix colorMix)
        {
            colorMix.blueCheck = false;
        }

        public override void Notify()
        {
            throw new NotImplementedException();
        }
    }

    //my abstract observer class
    abstract public class Color
    {
        public CheckBox red, green, blue;
        public List<string>   colors     = new List<string>();

        abstract public string Update();

    }

    //my concrete observer class
    public class ColorMix : Color
    {
        bool Red;
        bool Green;
        bool Blue;

        public ColorMix()
        {
            Red = false;
            Green = false;
            Blue = false;

            colors.Add("#FF0000"); //red    1
            colors.Add("#33CC33"); //green  2
            colors.Add("#0000FF"); //blue   3
            colors.Add("#FFFF00"); //yellow || red & green  3
            colors.Add("#9933FF"); //purple || red & blue   4
            colors.Add("#00FFFF"); //aqua   || green & blue 5
            colors.Add("#000000"); //black
            colors.Add("#FFFFFF"); //white
            
        }

        public bool redCheck
        {
            get{ return Red; }

            set { Red = value; }
        }

        public bool blueCheck
        {
            get { return Blue; }

            set { Blue = value; }
        }

        public bool greenCheck
        {
            get { return Green; }

            set { Green = value; }
        }


        public override string Update()
        {
            int colorIndex = 0;

            if(    Red == true 
                && Green == false
                && Blue == false)
            {
                colorIndex = 0;
            }
            else if(Red == false
                 && Green == true
                 && Blue == false)
            {
                colorIndex = 1;
            }
            else if (Red == false
                  && Green == false
                  && Blue == true)
            {
                colorIndex = 2;
            }
            else if (Red == true
                  && Green == true
                  && Blue == false)
            {
                colorIndex = 3;
            }
            else if (Red == true
                  && Green == false
                  && Blue == true)
            {
                colorIndex = 4;
            }
            else if (Red == false
                  && Green == true
                  && Blue == true)
            {
                colorIndex = 5;
            }
            else if (Red == false
                  && Green == false
                  && Blue == false)
            {
                colorIndex = 6;
            }
            else
            {
                colorIndex = 7;
            }

                return colors[colorIndex];
        }
    }

}
