﻿using System;

namespace BuracoNasLetras.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um texto:");
            string texto = Console.ReadLine();

            var buracos = QuantidadeDeBuracos(texto);
            ExibirConsole(texto, buracos);
        }

        public static string RetirandoAcentos(string texto)
        {
            string comAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç", semAcentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc";

            for (int i = 0; i < comAcentos.Length; i++)
            {
                texto = texto.Replace(comAcentos[i].ToString(), semAcentos[i].ToString());
            }
            return texto;
        }

        public static int QuantidadeDeBuracos(string texto)
        {
            char[] letras = RetirandoAcentos(texto).ToCharArray();
            int buracos = 0;

            for (int i = 0; i < letras.Length; i++)
            {
                if (letras[i].Equals('B') || letras[i].Equals('g') || letras[i].Equals('8'))
                {
                    buracos += 2;
                }
                else if (letras[i].Equals('A') ||
                    letras[i].Equals('D') ||
                    letras[i].Equals('O') ||
                    letras[i].Equals('P') ||
                    letras[i].Equals('Q') ||
                    letras[i].Equals('R') ||
                    letras[i].Equals('a') ||
                    letras[i].Equals('b') ||
                    letras[i].Equals('d') ||
                    letras[i].Equals('e') ||
                    letras[i].Equals('o') ||
                    letras[i].Equals('p') ||
                    letras[i].Equals('q') ||
                    letras[i].Equals('0') ||
                    letras[i].Equals('4') ||
                    letras[i].Equals('6') ||
                    letras[i].Equals('9'))
                {
                    buracos++;
                }
            }
            return buracos;
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
