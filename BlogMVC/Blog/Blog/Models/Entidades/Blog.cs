using System;
using System.Collections.Generic;

namespace Blog.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; } = "";
        public DateTime Created { get; set; } = DateTime.Now;

        public List<Post> Posts { get; set; }

    }
}

  
