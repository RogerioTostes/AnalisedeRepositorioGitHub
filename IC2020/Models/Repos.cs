using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IC2020.Models
{
    public class Item
    {
        public string url { get; set; }
        public string tag_name { get; set; }
        public DateTime published_at { get; set; }
        public Author author { get; set; }
    }

    public class Author
    {
        public string login { get; set; }
    }
    public class Repos
    {
        public List<Item> items { get; set; }
    }


}
