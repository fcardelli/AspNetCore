﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrudBasicoMVC.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Display(Description = "Código")]
        public int Id { get; set; }

        [Display(Description = "Nome do usuário")]
        public string Nome { get; set; }

        [Display(Description = "Idade")]
        public string Idade { get; set; }

        [Display(Description = "Tipo de usuário")]
        public int Tipo { get; set; }


    }
}
 