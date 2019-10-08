using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MichuAPI.Controllers
{
    public class RecetteController : ApiController
    {
        // GET: api/Recette
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Recette/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Recette
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Recette/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Recette/5
        public void Delete(int id)
        {
        }
    }
}
