using DalaliShopBusLogic;
using DalaliShopDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DalaliShopAPI.Controllers
{
    [Route("API/Owners/{action}")]
    public class OwnersController : ApiController
    {
        OwnersLogic ol = new OwnersLogic();
        public IHttpActionResult GetAllOwners()
        {
            DataSet results = new DataSet();
            try
            {
                //int a = 1, b = 0, c;
                //c = a / b; 
                results = ol.GetAllOwners(); 
                return Ok(results);
            }
            catch(Exception ee )
            {
                return Ok("Falied to Execute the WEBAPI  " + ee); 
            }
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}