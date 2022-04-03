using System.Collections.Generic;
using System.Threading.Tasks;

namespace Customer.Microservice.Services.Abstract
{
    public interface ICustomerService
    {
        Task<List<Entities.Customer>> GetAll();
        Task<Entities.Customer> GetById(string id);
        Task Create(Entities.Customer entity);
        Task Update(Entities.Customer entity);
        Task Delete(string id);
    }
}
