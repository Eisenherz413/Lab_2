using System;
using System.Collections.Generic;
using System.Text;

namespace If_Switch
{
    public enum Gender
    {
        Male,
        Female
    }
    class Cat
    {
        string Name { get; }
        Gender gender { get; }
        public Cat(string name, Gender g)
        {
            this.Energy = MaxEnergy;
            this.Name = name;
            this.gender = g;
        }
       
        private double _energy;

        public double Energy
        {
            get { return _energy; }
            private set 
            {
                if (value < MinEnergy)
                {
                    throw new Exception("Not enough energy to jump");

                }
                else if (value > MaxEnergy)
                {
                    _energy = MaxEnergy;
                }
                else 
                {
                    _energy = value;
                }
            }
        }
        public static double MaxEnergy = 20;
        public static double MinEnergy = 0;
        public static readonly double SleepEnergyGain = 10;
        public static readonly double JumpEnergyDrain = 0.5;

        public void Jump()
        {
            Energy -= JumpEnergyDrain;
        }
        public void Sleep()
        {
            Energy += SleepEnergyGain;
        }

    }
}
