using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment5
{
    public class DiscFactory
    {
        public Disc CreateDisc(string type)
        {
            Disc disc = null;

            if (type.Equals("Small"))
            {
                disc = new DiscSmall();
            }
            else if (type.Equals("Mid"))
            {
                disc = new DiscMid();
            }
            else if (type.Equals("Big"))
            {
                disc = new DiscBig();
            }
            return disc;
        }
    }
}