using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    public class Programa
    {
        public static void Menu_Inicial()
        {
            Console.WriteLine("Programa de Grafos, Selecione uma Opção:");
            Console.WriteLine();
            Console.WriteLine("1 - Matriz de Adjacencia");
            Console.WriteLine("2 - Lista de Adjacencia");
            int valor = int.Parse(Console.ReadLine());
            switch (valor)
            {
                case 1:
                    Inicia_MA();
                    break;
                case 2:
                    Menu_LA();
                    break;
                default:
                    Console.Clear();
                    Menu_Inicial();
                    break;
            }              
        }
        public static void Menu_MA(int vertice)
        {
            Console.WriteLine("1 - Ordem\n2 - Inserir Aresta\n3 - Remover Aresta\n4 - Grau do Grafo\n5 - É Completo?\n6 - É Regular?\n7 - Mostrar Matriz\n8 - Mostrar Lista\n9 - Mostrar Sequencia de Graus\n10 - Vertices Adjacentes\n11 - Isolado?\n12 - Impar?\n13 - Par?\n14 - São Vertices Adjacentes?");
            int valor = int.Parse(Console.ReadLine());
            GrafoMA g = new GrafoMA(vertice);
            switch (valor)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Ordem:");
                    Console.WriteLine(g.Ordem());
                    Console.ReadKey();
                    Menu_MA(vertice);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Insira as arestas:");
                    int aux = int.Parse(Console.ReadLine());
                    int aux2 = int.Parse(Console.ReadLine());
                    bool Ehverdade = g.InserirAresta(aux, aux2);
                    Console.WriteLine(Ehverdade);
                    Console.ReadKey();
                    Menu_MA(vertice);
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Remova as arestas:");
                    aux = int.Parse(Console.ReadLine());
                    aux2 = int.Parse(Console.ReadLine());
                    Ehverdade = g.RemoverAresta(aux, aux2);
                    Console.WriteLine(Ehverdade);
                    Console.ReadKey();
                    Menu_MA(vertice);
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Grau de Vertice:");
                    aux = int.Parse(Console.ReadLine());
                    int aux1 = g.Grau(aux);
                    Console.WriteLine(aux1);
                    Console.ReadKey();
                    Menu_MA(vertice);
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("É completo?");
                    Console.WriteLine(g.Completo());
                    Console.ReadKey();
                    Menu_MA(vertice);
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("É Regular?");
                    Console.WriteLine(g.Regular());
                    Console.ReadKey();
                    Menu_MA(vertice);
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("Matriz:");
                    g.ShowMA();
                    Console.ReadKey();
                    Menu_MA(vertice);
                    break;
                case 8:
                    Console.Clear();
                    Console.WriteLine("Lista:");
                    g.ShowLA();
                    Console.ReadKey();
                    Menu_MA(vertice);
                    break;
                case 9:
                    Console.Clear();
                    Console.WriteLine("Vertices Adjacentes:");
                    aux = int.Parse(Console.ReadLine());
                    g.VerticesAdjacentes(aux);
                    Console.ReadKey();
                    Menu_MA(vertice);
                    break;
                case 10:
                    Console.Clear();
                    Console.WriteLine("Sequencia de Graus:");
                    g.SequenciaGraus();
                    Console.ReadKey();
                    Menu_MA(vertice);
                    break;
                case 11:
                    Console.Clear();
                    Console.WriteLine("É Isolado?");
                    aux = int.Parse(Console.ReadLine());
                    Ehverdade = g.Isolado(aux);
                    Console.WriteLine(Ehverdade);
                    Console.ReadKey();
                    Menu_MA(vertice);
                    break;
                case 12:
                    Console.Clear();
                    Console.WriteLine("É Impar?");
                    aux = int.Parse(Console.ReadLine());
                    Ehverdade = g.Impar(aux);
                    Console.WriteLine(Ehverdade);
                    Console.ReadKey();
                    Menu_MA(vertice);
                    break;
                case 13:
                    Console.Clear();
                    Console.WriteLine("É Par?");
                    aux = int.Parse(Console.ReadLine());
                    Ehverdade = g.Par(aux);
                    Console.WriteLine(Ehverdade);
                    Console.ReadKey();
                    Menu_MA(vertice);
                    break;
                case 14:
                    Console.Clear();
                    Console.WriteLine("São Adjacentes?");
                    aux = int.Parse(Console.ReadLine());
                    aux2 = int.Parse(Console.ReadLine());
                    Ehverdade = g.Adjacentes(aux, aux2);
                    Console.WriteLine(Ehverdade);
                    Console.ReadKey();
                    Menu_MA(vertice);
                    break;
                default:
                    Menu_MA(vertice);
                    break;
            }
        }
        public static void Inicia_MA()
        {
            Console.Clear();
            Console.WriteLine("Quantidade de vertices do Grafo Inicial:");
            int aux = int.Parse(Console.ReadLine());
            Console.ReadKey();
            Menu_MA(aux);
        }
        public static void Menu_LA()
        {
            Console.WriteLine("1 - Ordem\n2 - Inserir Aresta\n3 - Remover Aresta\n4 - Inserir Vertice\n5 - Remover Vertice\n6 - Grau do Grafo\n7 - É Completo?\n8 - É Regular?\n9 - Mostrar Lista\n10 - Mostrar Sequencia de Graus\n11 - Vertices Adjacentes\n12 - Isolado?\n13 - Impar?\n14 - Par?\n15 - São Vertices Adjacentes?");
            GrafoLA ga = new GrafoLA();
            int valor = int.Parse(Console.ReadLine());
            switch (valor)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Ordem:");
                    Console.WriteLine(ga.Ordem());
                    Console.ReadKey();
                    Menu_LA();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Insirir Vertice:");
                    int aux = int.Parse(Console.ReadLine());
                    bool Ehverdade = ga.InserirVertice(aux);
                    Console.WriteLine(Ehverdade);
                    Console.ReadKey();
                    Menu_LA();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Remover Vertice:");
                    aux = int.Parse(Console.ReadLine());
                    Ehverdade = ga.RemoverVertice(aux);
                    Console.WriteLine(Ehverdade);
                    Console.ReadKey();
                    Menu_LA();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Inserir a aresta:");
                    aux = int.Parse(Console.ReadLine());
                    int aux2 = int.Parse(Console.ReadLine());
                    Ehverdade = ga.InserirAresta(aux, aux2);
                    Console.WriteLine(Ehverdade);
                    Console.ReadKey();
                    Menu_LA();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Remover a aresta:");
                    aux = int.Parse(Console.ReadLine());
                    aux2 = int.Parse(Console.ReadLine());
                    Ehverdade = ga.RemoverAresta(aux, aux2);
                    Console.WriteLine(Ehverdade);
                    Console.ReadKey();
                    Menu_LA();
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("Grau de Vertice:");
                    aux = int.Parse(Console.ReadLine());
                    int aux1 = ga.Grau(aux);
                    Console.WriteLine(aux1);
                    Console.ReadKey();
                    Menu_LA();
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("É completo?");
                    Console.WriteLine(ga.Completo());
                    Console.ReadKey();
                    Menu_LA();
                    break;
                case 8:
                    Console.Clear();
                    Console.WriteLine("É Regular?");
                    Console.WriteLine(ga.Regular());
                    Console.ReadKey();
                    Menu_LA();
                    break;
                case 9:
                    Console.Clear();
                    Console.WriteLine("Lista:");
                    ga.ShowLA();
                    Console.ReadKey();
                    Menu_LA();
                    break;
                case 11:
                    Console.Clear();
                    Console.WriteLine("Vertices Adjacentes:");
                    aux = int.Parse(Console.ReadLine());
                    ga.VerticesAdjacentes(aux);
                    Console.ReadKey();
                    Menu_LA();
                    break;
                case 10:
                    Console.Clear();
                    Console.WriteLine("Sequencia de Graus:");
                    ga.SequenciaGraus();
                    Console.ReadKey();
                    Menu_LA();
                    break;
                case 12:
                    Console.Clear();
                    Console.WriteLine("É Isolado?");
                    aux = int.Parse(Console.ReadLine());
                    Ehverdade = ga.Isolado(aux);
                    Console.WriteLine(Ehverdade);
                    Console.ReadKey();
                    Menu_LA();
                    break;
                case 13:
                    Console.Clear();
                    Console.WriteLine("É Impar?");
                    aux = int.Parse(Console.ReadLine());
                    Ehverdade = ga.Impar(aux);
                    Console.WriteLine(Ehverdade);
                    Console.ReadKey();
                    Menu_LA();
                    break;
                case 14:
                    Console.Clear();
                    Console.WriteLine("É Par?");
                    aux = int.Parse(Console.ReadLine());
                    Ehverdade = ga.Par(aux);
                    Console.WriteLine(Ehverdade);
                    Console.ReadKey();
                    Menu_LA();
                    break;
                case 15:
                    Console.Clear();
                    Console.WriteLine("São Adjacentes?");
                    aux = int.Parse(Console.ReadLine());
                    aux2 = int.Parse(Console.ReadLine());
                    Ehverdade = ga.Adjacentes(aux, aux2);
                    Console.WriteLine(Ehverdade);
                    Console.ReadKey();
                    Menu_LA();
                    break;
                default:
                    Menu_LA();
                    break;
            }
        }
        public static void Main(string[] args)
        {
            Menu_Inicial();
            Console.ReadKey();
        }
    }
}
