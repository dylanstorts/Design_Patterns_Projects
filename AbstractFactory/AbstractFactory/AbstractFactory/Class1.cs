using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //abstract factory
    public abstract class Blade
    {
        public abstract Lance CreateLance();
        public abstract Sword CreateSword();
    }

    //concrete factory 1
    public class JapanBlade : Blade
    {
        public override Lance CreateLance()
        {
            return new Naginata();
        }

        public override Sword CreateSword()
        {
            return new Katana();
        }
    }

    //concrete factory 2
    public class RomeBlade : Blade
    {
        public override Lance CreateLance()
        {
            return new Pilum();
        }

        public override Sword CreateSword()
        {
            return new Gladius();
        }
    }

    //////////////////////////////

    //abstract product A
    public abstract class Lance
    {
        public int bladeLength = 35;
        public int shaftLength = 200;
        public string bladeType;

        public string Description()
        {
            return bladeType + ". \n"
                 + bladeLength + "cm Blade, \n"
                 + shaftLength + "cm shaft.";
        }
    }

    //concrete product A JapanBlade
    public class Naginata : Lance
    {
        public Naginata()
        {
            bladeType = "Single Edge, Curved Blade";
        }
    }

    //concrete product A RomeBlade
    public class Pilum : Lance
    {
        public Pilum()
        {
            bladeType = "Double Edge, Arrow Head";
        }
    }

    //////////////////////////////

    //abstract product B
    public abstract class Sword
    {
        public double weight;
        public int bladeLength;
        public int length;
        public string bladeType;

        public string Description()
        {
            return bladeType +
                   ". Weighed " + weight + " lbs\n" +
                   ". The Blade was " + bladeLength + "cm long & \n" +
                   "the overall length was " + length + "cm";
        }
    }

    //concrete product B JapanBlade
    public class Katana : Sword
    {
        public Katana()
        {
            weight = 2.5;
            bladeLength = 65;
            length = 85;
            bladeType = "Curved, Single Edge";
        }
    }

    //concrete product B RomeBlade
    public class Gladius : Sword
    {
        public Gladius()
        {
            weight = 2.2;
            bladeLength = 50;
            length = 65;
            bladeType = "Straight, Double Edge";
        }
    }
}
