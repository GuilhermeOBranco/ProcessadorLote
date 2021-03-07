using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ggg_backend.Interfaces;
using ggg_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace ggg_backend.Controller
{
    [Route("api/Usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly IUsuarioService _service;

        public UsuarioController(IUsuarioService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Usuario usuario)
        {
            try
            {
                await _service.Create(usuario);
                return Ok(usuario);
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
                var retorno = await _service.GetAllUsuario();
                return Ok(retorno);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

        }
    }
}