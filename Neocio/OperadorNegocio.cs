using Datos.EF;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
 public    class OperadorNegocio
    {
        private readonly TraficoContexto _context;
        public OperadorNegocio(TraficoContexto contexto)
        {
            _context = contexto;
        }
        public List<Modelos.OperadorModel> obtenererOperadores()
        {
            //var operadores = new List<Modelos.OperadorModel>();
            //for (int i = 0; i < 5; i++)
            //{
            //    var operador = new Modelos.OperadorModel();
            //    operador.Id = i;
            //    operador.Placa = "1223pdd";
            //    operador.Saldo = 5222;
            //    operador.CodigoOperador = 11;
            //    operadores.Add(operador);

            //}

            //return operadores;
            return _context.operadorItems.ToList();
        }
    }
}
