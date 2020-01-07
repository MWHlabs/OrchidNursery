using OrchidModel.Entities;
using OrchidModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace OrchidModel.Repository
{
    public class CustomerRepositry : ICustomer
    {
        MyDbContext _myDbContext;

        public CustomerRepositry(MyDbContext dbContext)
        {
            _myDbContext = dbContext;
        }
        public void CreateCustomer(Customer customerobject)
        {
            _myDbContext.Customers.Add(customerobject);
            _myDbContext.SaveChanges();

        }

        public void DeleteCustomer(int ID)
        {
            var customer = _myDbContext.Customers.Where(c => c.RegnoID == ID).FirstOrDefault();
            _myDbContext.Customers.Remove(customer);
            _myDbContext.SaveChanges();
        }

        public ICollection<Customer> GetAllCustomer()
        {
            var customers = _myDbContext.Customers.ToList();
            return customers;
        }

        public Customer GetCustomerByID(int ID)
        {
            var customers = _myDbContext.Customers.Where(c => c.RegnoID == ID).SingleOrDefault();
            return customers;
        }

        public int UpdateCustomer(int ID, Customer customerobject)
        {
            var customers = _myDbContext.Customers.Where(c => c.RegnoID == ID).SingleOrDefault();
            if (customers == null)
            {
                return 0;
            }
            else
            {
                customers.EmpName = customerobject.EmpName;
                customers.EmpAddress = customerobject.EmpAddress;
                customers.NIC = customerobject.NIC;
                customers.TelephoneNo = customerobject.TelephoneNo;
                customers.password = customerobject.password;
                return 1;
                
            }
        }
        public Customer PostCustomer(Customer customer)
        {
            try
            {
                _myDbContext.Customers.Add(customer);
                _myDbContext.SaveChanges();
                return customer;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
