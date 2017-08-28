using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonLibrary
{
    public class LivewellFish
    {
        static LivewellFish yourFish;
        string Livewell;

        private LivewellFish(string fish)
        {//private constructor
            Livewell = fish;
        }

        public static LivewellFish getInstance(string newFish)
        {
            if (yourFish == null)
            {
                LivewellFish yourFish = new LivewellFish(newFish);
            }

            return yourFish;
        }

        public string getFish()
        {
            return Livewell;
        }
        
        public void Clear()
        {
            yourFish = null;
        }
    }
}
