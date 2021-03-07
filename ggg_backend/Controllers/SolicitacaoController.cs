using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ggg_backend.Interfaces;
using ggg_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace ggg_backend.Controller
{
    [Route("api/Solicitacao")]
    [ApiController]
    public class SolicitacaoController : ControllerBase
    {

        private readonly ISolicitacaoService _service;

        public SolicitacaoController(ISolicitacaoService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Solicitacao solicitacao)
        {
            try
            {
                await _service.Create(solicitacao);
                return Ok(solicitacao);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        [HttpGet]
        public async Task<IActionResult> ListAll()
        {
            try
            {
                var retorno = await _service.GetAllSolicitacao();
                return Ok(retorno);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

        }
    }
}