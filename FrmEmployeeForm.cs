using Payot_Week08_Work09.DBContext;
using Payot_Week08_Work09.Interfaces;
using Payot_Week08_Work09.Models;
using Payot_Week08_Work09.Services;
using System;
using System.Windows.Forms;

namespace Payot_Week08_Work09
{
    public partial class FrmEmployeeForm : Form
    {

        IEmployeeManager MySQLContext = new MySQLEmployeeContext();
        public FrmEmployeeForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EmployeeManager empMgr = new EmployeeManager(MySQLContext); 

            RegularEmployee emp1 = new RegularEmployee()
            {
                Lastname = txtLastname.Text,
                Firstname = txtFirstname.Text,
                Middlename = txtMiddlename.Text,
                Gender = txtGender.Text,
                Address = txtAddress.Text,
                Birthdate = dtBirthday.Value,
            };

            empMgr.AddEmployee(emp1);
        }


    }
}
