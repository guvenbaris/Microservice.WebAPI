using System.Collections.Generic;

namespace Customer.Microservice.DataOperations
{
    public interface ICustomerRepository
    {
        void Add(Customer entity);
        void Update(Customer entity);
        List<Customer> GetAll();
        Customer GetById(int id);

    }
}

