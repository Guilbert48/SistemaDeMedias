using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeMedias
{
    internal class Media
    {
        int qtde = 0;
        public double Qtd()
        {
            Console.WriteLine("Digite a quantidade de notas: ");
            qtde = int.Parse(Console.ReadLine());

            double somaNotas = 0;

            for (int i = 0; i < qtde; i++)
            {
                Console.WriteLine($"Digite a nota #{i+1}");
                somaNotas += double.Parse(Console.ReadLine());
            } ;

            return somaNotas; 
        }
        public double CalculoMedia()
        {
            double notas = Qtd();
            double media = notas / qtde;
            Console.WriteLine($"Sua média é: {media}");

            AprovadoReprovado(media);

            return media;   
        }

        public void AprovadoReprovado(double media)
        {
            if (media <= 5) 
            {
                Console.WriteLine("Você está reprovado");
            }
            else
            {
                Console.WriteLine("Você está aprovado");  
            }
        }
    }
}
