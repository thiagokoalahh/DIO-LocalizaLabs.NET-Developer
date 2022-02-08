﻿using System;

namespace ExemploConstrutores.Models
{
    public class Matematica
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Matematica(int x, int y)
        {
            this.X = x;
            this.Y = y;

            Calculadora.EventoCalculadora += EventHandler;
        }

        public void Somar()
        {
            Calculadora.Somar(X,Y);
        }

        public void EventHandler()
        {
            Console.WriteLine("Método executado");
        }
    }
}
