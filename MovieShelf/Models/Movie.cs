using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MovieShelf.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public int RunTime { get; set; }
        public string Genre { get; set; }
    }
}
