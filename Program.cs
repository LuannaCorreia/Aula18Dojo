using System;

namespace Aula18Dojo
{
    class Program
    {
        static void Main(string[] args)
        {
             Jogador marta = new Jogador();
            marta.Nome= "Marta";
            marta.Altura = 1.63f;
            marta.Peso = 58f;
            marta.Nascimento = DateTime.Parse("19/02/1986");
            marta.Posicao = "Ponta-esquerda";
            
            Console.WriteLine(marta.CalcularIdade());
            Console.WriteLine(marta.VerificarAposentadoria());
        }
    }
}