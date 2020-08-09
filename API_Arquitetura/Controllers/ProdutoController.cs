using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Arquitetura.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        // GET api/values
        [HttpGet("[action]")]
        public ActionResult BuscarProdutos()
        {
            return Ok();
        }

        [HttpGet("[action]/{id}")]
        public ActionResult BuscarProdutoPorID(int ID)
        {
            return Ok();
        }
        
        [HttpPost("[action]")]
        public ActionResult InserirProduto([FromBody] string produto)
        {
            return Ok();
        }

        [HttpPut("[action]/{id}")]
        public ActionResult AtualizarProduto(int ID, [FromBody] string produto)
        {
            return Ok();
        }
        
        [HttpDelete("[action]/{id}")]
        public ActionResult RemoverProduto(int ID)
        {
            return Ok();
        }
    }
}
