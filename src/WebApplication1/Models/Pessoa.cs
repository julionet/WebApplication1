using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Pessoa
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Nome { get; set; }

        [Display(Name ="Data de Nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime? DataNascimento { get; set; }

        [Display(Name = "Salário")]
        [DataType(DataType.Currency)]
        [Required]
        public double Salario { get; set; }

        [Display(Name ="País")]
        [Required]
        public string Pais { get; set; }

        [Display(Name = "Ativo?")]
        public bool Ativo { get; set; }
    }
}
