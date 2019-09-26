using System;
using System.Collections.Generic;


namespace BlogMVC.Models.Entidades
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; } = "";
        public DateTime Created { get; set; } = DateTime.Now;

        public List<Post> Posts { get; set; }

    }
}
