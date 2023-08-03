using PlaystationProject.Dtos;
using PlaystationProject.Dtos.Products;
using PlaystationProject.Interfaces.Repositories.General;
using PlaystationProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Interfaces.Repositories
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        Task<(List<Product>, int)> GetAllProductWithPagination(GridSearchDto paginationDto);
        Task<List<Product>> GetProductByCategory(string category);
    }
}
