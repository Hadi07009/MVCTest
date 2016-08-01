using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class TestController : Controller
    {
        public string ReturnString()
        {
            return "Wellcome to MVC World. ";
        }

        public Employee EmployeeInformation()
        {
            Employee objEmployee = new Employee();
            objEmployee.Name = "employee name 1";
            objEmployee.Address = "employee Address 1";
            return objEmployee;
        }
        

        public string EmployeeName()
        {
            Employee objEmployee = new Employee();
            objEmployee.Name = "employee name 1";
            objEmployee.Address = "employee Address 1";
            return objEmployee.Name;

        }


        public class Employee
        {
            private string _name;

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }
            private string _address;

            public string Address
            {
                get { return _address; }
                set { _address = value; }
            }
            public override string ToString()
            {
                return this.Name + " & " + this.Address;
            } 

        }

        public ActionResult GetView()
        {
            return View("MyView");
        }


    }
}
