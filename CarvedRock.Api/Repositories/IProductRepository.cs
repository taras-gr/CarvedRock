using CarvedRock.Api.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarvedRock.Api.Repositories
{
    public interface IProductRepository
    {
        public Task<List<Product>> GetAll();
    }
}
