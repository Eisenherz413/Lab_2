using System;
using System.Collections.Generic;
using System.Text;

namespace If_Switch
{
    class Commertial : Software
    {
        public string Name { get; set; }
        public string Producer { get; set; }
        public string InstalationDate { get; set; }
        public string NonPaidUsage { get; set; }
        public float Price { get; set; }
        public Commertial(string name, string producer, float price, string instalationDate, string nonPaidUsage)
        {
            Name = name;
            Producer = producer;
            Price = price;
            InstalationDate = instalationDate;
            NonPaidUsage = nonPaidUsage;
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
