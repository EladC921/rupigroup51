﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{

    public class SeriesController : ApiController
    {
        // GET recommendations OR pref of user
        public IEnumerable<Serie> Get(int uId, string type)
        {
            Serie ser = new Serie();
            return ser.Get(uId, type);
        }      
               
        // GET if user is a fan of series
        [Route("api/Series/checkPref/{uId}/{sId}")]
        public int Get(int uId, int sId)
        {
            Serie ser = new Serie();
            return ser.CheckPref(uId, sId);
        }      

        // POST Series
        public int Post([FromBody] Serie ser)
        { 
            ser.Insert();
            return 1;
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