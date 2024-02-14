﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace VScMariaDB.Model
{
    public class Produto
    {

        public int Id { get; set; }

        [MaxLength(100)]
        public string NomeProduto { get; set; }
        [MaxLength(500)]
        public string? Descricao { get; set; }

        [Precision(10,2)]
        public decimal Preco { get; set; }

        public bool Disponivel { get; set; }

        public bool Novidade { get; set; }
        [MaxLength(200)]
        public string? Imagem { get; set;}
    }
}