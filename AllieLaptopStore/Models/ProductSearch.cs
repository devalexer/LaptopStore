using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AllieLaptopStore.Models
{
    public class ProductSearch
    {
        string apiUrl = "https://api.bestbuy.com/v1/products((categoryPath.id=abcat0502000))?apiKey=3z6a6dd2jyfjtrpkhdbsaayk&sort=bestSellingRank.asc&show=bestSellingRank,color,customerReviewAverage,image,name,onSale,percentSavings,regularPrice,salePrice,shortDescription,sku,thumbnailImage,longDescription&pageSize=100&format=json";
        string apiKey = "";
    }
}