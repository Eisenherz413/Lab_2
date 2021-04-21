using System;
using System.Collections.Generic;
using System.Text;

namespace If_Switch
{
    public abstract class AnimalWithTail : Animal
    {
        public float TailLength { get; set; }
        public AnimalWithTail(string color, float weight, float tailLenth)
            : base(color, weight) 
        {
            TailLength = tailLenth;
        }


    }
}
