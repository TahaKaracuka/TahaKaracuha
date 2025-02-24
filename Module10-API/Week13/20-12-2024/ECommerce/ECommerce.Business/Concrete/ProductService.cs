using AutoMapper;
using ECommerce.Business.Abstract;
using ECommerce.Data.Abstract;
using ECommerce.Entity.Concrete;
using ECommerce.Shared.DTOs;
using ECommerce.Shared.ResponseDTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Product> _productRepository;

        public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _productRepository = _unitOfWork.GetRepository<Product>();
        }

        public async Task<ResponseDTO<ProductDTO>> AddAsync(ProductCreateDTO productCreateDTO)
        {
            var product = _mapper.Map<Product>(productCreateDTO);
            await _productRepository.AddAsync(product);
            var result = await _unitOfWork.SaveChangesAsync();
            if (result <= 0)
            {
                return ResponseDTO<ProductDTO>.Fail("Bir sorun oluştu", StatusCodes.Status500InternalServerError);
            }
            // Artık Product veri tabanına kaydedildiği için bir Id değerine sahip. Şimdi ProductCategory işlemlerini yapabiliriz.
            product.ProductCategories =
                productCreateDTO.CategoryIds.Select(cId => new ProductCategory
                {
                    ProductId= product.Id,
                    CategoryId=cId
                }).ToList();
            _productRepository.Update(product);
            result = await _unitOfWork.SaveChangesAsync();
            if (result <= 0)
            {
                return ResponseDTO<ProductDTO>.Fail("Bir sorun oluştu", StatusCodes.Status500InternalServerError);
            }
            var productDTO = _mapper.Map<ProductDTO>(product);
            return ResponseDTO<ProductDTO>.Success(productDTO, StatusCodes.Status201Created);
        }

        public async Task<ResponseDTO<NoContent>> DeleteAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null)
            {
                return ResponseDTO<NoContent>.Fail("Ürün bulunamadığı için işlem tamamlanamadı!", StatusCodes.Status404NotFound);
            }
            _productRepository.Delete(product);
            var result = await _unitOfWork.SaveChangesAsync();
            if (result <= 0)
            {
                return ResponseDTO<NoContent>.Fail("Bir sorun oluştu", StatusCodes.Status500InternalServerError);
            }
            return ResponseDTO<NoContent>.Success(StatusCodes.Status200OK);
        }

        public async Task<ResponseDTO<IEnumerable<ProductDTO>>> GetAllAsync()
        {
            var products = await _productRepository.GetAllAsync();
            if(products == null)
            {
                return ResponseDTO<IEnumerable<ProductDTO>>.Fail("Bir sorun oluştu!", StatusCodes.Status500InternalServerError);
            }
            //if (products?.Count() == 0)
            if(!products.Any())
            {
                return ResponseDTO<IEnumerable<ProductDTO>>.Fail("Hiç ürün bulunamadı!",StatusCodes.Status404NotFound);
            }
            var productDTOs = _mapper.Map<IEnumerable<ProductDTO>>(products);
            return ResponseDTO<IEnumerable<ProductDTO>>.Success(productDTOs, StatusCodes.Status200OK);
        }

        public Task<ResponseDTO<IEnumerable<ProductDTO>>> GetAllAsync(bool? isActive)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDTO<IEnumerable<ProductDTO>>> GetAllWithCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDTO<ProductDTO>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDTO<IEnumerable<ProductDTO>>> GetByCategoryAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDTO<int>> GetCountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDTO<int>> GetCountAsync(bool? isActive)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDTO<int>> GetCountByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDTO<ProductDTO>> GetWithCategoriesAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDTO<NoContent>> UpdateAsync(ProductUpdateDTO productUpdateDTO)
        {
            throw new NotImplementedException();
        }
    }
}










/*
    * Business katmanına Service katmanı dendiğini de görebilirsiniz.
    * Abstract içindeki interface'lere IEntityNameService ismi sıkça verilirken, Concrete içindeki class'lara EntityNameService, EntityNameManager gibi isimler verildiğini görebilirsiniz.
*/
