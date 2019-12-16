using OrchidModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrchidModel.Interfaces
{
    public interface IEmployee
    {
        ICollection<Employee> GetEmployees();

        Employee GetEmployeeByID(int ID);
        void CreateEmployee(Employee employeeobject);
        int UpdateEmployee(int ID, Employee employeeobject);
        void DeleteEmployee(int ID);


    }
}
