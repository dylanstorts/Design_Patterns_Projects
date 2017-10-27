using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterLib
{
    public abstract class Currency
    {
        protected double toDollarRatio;
        protected double convertRatio;
    }

    public class Currencies : Currency
    {
        public Currencies()
        {
            toDollarRatio = 1;
            convertRatio = 1;
        }

        public double toDollar(double money)
        {
            return (money * toDollarRatio);
        }

        public double toYen(double money)
        {
            toDollarRatio = 0.0089;
            
                return (money * toDollarRatio);
        }

        public double toPound(double money)
        {
            toDollarRatio = 1.31;
            
            return (money * toDollarRatio);
        }

        public double toEuro(double money)
        {
            toDollarRatio = 0.68;
            
            return (money * toDollarRatio);
        }
    }

    public class CurrenciesConverter : Currencies
    {
        public CurrenciesConverter()
        {
            toDollarRatio = 1;
            convertRatio = 1;
        }

        public double Convert(double money, string from, string to)
        {
            switch (from)
            {
                case "euro":
                    toDollarRatio = 0.68; //one euro is worth this many dollars

                    if (to == "dollar") //if converting to dollars
                        return (money / toDollarRatio);
                    else if (to == "yen") //if converting to yen
                        convertRatio = 132.8;
                    else if (to == "pound") //if converting to pounds
                        convertRatio = 0.89;
                    else //if converting from euros to euros
                        return money;
                    break;
                case "yen":
                    toDollarRatio = 0.0089;

                    if (to == "dollar")
                        return (money / toDollarRatio);
                    else if (to == "euro")
                        convertRatio = 0.0075;
                    else if (to == "pound")
                        convertRatio = 0.0067;
                    else
                        return money;
                    break;
                case "pound":
                    toDollarRatio = 1.31;

                    if (to == "dollar")
                        return (money / toDollarRatio);
                    else if (to == "yen")
                        convertRatio = 149.9;
                    else if (to == "euro")
                        convertRatio = 1.13;
                    else
                        return money;
                    break;
                default: //US Dollars
                    toDollarRatio = 1;

                    if (to == "euro")
                        convertRatio = 0.86;
                    else if (to == "yen")
                        convertRatio = 114.1;
                    else if (to == "pound")
                        convertRatio = 0.76;
                    else
                        return money;
                    break;
            }

            return (money / convertRatio);
        }
    }
}
