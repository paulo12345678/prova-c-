using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;

namespace Persistence.Persistence
{
    public class ProdutosPersistencia
    {
        private static List<cadastrado> listaprotudos;

        static ProdutosPersistencia()
        {
            listaprotudos = new List<cadastrado>();
        }

        public void Adicinar(cadastrado obj_Produtos)
        {
            obj_Produtos.Id = listaprotudos.Count + 1;
            listaprotudos.Add(obj_Produtos);
        }

        public void Editar(cadastrado obj_Produtos)
        {
            int idx = listaprotudos.FindIndex(e => e.Id == obj_Produtos.Id);
            listaprotudos[idx] = obj_Produtos;
        }

        public void Remover(int? id)
        {
            int idx = listaprotudos.FindIndex(e => e.Id == id);
            listaprotudos.RemoveAt(idx);
        }

        public List<cadastrado> ObterTodos()
        {
            return listaprotudos;
        }

        public cadastrado ObterById(int? id)
        {
            return (id.HasValue) ? listaprotudos.Find(e => e.Id == id) : null;
        }
    }
}
