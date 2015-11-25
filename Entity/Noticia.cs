using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GEC.FastService.Entity
{
    public class Noticia
    {
        public int id { get; set; }

        public string title { get; set; }
        
        public string link { get; set; }

        public string description { get; set; }

        public string category { get; set; }
        
        public DateTime pubDate { get; set; }

    }
}