using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorld.Models
{
    public class Employee
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        private double _salary;

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        //private string _salaryColor;

        //public string SalaryColor
        //{
        //    get { return _salaryColor; }
        //    set { _salaryColor = value; }
        //}
    }
}