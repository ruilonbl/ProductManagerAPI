using ProductManager.DI.Entidade;
using ProductManager.Domain.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Domain.Repositorio
{
    public interface IProdutoRepositorio
    {
        Task<IEnumerable<Produto>> ObterTodos();
        Task<Produto> ObterPorId(int id);
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(int id);
        Task<IEnumerable<Dashboard>> GetDashboard();
    }
}
