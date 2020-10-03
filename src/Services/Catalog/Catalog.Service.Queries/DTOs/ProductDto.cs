﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Service.Queries.DTOs
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ProductinStockDto Stock { get; set; }
    }
}
