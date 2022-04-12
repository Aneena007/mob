using Microsoft.AspNetCore.Mvc;
using ProductCatalog.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<Product> product = null;
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:11377/api/Product");
                var responseTask = client.GetAsync("product");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readJob = result.Content.ReadAsAsync<IList<Product>>();
                    readJob.Wait();
                    product = readJob.Result;
                    List<string> Name = new List<string>();
                    foreach (Product name in product)
                    {
                        Name.Add(name.Name);
                    }
                    ViewBag.list = Name;
                }

            }   
       
            return View(product);
        }
       
    }
}
