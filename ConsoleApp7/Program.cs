using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação da lista
            List<string> list = new List<string>();
            //conteudo das listas
            list.Add("Fábio");list.Add("Wilson");list.Add("Angelina");list.Add("Elinei");list.Add("Andre");
            list.Insert(2, "Lucas");


                //Qntd de elementos da lista possuem a letra "a"
                Console.WriteLine("Qnt de elementos na Lista: " + list.Count);
                string s1 = list.Find(x => x[0] == 'A');
                //Primeiro elementos da lista começam com "A"
                Console.WriteLine("Primeiro elemento que começa com a letra A: " + s1);
                string s2 = list.FindLast(x => x[0] == 'A');
                //Ultimo elemento que começa com "A"
                Console.WriteLine("Ultimo elemento que começa com a letra A: " + s2);
            //Encontrar palavras que começam com "a" e depois q terminam com "a"
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira Posição de 'A': " + pos1);
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Última Posição de 'A': " + pos2);

            //Encontrar palavras com 5 letras
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("-------------------------------");
            //Remover "Andre" da lista
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);

                list.Remove("Andre");
               
            }
            //Imprimir a lista com as modificações
            Console.WriteLine("===================");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.Remove("Andre");
            Console.WriteLine("===================");
            //Imprimir a lista novamente
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            //Remover palavras q possuam "w" e imprimir a lista atualizada
            list.RemoveAll(x => x[0] == 'W');
            Console.WriteLine("+++++++++++++++++++");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            //Removes a palavra no "3" lugar e atualizar a lista
            list.RemoveAt(3);
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxx");
            foreach (string obj in list) 
            {
                Console.WriteLine(obj); 
            }
            //Remover palavras com 1 e 2 letras e imprimir lista novamente
            list.RemoveRange(1, 2);
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxx");
            foreach (string obj in list) 
            {
                Console.WriteLine(obj);
            }
            Console.ReadKey();
        }      
    }
}
