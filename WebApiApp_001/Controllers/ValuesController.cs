using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiApp_001.Models;

namespace WebApiApp_001.Controllers
{
    public class ValuesController : ApiController
    {
        private static IHubContext _hubContext = GlobalHost.ConnectionManager.GetHubContext<CustomerHub>();

        private static IList<Customer> _customers;

        public ValuesController()
        {
            if (_customers == null)
                _customers = new List<Customer>();
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            //Запись в БД

            //тут происходит уведомление клиентов привязанных к хабу
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
