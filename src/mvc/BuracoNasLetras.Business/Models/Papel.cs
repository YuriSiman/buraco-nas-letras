namespace BuracoNasLetras.Business.Models
{
    public class Papel : Entity
    {
        public string Texto { get; set; }
        public int Tamanho { get; set; }
        public int TotalDePalavras { get; set; }
        public int TotalDeBuracos { get; set; }
    }
}
