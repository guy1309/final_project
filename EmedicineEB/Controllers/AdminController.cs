﻿using Microsoft.AspNetCore.Mvc;
using EmedicineEB.Controllers.Models;
using System.Data.SqlClient;

namespace EmedicineEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
            public class AdminController : ControllerBase
        {
            private readonly IConfiguration _configuration;
            public AdminController(IConfiguration configuration)
            {
                _configuration = configuration;
            }

        [HttpGet]
        [Route("medicines")]
        public Response GetMedicines()
        {
            DAL dal = new();
            SqlConnection connection = new(_configuration.GetConnectionString("EMedCS"));
            Response response = dal.getMedicines(connection);
            return response;
        }

        [HttpPost]
        [Route("addUpdateMedicine")]
        public Response addUpdateMedicine(Medicines medicines)
        {
            DAL dal = new DAL();
            SqlConnection connection = new(_configuration.GetConnectionString("EMedCS").ToString());
            Response response = dal.addUpdateMedicine(medicines, connection);
            return response;
        }

        [HttpGet]
        [Route("userList")]
        public Response userList()
        {
            DAL dal = new DAL();
            SqlConnection connection = new(connectionString: _configuration.GetConnectionString("EMedCS").ToString());
            Response response = dal.userList(connection);
            return response;
        }

        [HttpPost]
        [Route("updateFund")]
        public Response updateFund(Users users)
        {
            Response response = new Response();
            DAL dal = new DAL();
            SqlConnection connection = new SqlConnection(connectionString: _configuration.GetConnectionString("EMedCS").ToString());
            response = dal.updateFund(users, connection);
            return response;
        }

        [HttpPost]
        [Route("updateOrderStatus")]
        public Response updateOrderStatus(Orders order)
        {
            DAL dal = new DAL();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EMedCS").ToString());
            Response response = dal.updateOrderStatus(order, connection);
            return response;
        }

        [HttpPost]
        [Route("UploadFile")]
        public Response UploadFile([FromForm] FileModel fileModel)
        {
            Response response = new Response();
            try
            {
                string path = Path.Combine(@"C:\Users\guy13\OneDrive\Pictures", fileModel.FileName);
                using (Stream stream = new FileStream(path, FileMode.Create))
                {
                    fileModel.FormFile.CopyTo(stream);
                }
                response.StatusCode = 200;
                response.StatusMessage = "File uploaded";
            }
            catch (Exception ex)
            {
                response.StatusCode = 100;
                response.StatusMessage = "File upload failed" + ex.Message;
            }
            return response;
        }

        [HttpPost]
        [Route("cartList")]
        public Response cartList(Cart cart)
        {
            DAL dal = new DAL();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EMedCS").ToString());
            Response response = dal.cartList(cart, connection);
            return response;
        }


    }
}
