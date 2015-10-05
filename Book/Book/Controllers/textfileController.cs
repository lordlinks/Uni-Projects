using System;
using System.Collections.Generic;
using System.IO;
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
            new Books {Id="0470376848", Name="Service Oriented Architecture (SOA) For Dummies", Author="Judith Hurwitz", Year=2009, Price=25.27F,Stock=3},
            new Books {Id="0470476248", Name="Service-Oriented Architecture: Concepts Technology and Design", Author="Thomas Erl", Year=2005, Price=46.36F,Stock=2},
            new Books {Id="0485965215", Name="Service-Oriented Architecture: A Field Guide to Integrating XML and Web Services", Author="Thomas Erl", Year=2007, Price=43.16F,Stock=1},
            new Books {Id="0456235975", Name="SOA in Practice: The Art of Distributed System Design", Author="Nicolai M. Josuttis", Year=2007, Price=24.59F,Stock=1},
            new Books {Id="0487965321", Name="SOA Made Simple", Author="Lonneke Dikmans", Year=2012, Price=13.72F,Stock=2},
            new Books {Id="0412359687", Name="SOA with REST: Principles Patterns & Constraints for Building Enterprise Solutions with REST", Author="Thomas Erl", Year=2012, Price=48.25F,Stock=3}
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
