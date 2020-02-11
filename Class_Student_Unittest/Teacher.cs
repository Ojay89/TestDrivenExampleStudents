using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Student_Unittest
{
    public class Teacher : Person
    {
      
        private int _salary;

    
        public int Salary
        {
            get => _salary;
            set
            {
                if (value > 0 ) throw new ArgumentOutOfRangeException("Du tjener for lidt");
                _salary = value;
            }
        }



    }
}
