using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmedicineEB.Controllers.Models;
using System.Data.SqlClient;
using System.Text.Json.Nodes;

namespace EmedicineEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class MedicinesController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public MedicinesController(IConfiguration configuration)
        {
            _configuration = configuration;

        }

        [HttpPost]
        [Route("addToCart")]
        public Response addToCart(Cart cart)
        {
            DAL dal = new DAL();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EMedCS").ToString());
            Response response = dal.addToCart(cart, connection);
            return response;
        }

        [HttpPost]
        [Route("removeFromCart")]
        public Response removeFromCart(Cart cart)
        {
            DAL dal = new DAL();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EMedCS").ToString());
            Response response = dal.removeFromCart(cart, connection);
            return response;
        }

        [HttpPost]
        [Route("placeOrder")]
        public Response placeOrder(Users users)
        {
            DAL dal = new DAL();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EMedCS").ToString());
            Response response = dal.placeOrder(users, connection);
            return response;
        }

        [HttpPatch]
        [Route("setquantity")]
        public Response SetQuantity([FromBody] JsonObject model)
        {
            var cartItemID = int.Parse(model["cartItemID"].ToString());
            var quantity = int.Parse(model["quantity"].ToString());
            DAL dal = new();
            SqlConnection conn = new(_configuration.GetConnectionString("EMedCS").ToString());
            var response = dal.updateQuantity(cartItemID, quantity, conn);
            return response;
        }


        [HttpPost]
        [Route("orderList")]
        public Response orderList(Users users)
        {
            DAL dal = new DAL();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EMedCS").ToString());
            Response response = dal.OrderList(users, connection);
            return response;
        }
    }
}
