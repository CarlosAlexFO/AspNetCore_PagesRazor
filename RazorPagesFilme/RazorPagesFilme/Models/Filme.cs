using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesFilme.Models
{
    public class Filme
    {
        public int ID { get; set; }
        public string Titulo { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }
        public string Genero { get; set; }
        public decimal Preco { get; set; }

    }
}
