using OrchidModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrchidModel.Interfaces
{
    public interface ICustomer
    {
        ICollection<Customer> GetAllCustomer();

        Customer GetCustomerByID(int ID);
        //void CreateCustomer(Customer)
    }
}
