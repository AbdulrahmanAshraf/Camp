using Microsoft.EntityFrameworkCore;
using PlaystationProject.Dtos;
using PlaystationProject.Dtos.Products;
using PlaystationProject.Interfaces.Repositories;
using PlaystationProject.Interfaces.Repositories.General;
using PlaystationProject.Models;
using PlaystationProject.Repositories.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(PlayStationDbContext playStationDb) : base(playStationDb)
        {

        }
        public async Task<(List<Product>, int)> GetAllProductWithPagination(GridSearchDto paginationDto)
        {
            var products = _playStationDbContext.Products.OrderByDescending(a => a.Create_Date);

            if (!string.IsNullOrEmpty(paginationDto.SearchName)) products = products.Where(a => a.Name.Contains(paginationDto.SearchName)).OrderByDescending(a => a.Create_Date);
            int length = products.Count();
            if (paginationDto.PageNumber == -1) return (await products.Include(a => a.MasterDataCode).ToListAsync(), length);
            return (await products.Skip((paginationDto.PageNumber - 1) * paginationDto.PageSize).Take(paginationDto.PageSize).Include(a=>a.MasterDataCode).ToListAsync(), length);

        }

        public async Task<List<Product>> GetProductByCategory(string category)
        {
            var products = _playStationDbContext.Products.Where(a=>a.Category==category&&a.Quantity>0).OrderByDescending(a => a.Create_Date);
            return await products.ToListAsync();
        }
    }
}
