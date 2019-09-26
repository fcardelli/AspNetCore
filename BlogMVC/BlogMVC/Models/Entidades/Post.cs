using System;
using System.Collections.Generic;


namespace BlogMVC.Models.Entidades
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; } = "";
        public string Content { get; set; } = "";
        public DateTime Created { get; set; } = DateTime.Now;

        //Usuario Foreign Key
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        //Blog Foreign Key
        public int BlogId { get; set; }
        public Blog Blog { get; set; }

    }
}
