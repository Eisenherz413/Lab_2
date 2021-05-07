using System;
using System.Collections.Generic;
using System.Text;

namespace If_Switch
{
    class Vacant : Software
    {
        public string Name { get; set; }
        public string Producer { get; set; }

        public Vacant(string name, string producer)
        {
            Name = name;
            Producer = producer;
        }
        public override void PrintName()
        {
            Console.WriteLine(Name);
        }
        public override void PrintProducer()
        {
            Console.WriteLine(Producer);
        }
        public override void GetAvailability()
        {
            if (Console.ReadLine() == "1")
                Console.WriteLine(true);
            else Console.WriteLine(false);
        }
    }
}
