using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TakapoWebSite.Models
{
    public class Product
    {
        public Product()
        {
            ProductDetails = new List<ProductDetail>();
        }
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string ImageAlt { get; set; }
        public string ImageTitle { get; set; }
        public string ImagePassage { get; set; }
        public List<ProductDetail> ProductDetails { get; set; }
        public List<ProductDetail> CompleteInfo { get; set; }
    }
    public class ProductDetail
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Passage { get; set; }
    }
}
