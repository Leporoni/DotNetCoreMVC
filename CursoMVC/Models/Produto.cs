﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CursoMVC.Models
{
    public class Produto
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Descricao { get; set; }        

        public int Quantidade { get; set; }

        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }
    }
}
