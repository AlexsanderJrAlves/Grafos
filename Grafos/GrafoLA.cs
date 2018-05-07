using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    public class GrafoLA
    {
        private List<Vertice> LA;
        public GrafoLA()
        {
            LA = new List<Vertice>();
        }        
        public int Ordem()
        {
            return LA.Count();
        }
        private bool Contem(int vertice)
        {
            bool resp = false;
            foreach (Vertice elemento in LA)
            {
                if (LA.Contains(elemento.ContemChave(vertice)))
                {
                    resp = true;
                }
            }
            return resp;
        }
        public bool InserirVertice(int vertice)
        {
            bool resp = false;
            try
            {
                foreach (Vertice elemento in LA)
                {
                    if (!LA.Contains(elemento.ContemChave(vertice)))
                    {
                        LA.Add(new Vertice(vertice));
                        resp = true;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Item já inserido");
            }
            return resp;
            
        }
        public bool RemoverVertice(int vertice)
        {
            bool resp = false;
            try
            {
                foreach (Vertice elemento in LA)
                {
                    if (LA.Contains(elemento.ContemChave(vertice)))
                    {
                        elemento.ListaAdjacencia.Remove(vertice);
                    }
                    if (LA.Contains(elemento.ContemChave(vertice)))
                    {
                        LA.Remove(elemento);                        
                    }
                }

            }
            catch
            {
            Console.WriteLine("Item já removido ou nunca inserido");
            }
            return resp;
        }
        public bool InserirAresta(int vertice1, int vertice2)
        {
            bool resp = false;
            if (this.Contem(vertice1) == true && this.Contem(vertice2) == true)
            {
                foreach (Vertice elemento in LA)
                {
                    if (LA.Contains(elemento.ContemChave(vertice1)))
                    {
                        elemento.ListaAdjacencia.Add(vertice2);
                        
                    }
                    if (LA.Contains(elemento.ContemChave(vertice2)))
                    {
                        elemento.ListaAdjacencia.Add(vertice1);
                    }
                }
                resp = true;
            }
            return resp;

        }
        public bool RemoverAresta(int vertice1, int vertice2)
        {
            bool resp = false;
            if (this.Contem(vertice1) == true && this.Contem(vertice2) == true)
            {
                foreach (Vertice elemento in LA)
                {
                    if (LA.Contains(elemento.ContemChave(vertice1)))
                    {
                        elemento.ListaAdjacencia.Remove(vertice2);

                    }
                    if (LA.Contains(elemento.ContemChave(vertice2)))
                    {
                        elemento.ListaAdjacencia.Remove(vertice1);
                    }
                }
                resp = true;
            }
            return resp;

        }
        public int Grau(int vertice)
        {
            int resp = 0;
            foreach (Vertice elemento in LA)
            {
                if (LA.Contains(elemento.ContemChave(vertice)))
                {
                    resp = elemento.ListaAdjacencia.Count();
                }
            }
            return resp;
        }
        public bool Completo()
        {
            bool resp = false;
            int aux, cont = 0;
            foreach(Vertice elemento in LA)
            {
                if (LA.Contains(elemento))
                {
                    cont = cont + elemento.ListaAdjacencia.Count();
                }
            }
            aux = Ordem() * (Ordem() - 1) / 2;
            if(aux == cont)
            {
                resp = true;
            }
            return resp;
        }
        public bool Regular()
        {
            bool resp = true;
            foreach (Vertice elemento in LA)
            {
                if (LA.Contains(elemento))
                {
                    if(elemento.ListaAdjacencia.Count() == 0)
                    {
                        resp = false;
                    }
                }
            }
            return resp;
        }
        public void ShowLA()
        {           
            foreach (Vertice elemento in LA)
            {
                Console.Write(elemento.chave + ": ");
                elemento.ShowLista();
            }
            Console.WriteLine();
        }
        public void SequenciaGraus()
        {
            foreach (Vertice elemento in LA)
            {
                Console.Write(elemento.ListaAdjacencia.Count());
            }
            Console.WriteLine();
        }
        public void VerticesAdjacentes(int vertice)
        {
            foreach (Vertice elemento in LA)
            {
                if (LA.Contains(elemento.ContemChave(vertice)))
                {
                    Console.Write(elemento.chave + ": ");
                    elemento.ShowLista();
                }
            }
        }
        public bool Isolado(int vertice)
        {
            bool resp = false;
            foreach (Vertice elemento in LA)
            {
                if (LA.Contains(elemento.ContemChave(vertice)))
                {
                    if(elemento.ListaAdjacencia.Count() == 0)
                    {
                        resp = true;
                    }
                }
            }
            return resp;
        }
        public bool Par(int vertice)
        {
            bool resp = false;
            foreach (Vertice elemento in LA)
            {
                if (LA.Contains(elemento.ContemChave(vertice)))
                {
                    if (elemento.ListaAdjacencia.Count() % 2 == 0)
                    {
                        resp = true;
                    }
                }
            }
            return resp;
        }
        public bool Impar(int vertice)
        {
            bool resp = false;
            foreach (Vertice elemento in LA)
            {
                if (LA.Contains(elemento.ContemChave(vertice)))
                {
                    if (elemento.ListaAdjacencia.Count() % 2 == 1)
                    {
                        resp = true;
                    }
                }
            }
            return resp;
        }
        public bool Adjacentes(int vertice1, int vertice2)
        {
            bool resp = false;
            if (this.Contem(vertice1) == true && this.Contem(vertice2) == true)
            {
                foreach (Vertice elemento in LA)
                {
                    if (elemento.ListaAdjacencia.Contains(vertice1) && elemento.ListaAdjacencia.Contains(vertice2))
                    {
                        resp = true;
                    }
                }
            }
            return resp;
        }
    }
}
