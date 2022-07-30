using System;
using Abstracao_RPG.src.Entities;

namespace Abstracao_RPG
{
    class Program
    {
        static void Main(string[] args)
        {

            Knight arus = new Knight("Arus", 23, "Knight");
            Ninja wedge = new Ninja("Wedge", 42, "Ninja");
            Wizzard jennica = new Wizzard("Jennica", 23, "White Wizard");
            BlackWizard topapa = new BlackWizard("Topapa", 42, "Black Wizard");


            Console.WriteLine();
            Console.WriteLine(arus);
            Console.WriteLine("Vamos derrotar nosso inimigo! Irei utilizar minha espada!");
            Console.WriteLine();
            Console.WriteLine(jennica);
            Console.WriteLine("Vou usar minhas melhores técnicas e magias para poder derrota-lo, sou uma bruxa muito poderosa");
            Console.WriteLine();
            Console.WriteLine(wedge);
            Console.WriteLine(@"Sou como o silêncio de uma floresta virgem! Atacarei sem piedade e sem que o inimigo perceba!");
            Console.WriteLine();
            Console.WriteLine(topapa);
            Console.WriteLine(@"Venho das profundezas mais obscuras para ajudar-los, sou o maior e melhor Magico Negro!");
            Console.WriteLine();
            Console.WriteLine(topapa.Attack());
            Console.WriteLine();
            Console.WriteLine(jennica.Attack(10));
            Console.WriteLine();
            Console.WriteLine(wedge.Attack());
            Console.WriteLine();
            Console.WriteLine(arus.Attack());
            Console.WriteLine();
            Console.WriteLine(@"Após uma batalha dura e sangrenta o inimigo é derrotado por nossos melhores heróis!");
        }
    }
}
