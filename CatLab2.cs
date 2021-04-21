using System;
using System.Collections.Generic;
using System.Text;

namespace If_Switch
{
    public class CatLab2 : AnimalWithTail
    {
        public CatLab2(string color, float weight, float tailLenth)
            : base(color, weight, tailLenth) { }
        private string Purr()
        {
            return "purrrrrr";
        }
        private string Meow()
        {
            return "Meow";
        }
        public override string MakeSound()
        {
            return Purr() + Meow();
        }
        public override string ToString()
        {
            return $"This is a Cat, Color = {Color}," +
                $" Weihgt = {Weight}, " +
                $"TailLength = {TailLength}";
        }
    }
}
