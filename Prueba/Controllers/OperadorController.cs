using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Modelos;
using Microsoft.AspNetCore.Mvc;
using Neocio;
using Datos.EF;
using Negocio;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Prueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperadorController : ControllerBase
    {
        private readonly TraficoContexto _contexto;
        public OperadorController(TraficoContexto contexto)
        {
            _contexto = contexto;
        }





        //[HttpGet]
        //public IEnumerable<string> Get()
        //{

        //    OperadorNegocio operadorNegocio = new OperadorNegocio(_contexto);

        //    //var operadores = operadorNegocio.obtenererOperadores();


        //    return new string[] { "value1", "value2" };
        //}

       // GET: api/<operadorController>
        [HttpGet]
        public IEnumerable<Modelos.OperadorModel> Get()
        {

            OperadorNegocio operadorNegocio = new OperadorNegocio(_contexto);

            var operadores = operadorNegocio.obtenererOperadores();


            return operadores;
        }




        //// GET api/<operadorController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<operadorController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<operadorController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<operadorController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
