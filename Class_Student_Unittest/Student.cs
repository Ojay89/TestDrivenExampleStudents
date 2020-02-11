using System;
using System.ComponentModel.Design;

namespace Class_Student_Unittest
{
    public class Student : Person
    {
        private int _semester;


        public int Semester
        {
            get => _semester;
            set
            {
                if (value <= 1 || value >= 8) throw new ArgumentOutOfRangeException("Du skal minimum være på mellem 1. og 8. semester");
                _semester = value;
            }
        }

    }
}
