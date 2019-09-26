using System;
using System.Collections.Generic;

namespace BlogMVC.Models.Entidades
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; } = "";
        public string Sobrenome { get; set; } = "";
        public string Email { get; set; } = "";
        public int TipoUsuario { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;

        public List<Post> Posts { get; set; }
    }
}
