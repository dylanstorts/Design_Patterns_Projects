using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FacadePattern
{
    public class TankFilter
    {
        public enum FilterState {ON, OFF};
        private int FilterGPM;
        private string FilterChangeDate = "Change in 4 weeks";
        private FilterState filterState;

        public static DateTime Today { get; }

        public TankFilter(int filterGpm)
        {
            if (filterGpm != 0)
                filterState = FilterState.ON;
            else
                filterState = FilterState.OFF;

                FilterGPM = filterGpm;
        }

        public bool getState()
        {
            if (filterState == FilterState.ON)
                return true;

            return false;
        }

        public void setState(bool OnOff)
        {
            if (OnOff)
                filterState = FilterState.ON;
            else
                filterState = FilterState.OFF;
        }

        public string getGPM()
        {
            return FilterGPM.ToString();
        }

        public string getDate()
        {
            return Today.ToString();
        }

    }

    public class TankHeater
    {
        public enum HeaterState { ON, OFF }
        private HeaterState heaterState;
        private int heaterTemp;
        private string heatUnit;

        public TankHeater(int temp, string unit)
        {
            if(temp != 0)
                heaterState = HeaterState.ON;
            else
                heaterState = HeaterState.OFF;

            heaterTemp = temp;
            heatUnit = unit;
        }

        public bool getState()
        {
            if (heaterState == HeaterState.ON)
                return true;

            return false;
        }

        public void setState(bool OnOff)
        {
            if (OnOff)
                heaterState = HeaterState.ON;
            else
                heaterState = HeaterState.OFF;
        }

        public decimal getHeat()
        {
            return heaterTemp;
        }
    }

    public class TankFeeder
    {
        private int frequency;
        private int doseSize;

        public enum FeederState {ON, OFF }
        private FeederState feederState;

        public TankFeeder(int pop)
        {
            doseSize = pop / 2;
            frequency = 12;

            if (pop != 0)
                feederState = FeederState.ON;
            else
                feederState = FeederState.OFF;
        }

        public bool getState()
        {
            if (feederState == FeederState.ON)
                return true;

            return false;
        }

        public void setState(bool OnOff)
        {
            if (OnOff)
                feederState = FeederState.ON;
            else
                feederState = FeederState.OFF;
        }

        public decimal getFrequency()
        {
            return Convert.ToDecimal(frequency);
        }

        public decimal getDose()
        {
            return Convert.ToDecimal(doseSize);
        }
    }

    public class TankLights
    {
        public enum LightState { ON, OFF }
        private LightState lightState;

        //public ColorDialog myColor = new ColorDialog();
        
        private string currentColor;

        public TankLights(string color)
        {

            if (color != "No Color" && color != null)
            {
                lightState = LightState.ON;
            }
            else
            {
                lightState = LightState.OFF;
            }

            currentColor = color;
        }

        //public void setColor(string color)
        //{
        //    currentColor = color;
        //}

        //public string getColor()
        //{
        //    return currentColor;
        //}

        public string Color
        {
            get { return currentColor; }
            set { currentColor = value; }
        }

        public void setState(bool OnOff)
        {
            if (OnOff)
                lightState = LightState.ON;
            else
                lightState = LightState.OFF;
        }

        public bool getState()
        {
            if (lightState == LightState.ON)
                return true;

            return false;
        }
    }
}
