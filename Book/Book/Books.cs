using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Book
{
    public class Books
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }
    }
}