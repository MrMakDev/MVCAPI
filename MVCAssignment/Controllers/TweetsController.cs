using Core.Domain;
using CoreServiceMongo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml.Linq;
using System.Web.Mvc;


namespace MVCAssignment.Controllers
{
    public class TweetsController : ApiController
    {
        
        public IEnumerable<string> Search(string query)
        {
            TweetController obj = new TweetController();
            return obj.GetTweets(query).Select(p => p.Text).AsEnumerable();
           
        }
    }
}
