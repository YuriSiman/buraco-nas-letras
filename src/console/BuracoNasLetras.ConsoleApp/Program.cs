using BuracoNasLetras.ConsoleApp.Extensions;
using System;

namespace BuracoNasLetras.ConsoleApp
{
    public class Program
    {
        static QuantidadeBuracosTexto _quantidadeBuracosTexto = new QuantidadeBuracosTexto();

        static void Main(string[] args)
        {
            Console.WriteLine("Informe um texto:");
            string texto = Console.ReadLine();
           
            var buracos = _quantidadeBuracosTexto.QuantidadeDeBuracos(texto);
            ExibirConsole(texto, buracos);
        }

        public static void ExibirConsole(string texto, int buracos)
        {
            Console.WriteLine($"Texto Inserido: {texto}");
            Console.WriteLine($"Tamanho do Texto: {texto.Length}");
            Console.WriteLine($"Total de Palavras: {texto.Replace(" ", "").Length}");
            Console.WriteLine($"Total de Buracos no Texto: {buracos}");
        }
    }
}
