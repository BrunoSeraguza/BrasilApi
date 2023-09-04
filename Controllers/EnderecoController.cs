using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using BrasilApi.Services;
using IntegraBrasilApi.Interface;
using Microsoft.AspNetCore.Mvc;

namespace IntegraBrasilApi.Controllers
{
    [ApiController]
    [Route("api/v1/controller")]
    public class EnderecoController : ControllerBase
    {
        private readonly ICep _cepService;

        public EnderecoController(ICep cepService)
        {
            _cepService = cepService;
        }
        [HttpGet("busca/{cep}")]
        public async Task<IActionResult> BucarEndereco([FromRoute] string cep)
        {
            var response = await _cepService.BuscarEnderecoCep(cep);

            if(response.HttpStatusCode == HttpStatusCode.OK)
            {
                return Ok(response.Response);
            }else{
                return StatusCode((int) response.HttpStatusCode , response.ReturnError);
            }

        }
    }
}