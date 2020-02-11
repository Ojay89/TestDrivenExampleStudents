using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Student_Unittest;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Student_Unittest.Tests
{
    [TestClass()]
    public class StudentTests
    {

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void StudentTest()
        {
            Student s1 = new Student(); //Arrange

            s1.Name = "B"; // Act

        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void AddressTest()
        {
            Student s1 = new Student(); //Arrange

            s1.Address = null; // act
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SemesterTestTooHigh() 
        {
            Student s1 = new Student(); //Arrange

            s1.Semester = 9;

        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SemesterTestTooLow()
        {
            Student s1 = new Student(); //Arrange

            s1.Semester = 0;
        }

        [TestMethod()]
        
        public void GenderTestMale()
        {
            Student s1 = new Student(); //Arrange

            s1.Gender = Student.GenderType.Male; //act

        }

        [TestMethod()]

        public void GenderTestFemale()
        {
            Student s1 = new Student(); //Arrange

            s1.Gender = Student.GenderType.Female; //act

        }
    }
}