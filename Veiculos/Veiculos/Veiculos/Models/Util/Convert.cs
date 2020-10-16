using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veiculos.Models.Util
{
    public static class Convert
    {
        public static HistoricoDTO ConverteHistorico(Historico historico)
        {
            HistoricoDTO DTO = new HistoricoDTO()
            {
                DataRegistro = historico.DataRegistro,
                Id_Carro = historico.Id_Carro,
                Id_Historico = historico.Id_Historico,
                Manutencao = historico.Manutencao,
                Valor = historico.Valor
            };

            return DTO;
        }

        public static CarroDTO ConverteCarro(Carro carro)
        {
            CarroDTO CarDTO = new CarroDTO()
            {
                Id_Carro = carro.Id_Carro,
                Modelo = carro.Modelo,
                Proprietario = carro.Proprietario,
                Preco = carro.Preco
            };

            return CarDTO;
        }
    }
}