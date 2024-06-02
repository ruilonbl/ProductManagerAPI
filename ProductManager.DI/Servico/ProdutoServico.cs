using ProductManager.DI.Entidade;
using ProductManager.Domain.Entidade;
using ProductManager.Domain.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Domain.Servico
{
    public class ProdutoServico : IProdutoServico
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutoServico(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        public Task Adicionar(Produto produto)
        {
            return  _produtoRepositorio.Adicionar(produto);
        }

        public Task Remover(int id)
        {
            return _produtoRepositorio.Remover(id);
        }

        public Task<IEnumerable<Produto>> ObterTodos()
        {
            return _produtoRepositorio.ObterTodos();
        }

        public Task<Produto> ObterPorId(int id)
        {
            return _produtoRepositorio.ObterPorId(id);
        }

        public Task Atualizar(Produto produto)
        {
            return _produtoRepositorio.Atualizar(produto);
        }

        public Task<IEnumerable<Dashboard>> GetDashboard()
        {
            return _produtoRepositorio.GetDashboard();
        }
    }
}
