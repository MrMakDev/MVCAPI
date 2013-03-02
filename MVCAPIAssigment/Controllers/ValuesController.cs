using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace MVCAPIAssigment.Controllers
{
    public class ValuesController : ApiController
    {


        // GET api/values/5
        public IEnumerable<string> Get(string id)
        {
            HomeController obj = new HomeController();

            //return obj.GetTweets(id);
            return obj.GetTweets(id).Select(p=>p.Text).ToList();
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}