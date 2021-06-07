using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;
using Persistence.Persistence;

namespace Business.Business
{
    public class GerenciadoraCadastroProduto
    {
        public ProdutosPersistencia persistencia;

        public GerenciadoraCadastroProduto()
        {
            persistencia = new ProdutosPersistencia();
        }

        public void Adicionar(cadastrado produtos)
        {
            persistencia.Adicinar(produtos);
        }

        public void Editar(cadastrado produtos)
        {
            persistencia.Editar(produtos);
        }

        public void Remover(int? id)
        {
            persistencia.Remover(id);
        }

        public List<cadastrado> ObterTodos()
        {
            return persistencia.ObterTodos();
        }

        public cadastrado ObterById(int? id)
        {
            return persistencia.ObterById(id);
        }
    }
}
