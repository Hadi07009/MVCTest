using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorld.ViewModel;

namespace HelloWorld.Controllers
{
    public class TestController : Controller
    {
        private Employee _objEmployee;
        private Customer _objCustomer;
        public string ReturnString()
        {
            return "Wellcome to MVC World. ";
        }
        public Customer CustomerInformation()
        {
            _objCustomer = new Customer();
            _objCustomer.Name = "Customer name 1";
            _objCustomer.Address = "Customer Address 1";
            return _objCustomer;
        }
        

        public string CustomerName()
        {
            _objCustomer = new Customer();
            _objCustomer.Name = "Customer name 1";
            _objCustomer.Address = "Customer Address 1";
            return _objCustomer.Name;

        }


        public class Customer
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
        public ActionResult EmployeeInformation()
        {
            _objEmployee = new Employee();
            _objEmployee.FirstName = "Jamilur";
            _objEmployee.LastName = "Reza";
            _objEmployee.Salary = 500;

            EmployeeViewModel objEmployeeViewModel = new EmployeeViewModel();
            objEmployeeViewModel.Salary =  _objEmployee.Salary.ToString();
            
            
            if (_objEmployee.Salary > 2000)
            {
                //objEmployee.SalaryColor = "yellow";
                objEmployeeViewModel.SalaryColor = "yellow";
                
            }
            else
            {
                //objEmployee.SalaryColor = "green";   
                objEmployeeViewModel.SalaryColor = "green";   
            }
            //ViewBag.Employee = objEmployee;
            //ViewData["Employee"] = objEmployee;            
            return View("MyView",objEmployeeViewModel);
        }

        public ActionResult ListOfEmployee()
        {
            _objEmployee = new Employee();
            _objEmployee.FirstName = "Salam";
            _objEmployee.LastName = "Ahemed";
            _objEmployee.Salary = 60000;
            List<Employee> stringList = new List<Employee>();
            stringList.Add(_objEmployee);
            stringList.Add(_objEmployee);
            stringList.Add(_objEmployee);
            EmployeeList objEmployeeList = new EmployeeList();
            objEmployeeList.ListOfEmployee = stringList;
            EmployeeListViewModel objEmployeeListViewModel = new EmployeeListViewModel();
            objEmployeeListViewModel.ListOfEmployee = objEmployeeList.ListOfEmployee;
            return View("ListOfEmployee", objEmployeeListViewModel);
 
        }
    }
}
