using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Student_Unittest
{
    public class Person
    {
        private string _name;
        private string _address;

        public string Name
        {
            get => _name;
            set

            {
                if (value == null) throw new ArgumentException("Skriv et navn");
                if (value.Length < 2) throw new ArgumentException("Navnet er for kort. Minimum 2 tegn");
                _name = value;
            }
        }
        public string Address
        {
            get => _address;
            set
            {
                if (value == null) throw new ArgumentException("Der skal skrives en adresse");
                _address = value;
            }
        }

        public GenderType Gender { get; set; }

        public enum GenderType
        {
            Male, Female
        }

        public override string ToString()
        {
            return base.ToString();

        }
    }


}
