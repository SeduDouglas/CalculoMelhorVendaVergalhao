﻿using System;
using System.Linq;
using CalculoMelhorVendaVergalhao.Classes;
namespace CalculoMelhorVendaVergalhao
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada = Console.ReadLine();

            var entradaTratada = entrada.Split(',').ToList().ConvertAll(x => int.Parse(x.Trim())).ToList();
            
            Precos precos = new Precos(entradaTratada);

            Console.WriteLine(precos.MelhorVenda);
        }
    }
}
