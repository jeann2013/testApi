using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace JWTAuthentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : Controller
    {
         

        [HttpPost]
        [Authorize]

        //public ActionResult<Books[]> Post([FromBody] Books books)
        public async Task<IActionResult> DataAsync([FromBody] Books books)
        {
            IActionResult response = Unauthorized();

            var myBook = new List<Books>();
            myBook.Add(books);           
            response = Ok(new { book = myBook });

            return response;
        }       

    }
}
