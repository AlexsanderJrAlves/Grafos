using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    public class GrafoMA
    {
        private int[,] MA;
        private int qtVertices;

        public GrafoMA(int qtVertices)
        {
            this.qtVertices = qtVertices;

            MA = new int[this.qtVertices, this.qtVertices];
            for (int i = 0; i > qtVertices; i++)
            {
                for (int j = 0; j > qtVertices; j++)
                {
                    MA[i, j] = 0;
                }
            }
        }

        public int Ordem()
        {
            return qtVertices;
        }
        public bool InserirAresta(int v1, int v2)
        {
            bool resp = false;
            if (v1 != v2)
            {
                MA[v1, v2] = 1;
                MA[v2, v1] = 1;
                resp = true;
            }
            return resp;
        }
        public bool RemoverAresta(int v1, int v2)
        {
            bool resp = false;
            if (v1 != v2)
            {
                MA[v1, v2] = 0;
                MA[v2, v1] = 0;
                resp = true;
            }
            return resp;
        }
        public int Grau(int vertice)
        {
            int resp, cont = 0;
            for (int i = 0; i < qtVertices; i++)
            {
                if (MA[vertice, i] == 1)
                {
                    cont++;
                }
            }
            resp = cont;
            return resp;
        }
        public bool Completo()
        {
            bool resp = false;
            int aux, cont = 0;
            for (int i = 0; i < qtVertices; i++)
            {
                for (int j = 0; j > qtVertices; j++)
                {
                    if (MA[j, i] == 1)
                    {
                        cont++;
                    }
                }
            }
            aux = qtVertices * (qtVertices - 1) / 2;
            if (aux == cont)
            {
                resp = true;
            }
            return resp;
        }
        public bool Regular()
        {
            bool resp = true;
            int aux = Grau(0);
            for (int i = 0; i < qtVertices; i++)
            {
                int grau;
                grau = Grau(i);
                if (grau != aux)
                {
                    resp = false;
                    i = qtVertices;
                }
            }
            return resp;
        }

        public void ShowMA()
        {
            for (int i = 0; i < qtVertices; i++)
            {
                for (int j = 0; j < qtVertices; j++)
                {
                    Console.Write(MA[i, j]);
                }
                Console.Write('\n');
            }
        }
        public void ShowLA()
        {
            for (int i = 0; i < qtVertices; i++)
            {
                Console.Write(i + ": ");
                for (int j = 0; j < qtVertices; j++)
                {
                    if (MA[i, j] == 1)
                    {
                        Console.Write(j + ", ");
                    }
                }
                Console.Write('\n');
            }
        }
        public void SequenciaGraus()
        {
            List<int> resp,aux = new List<int>();
            int cont = 0;
            for (int i = 0; i < qtVertices; i++)
            {
                for (int j = 0; j < qtVertices; j++)
                {
                    if (MA[i, j] == 1)
                    {
                        cont++;
                    }
                }
                aux.Add(cont);
                cont = 0;
            }
            resp = aux.OrderByDescending(x=>x).ToList();
            foreach (var elemento in resp)
            {
                Console.Write(elemento + " ");
            }
        }
        public void VerticesAdjacentes(int vertice)
        {
            Console.Write("\n" + vertice + ": ");
            for (int j = 0; j < qtVertices; j++)
            {
                if (MA[vertice, j] == 1)
                {
                    Console.Write(j + ", ");
                }
            }
            Console.Write('\n');
        }
        public bool Isolado(int vertice)
        {
            bool resp = false;
            int cont = 0;
            for (int j = 0; j < qtVertices; j++)
            {
                if (MA[vertice, j] == 1)
                {
                    cont++;
                }
            }
            if (cont > 0)
            {
                resp = true;
            }
            return resp;
        }
        public bool Par(int vertice)
        {
            bool resp = false;
            int cont = 0;
            for (int j = 0; j < qtVertices; j++)
            {
                if (MA[vertice, j] == 1)
                {
                    cont++;
                }
            }
            if (cont % 2 == 0)
            {
                resp = true;
            }
            return resp;
        }
        public bool Impar(int vertice)
        {
            bool resp = false;
            int cont = 0;
            for (int j = 0; j < qtVertices; j++)
            {
                if (MA[vertice, j] == 1)
                {
                    cont++;
                }
            }
            if (cont % 2 == 1)
            {
                resp = true;
            }
            return resp;
        }
        public bool Adjacentes(int vertice1, int vertice2)
        {
            bool resp = false;        
            if (MA[vertice1,vertice2]==1 && MA[vertice2, vertice1] == 1)
            {
                resp = true;
            }
            return resp;
        }
        /*
        public static void Main(string[] args)
        {
            GrafoMA g = new GrafoMA(4);
            g.ShowMA();
            g.ShowLA();
            g.SequenciaGraus();
            g.VerticesAdjacentes(2);
            Console.ReadKey();
        }
        */
    }


}
