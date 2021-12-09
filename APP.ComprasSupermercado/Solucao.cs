/* 
->Desafio
Pedro trabalha sempre até tarde todos os dias, com isso tem pouco tempo para as tarefas domésticas. Para economizar tempo ele faz a lista de compras do supermercado em um aplicativo e costuma anotar cada item na mesma hora que percebe a falta dele em casa.

O problema é que o aplicativo não exclui itens duplicados, como Pedro anota o mesmo item mais de uma vez e a lista acaba ficando extensa. Sua tarefa é melhorar o aplicativo de notas desenvolvendo um código que exclua os itens duplicados da lista de compras e que os ordene alfabeticamente.

->Entrada
A primeira linha de entrada contém um inteiro N (N < 100) com a quantidade de casos de teste que vem a seguir, ou melhor, a quantidade de listas de compras para organizar. Cada lista de compra consiste de uma única linha que contém de 1 a 1000 itens ou palavras compostas apenas de letras minúsculas (de 1 a 20 letras), sem acentos e separadas por um espaço.

->Saída
A saída contém N linhas, cada uma representando uma lista de compra, sem os itens repetidos e em ordem alfabética.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace APP.ComprasSupermercado
{
    class Solucao
    {
        static void Main(string[] args)
        {
            int totalDeCasosDeTeste;
            do
            {
                Console.WriteLine("Preencha a quantidade de listas de compras. Informe um número entre 1 e 99!");
                totalDeCasosDeTeste = int.Parse(Console.ReadLine());  
                Console.WriteLine();  
            } while (totalDeCasosDeTeste >= 100);

            for (int i = 0; i < totalDeCasosDeTeste; i++)
            {      
                List<string> listaDeCompras = new List<string>(Console.ReadLine().ToLower().Split(' '));
                List<string> listaSemDuplicidade = listaDeCompras.Distinct().ToList();

                //Remove palavras com mais de 20 letras
                listaSemDuplicidade.RemoveAll(item => !(item.Length >= 1 && item.Length <= 20));

                if (!(listaSemDuplicidade.Count >= 1 && listaSemDuplicidade.Count <= 1000)){ 
                    while(!(listaSemDuplicidade.Count <= 1000)){
                       listaSemDuplicidade.RemoveAt(listaSemDuplicidade.Count-1);
                    }
                } 

                listaSemDuplicidade.Sort();

                Console.WriteLine();
                Console.WriteLine("*****Itens da Lista de Compras do Supermercado*****");
                foreach (var item in listaSemDuplicidade){
                    Console.Write("{0} ", item);
                }
                Console.WriteLine(" ");
            }
        }
    }
}
