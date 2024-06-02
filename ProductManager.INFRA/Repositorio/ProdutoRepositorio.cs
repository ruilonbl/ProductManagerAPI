using Microsoft.EntityFrameworkCore;
using ProductManager.DI.Entidade;
using ProductManager.Domain.Entidade;
using ProductManager.Domain.Repositorio;
using ProductManager.INFRA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Infra.Repositorio
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private AppDbContext _appDbContext;

        public ProdutoRepositorio(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task Adicionar(Produto produto)
        {
            _appDbContext.Add(produto);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task Remover(int id)
        {
            var product =  ObterPorId(id);
            _appDbContext.Remove(product);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Produto>> ObterTodos()
        {
            return _appDbContext.Produto.ToList();
        }

        public async Task<Produto> ObterPorId(int id)
        {
            return _appDbContext.Produto.FirstOrDefault(x => x.Id == id)
                ?? throw new Exception("Produto não encontrada.");
        }

        public async Task Atualizar(Produto produto)
        {
            _appDbContext.Add(produto);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Dashboard>> GetDashboard()
        {
            var result = await _appDbContext.Produto
            .GroupBy(p => p.Tipo)
            .Select(g => new Dashboard
            {
                Tipo = g.Key,
                Quantidade = g.Count(),
                PrecoUnitarioMedio = g.Average(p => p.PrecoUnitario)
            }).ToListAsync();

            return result;
        }
    }
}
