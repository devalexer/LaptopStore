using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AllieLaptopStore.Models
{
    public class Product
    {
        public int bestSellingRank { get; set; }
        public string color { get; set; }
        public double? customerReviewAverage { get; set; }
        public string image { get; set; }
        public string name { get; set; }
        public bool onSale { get; set; }
        public string percentSavings { get; set; }
        public double regularPrice { get; set; }
        public double salePrice { get; set; }
        public string shortDescription { get; set; }
        public int sku { get; set; }
        public string thumbnailImage { get; set; }
        public string longDescription { get; set; }
    }

    public class RootObject
    {
        public int from { get; set; }
        public int to { get; set; }
        public int currentPage { get; set; }
        public int total { get; set; }
        public int totalPages { get; set; }
        public string queryTime { get; set; }
        public string totalTime { get; set; }
        public bool partial { get; set; }
        public string canonicalUrl { get; set; }
        public List<Product> products { get; set; }
    }
}