﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [Display]
        public string Descricao { get; set; }

        //public List<Produto> Produtos { get; set; }
    }
}
