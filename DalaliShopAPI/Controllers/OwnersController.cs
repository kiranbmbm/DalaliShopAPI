using DalaliShopBusLogic;
using DalaliShopCommon;
using DalaliShopDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Web.Http;

namespace DalaliShopAPI.Controllers
{
    [Route("API/Owners/{action}")]
    public class OwnersController : ApiController
    {
        //OwnersLogic ol = new OwnersLogic();

        private static IOwnersRepository _repository;
        public OwnersController() : this(new OwnersRepository())
        {
        }
        public OwnersController(IOwnersRepository repository)
        {
            _repository = repository;
        }

        private Lazy<OwnersLogic> ownersLogicObj = new Lazy<OwnersLogic>(() => new OwnersLogic(_repository));

        public OwnersLogic OwnersLogicObj
        {
            get { return ownersLogicObj.Value; }

        }
        public IHttpActionResult GetAllOwners()
        {
            DataSet results = new DataSet();
            try
            {
                //int a = 1, b = 0, c;
                ////c = a / b; 
                //results = OwnersLogicObj.GetAllOwners(); 
                return Ok("value");
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

        [HttpPost]
        public IHttpActionResult PostOwner(OwnerModel ownerModel)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    OwnersLogicObj.PostOwner(ownerModel); 
                    return Ok();
                }
               else
                {
                    return Ok("InValid Model State in the WEBAPI  " );
                }
            }
            catch (Exception ee)
            {
                return Ok("Falied to Execute the WEBAPI  " + ee);
            }
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public IHttpActionResult DeleteOwner(int id)
        {
            try
            {
              
                OwnersLogicObj.DeleteOwner(id);
                return Ok();
            }
            catch (Exception ee)
            {
                return Ok("Falied to Execute the WEBAPI  " + ee);
            }
        }
    }
}