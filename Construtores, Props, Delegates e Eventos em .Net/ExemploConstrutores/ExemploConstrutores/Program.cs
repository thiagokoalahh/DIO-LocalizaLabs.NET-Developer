using ExemploConstrutores.Models;
using System;

namespace ExemploConstrutores
{
    public class Program
    {
        public delegate void Operacao(int x, int y);

        static void Main(string[] args)
        {
            Matematica m = new Matematica(10, 20);
            m.Somar();
            
            
            //Operacao op = Calculadora.Somar;
            //Operacao op = new Operacao(Calculadora.Somar);
            //op += Calculadora.Subtrair;

            //op.Invoke(10, 10);

            //const double pi = 3.14;
            //Console.WriteLine(pi);

            //Aluno aluno = new Aluno("Thiago", "Silva", "Teste");
            //aluno.Apresentar();

            //Pessoa p1 = new Pessoa("Thiago", "Silva");
            //p1.Apresentar();

            //ConstrutorPrivado();
            //DataProps();
        }

        private static void DataProps()
        {
            Data data = new Data();
            //data.SetMes(20);

            data.Mes = 20;
            //Console.WriteLine(data.Mes);

            data.ApresentarMes();
        }

        private static void ConstrutorPrivado()
        {
            Log log = Log.GetInstance();

            log.PropriedadeLog = "Teste instância";

            Log log2 = Log.GetInstance();

            Console.WriteLine(log2.PropriedadeLog);
        }
    }
}
