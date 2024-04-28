using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace JWTAuthentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        [Authorize]
        public ActionResult<string> Get()
        {
            var currentUser = HttpContext.User;
            int spendingTimeWithCompany = 0;

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var responseGet = client.GetAsync("https://jsonplaceholder.typicode.com/todos").Result;
                string content = responseGet.Content.ReadAsStringAsync().Result;
                return content;

            }
       
        }

    }
}
