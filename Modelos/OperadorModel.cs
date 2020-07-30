using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Modelos
{
    public class OperadorModel
    {
      
        public int Id { get; set; }
        [Required(ErrorMessage ="campo es requerido"), MaxLength(20,ErrorMessage ="exedio la longitud")]
        public int CodigoOperador { get; set; }

        [Required]
   
        public string Placa { get; set; }

  
        public string Tid { get; set; }

     
        public string Epc { get; set; }

       
        public string Categoria { get; set; }

   
        public int Estado { get; set; }

        //[JsonProperty("estadoSaldo")]
        public int EstadoSaldo { get; set; }

        //[JsonProperty("saldo")]
        public int Saldo { get; set; }

        //[JsonProperty("saldoBajo")]
        public int SaldoBajo { get; set; }

        //[JsonProperty("numeroCliente")]
        //[JsonConverter(typeof(ParseStringConverter))]
        public int NumeroCliente { get; set; }

        //[JsonProperty("modalidad")]
        public string Modalidad { get; set; }

        //[JsonProperty("version")]
        public string Version { get; set; }
    }
}
