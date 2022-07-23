using System;
using System.Collections.Generic;

namespace LojaLivrosApi.Data
{
    public partial class Livros
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public int? Ano { get; set; }
        public string? Isbn { get; set; }
        public string? Resumo { get; set; }
        public string? Imagem { get; set; }
        public decimal? Valor { get; set; }
        public int? AutorId { get; set; }
    }
}
