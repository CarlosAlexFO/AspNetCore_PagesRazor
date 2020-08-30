using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesFilme.Models
{
    public class Filme
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Informe Nome do Filme!")]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Informe a Data de Lançamento do Filme!")]
        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }


        [Required(ErrorMessage = "Informe Gênero do Filme!")]
        [StringLength(30)]
        [Display(Name = "Gênero")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "Informe Valor do Filme!")]
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "Informe a Classificação do Filme!")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Display(Name = "Classificação")]
        public string Classificacao { get; set; }

    }
}
