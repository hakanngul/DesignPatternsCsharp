using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace builder_pattern.Applications
{
    public class EmployeeBuilderM1
    {
        private EmployeeM1 Employee {get;set;}

        public EmployeeBuilderM1()
        {
            Employee = new();
        }

        public EmployeeBuilderM1 SetFullName(string fullName) {
            var arr = fullName.Split(' ');
            Employee.FirstName = arr[0];
            Employee.LastName = arr[1];
            return this;
        }

        public EmployeeBuilderM1 SetEmail(string email) {
            Employee.EmailAddress = email;
            return this;
        }

        public EmployeeBuilderM1 SetUserName(string userName) {
            Employee.UserName = userName;
            return this;
        }

        public EmployeeM1 Build() => Employee;
    }
}