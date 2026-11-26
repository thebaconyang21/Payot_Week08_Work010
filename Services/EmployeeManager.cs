using Payot_Week08_Work09.Interfaces;
using Payot_Week08_Work09.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payot_Week08_Work09.Services
{
    public class EmployeeManager 
    {
        private IEmployeeManager _repo;

        public EmployeeManager(IEmployeeManager repo)
        {
            _repo = repo;
        }

        public void AddEmployee(Employee e)
        {
            _repo.Save(e); //_repo -> interface variable
        }

        public Employee getEmployeeByID(int id)
        {
            return _repo.GetById(id);
        }

        public List<Employee> GetAllEmployees()
        {
            return _repo.GetEmployeeList();
        }
          
    }
}
