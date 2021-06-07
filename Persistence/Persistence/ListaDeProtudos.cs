using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Persistence
{
    public class ListaDeProtudos
    {
        private static List<Produto> arreyDeProdutos;

        static ListaDeProtudos()
        {
            arreyDeProdutos = new List<Produto>();
        }
        public List<Produto> ObterTodos()
        {
            return arreyDeProdutos.ObterTodos();
        }
    }
}
