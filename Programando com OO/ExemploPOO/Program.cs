using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //PilaresOO();
            //ClasseAbstrata();
            //ClasseObject();
            //Interfaces();
            //TrabalhandoComArquivos();
        }

        private static void TrabalhandoComArquivos()
        {
            FileHelper helper = new FileHelper();
            // Método criado para poder utilizar os exemplos em qualquer lugar sem precisar manualmente inserir o caminho
            string caminho = helper.GetTrabalhandoComArquivos();

            string caminhoPathCombine = Path.Combine(caminho, "Pasta Teste 1");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-backup.txt");
            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste 2", "arquivo-teste-stream.txt");

            List<string> listaString = new List<string> { "Linha 1", "Linha 2", "Linha 3" };
            List<string> listaStringContinuacao = new List<string> { "Linha 4", "Linha 5", "Linha 6" };

            //helper.ListarDiretorios(caminho);
            //helper.ListarArquivosDiretorios(caminho);
            //helper.CriarDiretório(caminhoPathCombine);
            //helper.ApagarDiretório(caminhoPathCombine);
            //helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de arquivo");
            //helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            //helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
            //helper.LerArquivoStream(caminhoArquivo);
            //helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);
            //helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
            //helper.DeletarArquivo(caminhoArquivoTesteCopia);
        }

        private static void Interfaces()
        {
            ICalculadora calc = new Calculadora();
            Console.WriteLine(calc.Somar(10, 20));
            Console.WriteLine(calc.Multiplicar(1, 2));
        }

        private static void ClasseObject()
        {
            Computador comp = new Computador();
            Console.WriteLine(comp.ToString());
        }

        private static void ClasseAbstrata()
        {
            Corrente c = new Corrente();
            c.Creditar(100);

            c.ExibirSaldo();
        }

        private static void PilaresOO()
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
