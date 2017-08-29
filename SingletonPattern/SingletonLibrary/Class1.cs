using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonLibrary
{
    public class LivewellFish
    {
        private static LivewellFish fishInstance;
        public string Livewell;

        private LivewellFish(string fish)
        {//private constructor
            Livewell = fish;
        }

        public static LivewellFish getInstance(string newFish)
        {
            //here is the essence of the singleton where a single instance of it is only allowed to be in memory at once
            if (fishInstance == null)
            {
                //create a new singleton object with a different string in it if there is no existing object previously
                fishInstance = new LivewellFish(newFish);
            }
            //return the singleton object
            return fishInstance;
        }

        public string getFish()
        {
            //this simply returns the string of the fish in the livewell that the singleton controls
            return Livewell;
        }
        
        public void Clear()
        {
            //this method only exists here because we need a way to clear the instance of the first singleton to replace it with new data
            fishInstance = null;
        }
    }
}
