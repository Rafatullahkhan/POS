﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Techspiders.Pos.DAL.Entities;
namespace Techspiders.POS.WEBUI.Controllers
{
    public class HomeController : Controller
    {
        string Baseurl = "http://localhost:63000/Api/Customer/";
        public async Task<ActionResult> Index()
        {
            List<Customers> CustInfo = new List<Customers>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("api/Customer/GetCustomers");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var CustResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    CustInfo = JsonConvert.DeserializeObject<List<Customers>>(CustResponse);

                }
                //returning the employee list to view  
                return View(CustInfo);
            }
        }

     
    }
}