using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductManager.DI.Entidade;
using ProductManager.Domain.Entidade;
using ProductManager.Domain.Servico;

namespace ProductManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProdutosController : Controller
    {
        private readonly IProdutoServico _service;

        public ProdutosController(IProdutoServico service)
        {
            _service = service;
        }

        [HttpGet("obter-produtos")]
        public async Task<ActionResult<IEnumerable<Produto>>> GetAll()
        {
            var produtos = await _service.ObterTodos();
            return Ok(produtos);
        }

        [HttpGet("obter-produto/{id}")]
        public async Task<ActionResult<Produto>> GetById(int id)
        {
            var produto = await _service.ObterPorId(id);
            if (produto == null)
            {
                return NotFound();
            }
            return Ok(produto);
        }

        [HttpPost("criar-produto")]
        public async Task<ActionResult> Add(Produto produto)
        {
            await _service.Adicionar(produto);
            return CreatedAtAction(nameof(GetById), new { id = produto.Id }, produto);
        }

        [HttpPut("atualizar-produto/{id}")]
        public async Task<IActionResult> Update(int id, Produto produto)
        {
            if (id != produto.Id)
            {
                return BadRequest();
            }

            await _service.Atualizar(produto);
            return NoContent();
        }

        [HttpDelete("reomver-produto/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Remover(id);
            return NoContent();
        }

        [HttpGet("dashboard")]
        public async Task<ActionResult<Dashboard>> GetDashboard()
        {
            var result = await _service.GetDashboard();
            return Ok(result);
        }
    }
}
