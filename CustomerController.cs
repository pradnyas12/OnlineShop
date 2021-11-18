using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ShoppingAPI.Models;
using ShoppingBAL;
using ShoppingDAL;
using System.Web.Http.Cors;


namespace ShoppingAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CustomerController : ApiController
    {
        public string Get()
        {
            return "value";
        }



        [HttpPost]
        public IHttpActionResult CustomerInsert(CustomerModel cust)
        {
            CustomerDAL ds = new CustomerDAL();
            CustomerBAL ba = new CustomerBAL();

            ba.EmailId = cust.EmailId;
            ba.Password = cust.Password;
            ba.FirstName = cust.FirstName;
            ba.LastName = cust.LastName;
            ba.MobileNo = cust.MobileNo;
            ba.City = cust.City;

            string s1 = ds.AddCustomer(ba);
            return Ok(new { status = 200, isSuccess = true, message = "ur logged sucess", });

        }
        [HttpPost]
        public IHttpActionResult CartInsert(InsertCartModel cart)
        {
            CustomerDAL ds = new CustomerDAL();
            CartBAL bal = new CartBAL();

            bal.Quantity = cart.Quantity;
            bal.ProductId = cart.ProductId;
            

            string s1 = ds.AddToCart(bal);
            return Ok(new { status = 200, isSuccess = true, message = "ur logged sucess", });

        }

        [HttpPut]
        public IHttpActionResult CartUpdate(UpdateCartModel cart)
        {
            CustomerDAL ds = new CustomerDAL();
            CartBAL bal = new CartBAL();

            bal.Quantity = cart.Quantity;
            bal.ProductId = cart.ProductId;


            string s1 = ds.UpdateCart(bal);
            return Ok(new { status = 200, isSuccess = true, message = "ur logged sucess", });

        }


        [HttpDelete]

        public IHttpActionResult CartDelete(DeleteCartModel cart)
        {
            CustomerDAL ds = new CustomerDAL();
            CartBAL bal = new CartBAL();
            bal.ProductId = cart.ProductId;


            string s1 = ds.DeleteCart(bal);
            return Ok(new { status = 200, isSuccess = true, message = "ur product is deleted", });

        }
    }
}
