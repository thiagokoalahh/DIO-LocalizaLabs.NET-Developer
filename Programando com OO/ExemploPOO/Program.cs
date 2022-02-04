using ExemploPOO.Models;
using System;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Polimorfismo
            // Sobrecarga de métodos
            Overload();
            // Herança + Polimorfismo
            // Sobrescrita de métodos em classes derivadas
            Override();

            // Encapsulamento, acesso a medidas somente indiretamente pelo método DefinirMedidas
            Encapsulamento();

            // Abstração de Pessoa
            Abstração();
        }

        private static void Abstração()
        {
            Pessoa p1 = new Pessoa();

            p1.Nome = "Thiago";
            p1.Idade = 20;

            p1.Apresentar();
        }

        private static void Encapsulamento()
        {
            // Valores válidos
            Retangulo r = new Retangulo();
            r.DefinirMedidas(30, 30);

            Console.WriteLine("Área: " + r.ObterArea());

            // Valores inválidos
            Retangulo r2 = new Retangulo();
            r.DefinirMedidas(0, 0);

            Console.WriteLine("Área: " + r2.ObterArea());
        }

        private static void Override()
        {
            Aluno p1 = new Aluno();
            p1.Nome = "Thiago";
            p1.Idade = 20;
            p1.Documento = "123125";
            p1.Nota = 10;

            p1.Apresentar();

            Professor p2 = new Professor();
            p2.Nome = "Thiago";
            p2.Idade = 20;
            p2.Documento = "123125";
            p2.Salario = 2000;

            p2.Apresentar();
        }

        private static void Overload()
        {
            Calculadora calc = new Calculadora();
            Console.WriteLine("Resultado da primeira soma: " + calc.Somar(5, 5));
            Console.WriteLine("Resultado da segunda soma: " + calc.Somar(5, 5, 5));
        }
    }
}
