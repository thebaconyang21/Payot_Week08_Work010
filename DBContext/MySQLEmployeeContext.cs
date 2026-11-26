using Payot_Week08_Work09.Interfaces;
using Payot_Week08_Work09.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payot_Week08_Work09.DBContext
{
    public class MySQLEmployeeContext : IEmployeeManager
    {
        public Employee GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployeeList()
        {
            throw new NotImplementedException();
        }

        public void Save(Employee e)
        {
            MessageBox.Show(
                $"Employee {e.Firstname} {e.Lastname} saved (Demo only).",
                "New Employee",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
             
        }



        
    }
}
