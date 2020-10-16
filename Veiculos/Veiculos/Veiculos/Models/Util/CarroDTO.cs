using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veiculos.Models.Util
{
    public class CarroDTO
    {
        public int Id_Carro { get; set; }
        public string Modelo { get; set; }
        public string Proprietario { get; set; }
        public double Preco { get; set; }

    }
}