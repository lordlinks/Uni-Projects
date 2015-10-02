using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Book.Controllers
{
    public class textfileController : ApiController
    {
        List<Books> books = new List<Books>
        {
            //product inserts here
        };

        public IHttpActionResult GetAllBooks()
        {
            return Ok(books);
        }

        public IHttpActionResult GetBook(string id)
        {
            var book = books.FirstOrDefault((x) => x.Id == id);
            if (book == null)
            {
                //do something with nothing values
            }
            return Ok(books);
        }

        // GET: api/textfile
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/textfile/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/textfile
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/textfile/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/textfile/5
        public void Delete(int id)
        {
        }
    }
}
