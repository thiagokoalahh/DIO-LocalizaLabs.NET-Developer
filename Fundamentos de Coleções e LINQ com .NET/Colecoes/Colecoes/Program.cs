using Colecoes.Helper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Colecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumeros = new int[10] { 100, 1, 4, 0, 8, 15, 19 , 19, 4, 100};

            var minimo = arrayNumeros.Min();
            var maximo = arrayNumeros.Max();
            var medio = arrayNumeros.Average();
            var soma = arrayNumeros.Sum();
            var arrayUnico = arrayNumeros.Distinct().ToArray();

            Console.WriteLine($"Mínimo: {minimo}");
            Console.WriteLine($"Maximo: {maximo}");
            Console.WriteLine($"Medio: {medio}");
            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Array original: {string.Join(", ", arrayNumeros)}");
            Console.WriteLine($"Array distinto: {string.Join(", ", arrayUnico)}");



            //var numerosParesQuery =
            //    from num in arrayNumeros
            //    where num % 2 == 0
            //    orderby num
            //    select num;

            //var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

            //Console.WriteLine("Números pares query: " + string.Join(", ", numerosParesQuery));
            //Console.WriteLine("Números pares método: " + string.Join(", ", numerosParesMetodo));



            //Dictionary();
            //Stack();
            //Queue();
            //Listas();
            //Arrays();
        }

        private static void Dictionary()
        {
            Dictionary<string, string> estados = new Dictionary<string, string>();

            estados.Add("SP", "São paulo");
            estados.Add("MG", "Minas Gerais");
            estados.Add("BA", "Bahia");

            foreach (KeyValuePair<string, string> item in estados)
            {
                //Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            }

            string valorProcurado = "SC";

            if (estados.TryGetValue(valorProcurado, out string estadoEncontrado))
            {
                Console.WriteLine(estadoEncontrado);
            }
            else
            {
                Console.WriteLine($"Chave: {valorProcurado} não existe no dicionário");
            }


            //Console.WriteLine($"Removendo o valor: {valorProcurado}");

            //estados.Remove(valorProcurado);

            //foreach (KeyValuePair<string, string> item in estados)
            //{
            //    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            //}


            //Console.WriteLine("Valor original:");
            //Console.WriteLine(estados[valorProcurado]);

            //estados[valorProcurado] = "BA - teste atualização";

            //Console.WriteLine("Valor atualizado");
            //Console.WriteLine(estados[valorProcurado]);
        }

        private static void Stack()
        {
            Stack<string> pilhaLivros = new Stack<string>();

            pilhaLivros.Push(".NET");
            pilhaLivros.Push("DDD");
            pilhaLivros.Push("Código Limpo");

            Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");
            while (pilhaLivros.Count > 0)
            {
                Console.WriteLine($"Próximo livro para a leitura: {pilhaLivros.Peek()}");
                Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso");
            }

            Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");
        }

        private static void Queue()
        {
            Queue<string> fila = new Queue<string>();

            fila.Enqueue("Thiago");
            fila.Enqueue("Leonardo");
            fila.Enqueue("Eduardo");

            Console.WriteLine("Pessoas na fila: " + fila.Count);
            while (fila.Count > 0)
            {
                Console.WriteLine($"Vez de: {fila.Peek()}");
                Console.WriteLine($"{fila.Dequeue()} atendido");
            }

            Console.WriteLine("Pessoas na fila: " + fila.Count);
        }

        private static void List()
        {
            OperacoesLista opLista = new OperacoesLista();
            List<string> estados = new List<string> { "SP", "MG", "BA" };
            string[] estadosArray = new string[2] { "SC", "MT" };

            Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");

            opLista.ImprimirListaString(estados);

            //Console.WriteLine("Removendo o elemento");
            //estados.Remove("MG");

            //estados.AddRange(estadosArray);
            estados.Insert(1, "RJ");

            opLista.ImprimirListaString(estados);
        }

        private static void Arrays()
        {
            OperacoesArray op = new OperacoesArray();

            int[] array = new int[5] { 6, 3, 8, 1, 9 };
            int[] arrayCopia = new int[10];
            string[] arrayString = op.ConverterParaArrayString(array);

            //int valorProcurado = 10;

            Console.WriteLine($"Capacidade atual do array: {array.Length}");
            op.RedimensionarArray(ref array, array.Length*2);
            Console.WriteLine($"Capacidade atual do array após redimensionar: {array.Length}");



            //int indice = op.ObterIndice(array, valorProcurado);
            //if(indice > -1)
            //{
            //    Console.WriteLine("O índice do elemento {0} é: {1}", valorProcurado, indice);
            //}
            //else
            //{
            //    Console.WriteLine("Valor não existente no array");
            //}

            //int valorAchado = op.ObterValor(array, valorProcurado);

            //if (valorAchado > 0)
            //{
            //    Console.WriteLine("Encontrei o valor");
            //}
            //else
            //{
            //    Console.WriteLine("Não encontrei o valor");
            //}


            //bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

            //if (todosMaiorQue)
            //{
            //    Console.WriteLine("Todos os valores são maiores que {0}", valorProcurado);
            //}
            //else
            //{
            //    Console.WriteLine("Existe valores que não são maiores do que {0}", valorProcurado);
            //}


            //bool existe = op.Existe(array, valorProcurado);

            //if (existe)
            //{
            //    Console.WriteLine("Encontrei o valor: {0}", valorProcurado);
            //}
            //else
            //{
            //    Console.WriteLine("Não encontrei o valor: {0}", valorProcurado);
            //}


            //Console.WriteLine("Array original");
            //op.ImprimirArray(array);

            //op.OrdenarBubbleSorte(ref array);
            //op.Ordenar(ref array);

            //Console.WriteLine("Array ordenado");
            //op.ImprimirArray(array);

            //Console.WriteLine("Array antes da cópia");
            //op.ImprimirArray(arrayCopia);

            //op.Copiar(ref array, ref arrayCopia);
            //Console.WriteLine("Array após a cópia");
            //op.ImprimirArray(arrayCopia);

            //int[,] matriz = new int[4, 2]
            //{
            //    { 8, 8 },
            //    { 10, 20 },
            //    { 50, 100 },
            //    { 90, 200 }
            //};

            //Console.WriteLine("Percorrendo matriz");
            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        Console.WriteLine(matriz[i, j]);
            //    }
            //}


            //int[] arrayInteiros = new int[3];

            //arrayInteiros[0] = 10;
            //arrayInteiros[1] = 20;
            //arrayInteiros[2] = int.Parse("30");

            //arrayInteiros[3] = 30;


            //console.writeline("percorrendo o array pelo for");
            //for (int i = 0; i < arrayinteiros.length; i++)
            //{
            //    console.writeline(arrayinteiros[i]);
            //}

            //console.writeline("percorrendo o array pelo foreach");
            //foreach (int item in arrayinteiros)
            //{
            //    console.writeline(item);
            //}
        }
    }
}
