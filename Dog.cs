using System;
using System.Collections.Generic;
using System.Text;

namespace If_Switch
{
    public class Dog : AnimalWithTail
    {
        public Dog(string color, float weight, float tailLenth)
            : base(color, weight, tailLenth) { }
        public override string MakeSound()
        {
            return "Woof";
        }
        public override string ToString()
        {
            return $"This is a Cat, Color = {Color}," +
                $" Weihgt = {Weight}, " +
                $"TailLength = {TailLength}";
        }
    }
}
