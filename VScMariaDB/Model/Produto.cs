using System.ComponentModel.DataAnnotations;

namespace VScMariaDB.Model
{
    public class Produto
    {

        public int id { get; set; }

        [MaxLength(100)]
        public string NomeProduto { get; set; }
        [MaxLength(500)]
        public string? Descricao { get; set; }

        public decimal preco { get; set; }

        public bool Disponivel { get; set; }

        public bool Novidade { get; set; }
        [MaxLength(200)]
        public string? Imagem { get; set;}
    }
}
