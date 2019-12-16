using OrchidModel.Entities;
using OrchidModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrchidModel.Repository
{
    public class EmployeeRepository : IEmployee
    {
        public void CreateEmployee(Employee employeeobject)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(int ID)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeByID(int ID)
        {
            throw new NotImplementedException();
        }

        public ICollection<Employee> GetEmployees()
        {
            throw new NotImplementedException();
        }

        public int UpdateEmployee(int ID, Employee employeeobject)
        {
            throw new NotImplementedException();
        }
    }
}
