using System;
using System.ComponentModel.DataAnnotations;

namespace BuracoNasLetras.Api.ViewModels
{
    public class PapelViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Texto { get; set; }

        public int Tamanho { get; set; }
        public int TotalDePalavras { get; set; }
        public int TotalDeBuracos { get; set; }
    }
}
