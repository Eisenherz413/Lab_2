using System;
using System.Collections.Generic;
using System.Text;

namespace If_Switch
{
    public abstract class Animal
    {
        public float Weight { get; set; }
        public string Color { get; set; }
        public Animal(string color, float weight)
        {
            Weight = weight;
            Color = color;
        }
        public abstract string MakeSound();

    }

}
