using CoreConnect.Contracts.Models.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreConnect.Contracts.Response
{
    class ProductResponses
    {
    }

    public class ProductListResponse
    {
        public ProductListResponse()
        {
            Products = new List<ProductModel>();
        }
        public List<ProductModel> Products { get; set; }
        public int TotalCount { get; set; } 
    }
}
