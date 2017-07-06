using AllieLaptopStore.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace AllieLaptopStore.Controllers
{
    public class ProductApiController : ApiController
    {

        public static Product GetProduct()
        {
            var url = $"https://api.bestbuy.com/v1/products((categoryPath.id=abcat0502000))?apiKey=3z6a6dd2jyfjtrpkhdbsaayk&sort=bestSellingRank.asc&show=bestSellingRank,color,customerReviewAverage,image,name,onSale,percentSavings,regularPrice,salePrice,shortDescription,sku,thumbnailImage,longDescription&pageSize=100&format=json";
            var request = WebRequest.Create(url);
            var response = request.GetResponse();
            var rawResponse = String.Empty;

            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                rawResponse = reader.ReadToEnd();
                //Console.WriteLine(rawResponse);
            }

            var product = JsonConvert.DeserializeObject<Product>(rawResponse);

            return product;
        }

        //// GET api/<controller>
        //public List<Product> Get()
        //{
        //    var url = $"https://api.bestbuy.com/v1/products((categoryPath.id=abcat0502000))?apiKey=3z6a6dd2jyfjtrpkhdbsaayk&sort=bestSellingRank.asc&show=bestSellingRank,color,customerReviewAverage,image,name,onSale,percentSavings,regularPrice,salePrice,shortDescription,sku,thumbnailImage,longDescription&pageSize=100&format=json";
        //    var request = WebRequest.Create(url);
        //    var response = request.GetResponse();
        //    var rawResponse = String.Empty;
         
        //    using (var reader = new StreamReader(response.GetResponseStream()))
        //    {
        //        rawResponse = reader.ReadToEnd();
        //        Console.WriteLine(rawResponse);
        //    }

        //    var rawProduct = JsonConvert.DeserializeObject<RootObject>(rawResponse);
        //    var product = new List<Product>(rawProduct);

        //    return product;
        //}


    }
}