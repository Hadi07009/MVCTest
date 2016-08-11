using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorld.ViewModel
{
    public class EmployeeListViewModel
    {
        private List<Employee> _listOfEmployee;

        public List<Employee> ListOfEmployee
        {
            get { return _listOfEmployee; }
            set { _listOfEmployee = value; }
        }
    }
}