using System;
using System.Collections.Generic;
using System.Text;

namespace If_Switch
{
    class Person
    {
        
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string surname;
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        protected System.DateTime BirthdayDate { get; set; }
        private int ChangeYear;
        public int YearOfBirth
        {
            get { return BirthdayDate.Year; }
            set { BirthdayDate = new DateTime(value, BirthdayDate.Month, BirthdayDate.Day); }
        }


        public Person(string name, string surname, System.DateTime birthdayDate)
        {
            Name = name;
            Surname = surname;
            BirthdayDate = birthdayDate;
        }

        public Person()
        {
            Name = "Default";
            Surname = "Defaultovich";
            BirthdayDate = System.DateTime.Now;
        }

        public override string ToString()
        {
            return $"Name:{Name}," +
                $" Surname: {Surname}," +
                $" Date of birth: {BirthdayDate}";
        }

        public virtual string ToShortString()
        {
            return $"Name:{Name}," +
                $" Surname: {Surname},";
        }
        public enum Frequency
        {
            Weekly,
            Monthly,
            Yearly
        }

    }
}
