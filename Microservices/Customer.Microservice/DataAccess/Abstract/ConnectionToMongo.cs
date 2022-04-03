using System;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Customer.Microservice.DataAccess.Abstract
{
    public class ConnectionToMongo : BaseMongoCollection
    {
        private readonly  IConfiguration _configuration;

        public ConnectionToMongo(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IMongoCollection<T> GetConnection<T>(in string collection)
        {
            var client = new MongoClient(_configuration["mongo:connection"]);
            var db = client.GetDatabase(_configuration["mongo:database"]);
            return db.GetCollection<T>(collection);
        }
    }
}
