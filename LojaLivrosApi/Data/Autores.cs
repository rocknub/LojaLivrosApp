using System;
using System.Collections.Generic;

namespace LojaLivrosApi.Data
{
    public partial class Autores
    {
        public int Id { get; set; }
        public string? PrimeiroNome { get; set; }
        public string? UltimoNome { get; set; }
        public string? Biografia { get; set; }
    }
}
