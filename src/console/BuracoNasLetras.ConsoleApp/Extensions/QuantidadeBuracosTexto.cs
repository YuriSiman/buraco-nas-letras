using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuracoNasLetras.ConsoleApp.Extensions
{
    public class QuantidadeBuracosTexto
    {
        public string RetirandoAcentos(string texto)
        {
            string comAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç", semAcentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc";

            for (int i = 0; i < comAcentos.Length; i++)
            {
                texto = texto.Replace(comAcentos[i].ToString(), semAcentos[i].ToString());
            }
            return texto;
        }

        public int QuantidadeDeBuracos(string texto)
        {
            char[] letras = RetirandoAcentos(texto).ToCharArray();
            int buracos = 0;

            for (int i = 0; i < letras.Length; i++)
            {
                if (letras[i].Equals('B') || letras[i].Equals('8'))
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
                    // A letra 'g' pode ser escrita por diversas fontes (assim como as outras), porém estou considerando a fonte cuja formatação da letra possuí apenas um buraco
                    letras[i].Equals('g') ||
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
    }
}
