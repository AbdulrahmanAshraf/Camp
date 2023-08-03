using PlaystationProject.Dtos;
using PlaystationProject.Dtos.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Interfaces.Services
{
   public interface IProductService
    {
        Task<ServiceResponse<int>> AddEditProduct(AddEditProductDto addEditProductDto, string userFullName);
        Task<ServiceResponse<List<DropDown>>> GetAllProductCategories();
        Task<ServiceResponse<AddEditProductDto>> GetProductById(Guid id);
        Task<ServiceResponse<int>> DeleteProduct(Guid id, string userFullName);
        Task<ServiceResponse<int>> AddNewQuentityToProduct(AddNewQuentityToProductDto addNewQuentity, string userFullName);

        Task<ServiceResponse<(List<GetProductDto>, int)>> GetAllProducts(GridSearchDto paginationDto);
        Task<ServiceResponse<List<GetProductByCategoryDto>>> GetProductByCategory(string category);


   }
}
