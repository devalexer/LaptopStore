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
        [HttpGet]
        public IHttpActionResult ProductList()
        {
            // Parses the input (parameters) 
            

            // Do the logic/Query the Datasource (meat) 
            var url = $"https://api.bestbuy.com/v1/products((categoryPath.id=abcat0502000))?apiKey=3z6a6dd2jyfjtrpkhdbsaayk&sort=bestSellingRank.asc&show=bestSellingRank,color,customerReviewAverage,image,name,onSale,percentSavings,regularPrice,salePrice,shortDescription,sku,thumbnailImage,longDescription&pageSize=100&format=json";
            var request = WebRequest.Create(url);
            var response = request.GetResponse();
            var rawResponse = String.Empty;

            using (var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8, true, 1024, true))
            {
                rawResponse = reader.ReadToEnd();
            }

            var data = JsonConvert.DeserializeObject<RootObject>(rawResponse);
           
            // Format the response 
            return Ok(data.products.Select(s => new { Name = s.name, Price = s.regularPrice }));

        }

        public List<Product> ProductListTopTen()
        {
            var url = $"https://api.bestbuy.com/v1/products((categoryPath.id=abcat0502000))?apiKey=3z6a6dd2jyfjtrpkhdbsaayk&sort=bestSellingRank.asc&show=bestSellingRank,color,customerReviewAverage,image,name,onSale,percentSavings,regularPrice,salePrice,shortDescription,sku,thumbnailImage,longDescription&pageSize=10&format=json";
            var request = WebRequest.Create(url);
            var response = request.GetResponse();
            var rawResponse = String.Empty;

            using (var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8, true, 1024, true))
            {
                rawResponse = reader.ReadToEnd();
            }

            var data = JsonConvert.DeserializeObject<RootObject>(rawResponse);

            return data.products;

        }


        //// GET api/<controller>
        //[HttpPost]
        //public async Task<IHttpActionResult> Index(RootObject ApiData)
        //{
        //    var url = $"https://api.bestbuy.com/v1/products((categoryPath.id=abcat0502000))?apiKey=3z6a6dd2jyfjtrpkhdbsaayk&sort=bestSellingRank.asc&show=bestSellingRank,color,customerReviewAverage,image,name,onSale,percentSavings,regularPrice,salePrice,shortDescription,sku,thumbnailImage,longDescription&pageSize=100&format=json";
        //    var request = WebRequest.Create(url);
        //    var response = await request.GetResponse();
        //    var rawResponse = String.Empty;

        //    using (var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8, true, 1024, true))
        //    {
        //        rawResponse = reader.ReadToEnd();
        //    }

        //    var product = JsonConvert.DeserializeObject<RootObject>(rawResponse);
        //    //var product = new List<Product>(rawProduct);

        //   return View(product);
        //}


        //public static Product GetProduct()
        //{
        //    var url = $"https://api.bestbuy.com/v1/products((categoryPath.id=abcat0502000))?apiKey=3z6a6dd2jyfjtrpkhdbsaayk&sort=bestSellingRank.asc&show=bestSellingRank,color,customerReviewAverage,image,name,onSale,percentSavings,regularPrice,salePrice,shortDescription,sku,thumbnailImage,longDescription&pageSize=100&format=json";
        //    var request = WebRequest.Create(url);
        //    var response = request.GetResponse();
        //    var rawResponse = String.Empty;

        //    using (var reader = new StreamReader(response.GetResponseStream()))
        //    {
        //        rawResponse = reader.ReadToEnd();
        //        //Console.WriteLine(rawResponse);
        //    }

        //    var product = JsonConvert.DeserializeObject<Product>(rawResponse);

        //    return product;
        //}


        //public static List<Product> GettaProduct()
        //{
        //    var url = $"https://api.bestbuy.com/v1/products((categoryPath.id=abcat0502000))?apiKey=3z6a6dd2jyfjtrpkhdbsaayk&sort=bestSellingRank.asc&show=bestSellingRank,color,customerReviewAverage,image,name,onSale,percentSavings,regularPrice,salePrice,shortDescription,sku,thumbnailImage,longDescription&pageSize=100&format=json";
        //    var request = WebRequest.Create(url);
        //    var response = request.GetResponse();
        //    var rawResponse = String.Empty;

        //    using (var reader = new StreamReader(response.GetResponseStream()))
        //    {
        //        rawResponse = reader.ReadToEnd();
        //        //Console.WriteLine(rawResponse);
        //    }

        //    var product = JsonConvert.DeserializeObject<Product>(rawResponse);

        //    return product;
        //}

    }
}