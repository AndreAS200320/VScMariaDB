using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VScMariaDB.Model;
using Microsoft.EntityFrameworkCore;

namespace VScMariaDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        /// <summary>
        /// Pegar a lista de todas as pessoas;
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        public List<Pessoa> GetLista() 
        {
            var _dbContext = new _DbContext();
            var VLista = _dbContext.Pessoa.ToList();

            return VLista;
            
        }

        [HttpGet("GetSync")]
        public async Task<List<Pessoa>> GetListaSync()
        {
            var _dbContext = new _DbContext();
            var VLista = await _dbContext.Pessoa.ToListAsync();

            return VLista;
        }


            /// <summary>
            /// pegar os dados de uma pessoa especifica;
            /// </summary>
            /// <param name="id"> Id da pessoa;</param>
            /// <returns></returns>
            [HttpGet("{id}")]
        public async Task<Pessoa> GetPessoa(int id)
        {
            var _dbContext = new _DbContext();

            //Pesquisar pela chave primaria
            var VPessoa =await _dbContext.Pessoa.FindAsync(id);


            //Pra pesquisa geral
            //var VPessoa = _dbContext.Pessoa.Where(p => p.Id == id).FirstOrDefault();

            return VPessoa;
        }

        [HttpPost]
        public async Task<Pessoa> Inserir(Pessoa pessoa)
        {
            var _dbContext = new _DbContext();

            await _dbContext.Pessoa.AddAsync(pessoa);
            await _dbContext.SaveChangesAsync();

            return pessoa;
        }

        [HttpPut]
        public async Task<Pessoa> Alterar(Pessoa pessoa)
        {
            var _dbContext = new _DbContext();

            _dbContext.Pessoa.Entry(pessoa).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();

            return pessoa;
        }


        [HttpDelete]
        public async Task<ActionResult> Remove(int id)
        {
            var _dbContext = new _DbContext();
            //var VPessoa = _dbContext.Pessoa.Find(id);
            _dbContext.Pessoa.Remove(await _dbContext.Pessoa.FindAsync(id));
            await _dbContext.SaveChangesAsync();

            return Ok();
        }

    }
}
