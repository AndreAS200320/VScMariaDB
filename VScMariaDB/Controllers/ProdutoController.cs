using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VScMariaDB.Model;

namespace VScMariaDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        [HttpGet("AsyncTudo")]
        public async Task<List<Produto>> GetLista()
        {
            var _dbContext = new _DbContext();
            var VLista = _dbContext.Produto.ToList();

            return VLista;
        }

        [HttpGet("{id}")]
        public async Task<Produto> GetProduto(int id)
        {
            var _dbContext = new _DbContext();

            var VProduto = await _dbContext.Produto.FindAsync(id);

            return VProduto;
        }

        [HttpPost]
        public async Task<Produto> Inserir(Produto produto)
        {
            var _dbContext = new _DbContext();

            await _dbContext.Produto.AddAsync(produto);
            await _dbContext.SaveChangesAsync();

            return produto;
        }

        [HttpPut]
        public async Task<Produto> Alterar(Produto produto)
        {
            var _dbContext = new _DbContext();

            _dbContext.Produto.Entry(produto).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();

            return produto;
        }

        [HttpDelete]
        public async Task<ActionResult> Remove(int id)
        {
            var _dbContext = new _DbContext();
            //var VPessoa = _dbContext.Pessoa.Find(id);
            _dbContext.Produto.Remove(await _dbContext.Produto.FindAsync(id));
            await _dbContext.SaveChangesAsync();

            return Ok();
        }
    }
}
