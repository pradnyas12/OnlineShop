using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BalLibrary;
using DalLibrary;
using System.Web.Http.Cors;


namespace WebApplication1.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class CustomerController : ApiController
    {

        public string Get()
        {
            return "value";
        }

        [HttpPost]
        public IHttpActionResult Customer(CustomerBAL ba)
        {
            DALlayer ds = new DALlayer();
            bool ans = ds.CustCheck(ba);
            if (ans == false)
            {
                return Ok(new { status = 401, isSuccess = false, message = "Invalid user", });

            }
            else
            {
                return Ok(new { status = 200, isSuccess = true, message = "Valid user" });

            }

        }
    }
}