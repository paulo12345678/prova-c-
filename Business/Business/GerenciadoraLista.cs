using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;
using Persistence.Persistence;
namespace Business.Business
{
    public class GerenciadoraLista
    {
        public List<cadastrado> ObterTodos()
        {
            return ListaDeProtudos.ObterTodos();
        }
    }
}
