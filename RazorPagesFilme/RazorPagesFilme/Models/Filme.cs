using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RazorPagesFilme.Models
{
    public class Filme
    {
        public int ID { get; set; }

        [Display(Name = "Título")]
        public string Titulo { get; set; }


        [Display(Name = "Data de  Lançamento")]
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }

        [Display(Name = "Gênero")]
        public string Genero { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        //[Display(Name = "Avaliação")]
        //public String Avaliacao { get; set; }


    }
}
