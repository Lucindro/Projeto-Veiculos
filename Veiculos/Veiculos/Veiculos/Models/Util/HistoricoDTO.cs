using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veiculos.Models.Util
{
    public class HistoricoDTO
    {
        public int Id_Historico { get; set; }
        public System.DateTime DataRegistro { get; set; }
        public double Valor { get; set; }
        public int Id_Carro { get; set; }
        public string Manutencao { get; set; }


    }
}