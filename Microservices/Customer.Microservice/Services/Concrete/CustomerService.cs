using System.Collections.Generic;
using System.Threading.Tasks;
using Customer.Microservice.DataAccess.Concrete;
using Customer.Microservice.Services.Abstract;

namespace Customer.Microservice.Services.Concrete
{
    public class CustomerService : ICustomerService
    {
        private readonly MongoCustomerRepository _customerRepository;

        public CustomerService(MongoCustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<List<Entities.Customer>> GetAll()
        {
            return await _customerRepository.GetAll();
        }

        public async Task<Entities.Customer> GetById(string id)
        {
            return await _customerRepository.GetById(id);
        }

        public async Task Create(Entities.Customer entity)
        {
            await _customerRepository.Create(entity);
        }

        public async Task Update(Entities.Customer entity)
        {
            await _customerRepository.Update(entity);
        }

        public async Task Delete(string id)
        {
            var customer = await _customerRepository.GetById(id);
            await _customerRepository.Delete(customer);
        }
    }
}
