using System.Collections.Generic;
using System.Threading.Tasks;
using Customer.Microservice.DataAccess.Abstract;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Customer.Microservice.DataAccess.Concrete
{
    public class MongoCustomerRepository : ConnectionToMongo,IMongoRepositoryBase<Entities.Customer>
    {
        private readonly IMongoCollection<Entities.Customer> _customerCollection;
        public MongoCustomerRepository(IConfiguration configuration) : base(configuration)
        {
            _customerCollection = GetConnection<Entities.Customer>(CustomerCollection);
        }

        public async Task<List<Entities.Customer>> GetAll()
        {
            var customers =  await _customerCollection.FindAsync(_ => true);
            return customers.ToList();

        }

        public async Task<Entities.Customer> GetById(string id)
        {
            var customer = await _customerCollection.FindAsync(c => c.Id == id);
            return customer.SingleOrDefault();
        }

        public async Task Create(Entities.Customer entity)
        {
            await _customerCollection.InsertOneAsync(entity);
        }

        public async Task Update(Entities.Customer entity)
        {
            var filter = Builders<Entities.Customer>.Filter.Eq("Id", entity.Id);
            await _customerCollection.ReplaceOneAsync(filter, entity);
        }

        public async Task Delete(Entities.Customer entity)
        {
            await _customerCollection.DeleteOneAsync(c => c.Id == entity.Id);
        }
    }
}
