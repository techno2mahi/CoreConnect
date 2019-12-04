using System;
using System.Collections.Generic;
using System.Text;

namespace CoreConnect.Contracts.Models.Common
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }

    }
}
