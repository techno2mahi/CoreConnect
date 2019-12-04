using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Description;
using CoreConnect.Contracts.Models.Common;
using CoreConnect.Contracts.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreConnect.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [Route("~/api/products")]
        [ResponseType(typeof(ProductListResponse))]
        public ProductListResponse GetAllProducts()
        {
            var resp = new ProductListResponse();
            IList<ProductModel> products = new List<ProductModel>();
            products.Add(new ProductModel
            {
                ProductId = 1,
                ProductName = "Test Product One",
                ProductDescription = "Test Product One"
            });
            products.Add(new ProductModel
            {
                ProductId = 1,
                ProductName = "Test Product Two",
                ProductDescription = "Test Product Two"
            });
            resp.Products.AddRange(products);
            resp.TotalCount = resp.Products.Count;
            return resp;
        }
    }
}