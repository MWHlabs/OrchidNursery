using OrchidModel.Entities;
using OrchidModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrchidModel.Repository
{
    public class EmployeeRepository : IEmployee
    {
        MyDbContext _myDbContext;

        public EmployeeRepository (MyDbContext dbContext)
        {
            _myDbContext = dbContext;
        }
        public void CreateEmployee(Employee employeeobject)
        {
            _myDbContext.Employes.Add(employeeobject);
            _myDbContext.SaveChanges();
        }

        public void DeleteEmployee(int ID)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeByID(int ID)
        {
            var employes = _myDbContext.Employes.Where(e => e.EmplyID == ID).SingleOrDefault();
            return employes;
        }

        public ICollection<Employee> GetEmployees()
        {
            var employes = _myDbContext.Employes.ToList();
            return employes;
        }

        public int UpdateEmployee(int ID, Employee employeeobject)
        {
            throw new NotImplementedException();
        }
        public Employee PostEmployee(Employee employes)
        {
            try
            {
                _myDbContext.Employes.Add(employes);
                _myDbContext.SaveChanges();
                return employes;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
