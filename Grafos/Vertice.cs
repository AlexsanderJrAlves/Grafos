using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    public class Vertice
    {
        public int chave;
        public List<int> ListaAdjacencia = new List<int>();

        public Vertice(int chave)
        {
            this.chave = chave;
        }
        public Vertice ContemChave(int chave)
        {
            if(this.chave == chave)
            {
                return this;
            }
            return null;
        }
        public void ShowLista()
        {
            foreach(int aux in ListaAdjacencia)
            {
                Console.Write(aux + ", ");
            }
        }
    }
}
