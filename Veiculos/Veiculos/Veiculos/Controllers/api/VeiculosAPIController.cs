using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Veiculos.Models;
using Veiculos.Models.Util;

namespace Veiculos.Controllers.api
{
    public class VeiculosAPIController : ApiController
    {


        [HttpGet]
        public HttpResponseMessage Get()
        {
            BancoCarrosEntities _Context = new BancoCarrosEntities();

            List<Carro> listCarro = new List<Carro>();
            listCarro = _Context.Carro.ToList();

            List<CarroDTO> ListaDeRetorno = new List<CarroDTO>();
            foreach (Carro i_carro in listCarro)
            {
                ListaDeRetorno.Add(Models.Util.Convert.ConverteCarro(i_carro));
            }

            return Request.CreateResponse(HttpStatusCode.OK, ListaDeRetorno);
        }



        [HttpGet]
        public HttpResponseMessage GetManuntencao(int Id)
        {
            BancoCarrosEntities _Context = new BancoCarrosEntities();

            List<Historico> Historicos = _Context.Historico.Where(h => h.Id_Carro == Id).ToList();

            List<HistoricoDTO> ListaDeRetorno = new List<HistoricoDTO>();
            foreach (Historico i_Historico in Historicos)
            {
                ListaDeRetorno.Add(Models.Util.Convert.ConverteHistorico(i_Historico));
            }

            return Request.CreateResponse(HttpStatusCode.OK, ListaDeRetorno);     
        }

        //[HttpPost]
        //public HttpResponseMessage Add(teste x)
        //{
        //    BusinessLocation reg = new BusinessLocation();

        //    reg.Id = x.id;
        //    reg.Name = x.empresa;
        //    ApplicationDbContext _Context = new ApplicationDbContext();

        //    _Context.BusinessLocation.Add(reg);
        //    _Context.SaveChanges();

        //    return Request.CreateResponse(HttpStatusCode.OK);
        //}


        //[HttpPost]
        //public HttpResponseMessage AddForm(teste x)
        //{
        //    BusinessLocation reg = new BusinessLocation();

        //    reg.Id = x.id;
        //    reg.Name = x.empresa;
        //    ApplicationDbContext _Context = new ApplicationDbContext();

        //    _Context.BusinessLocation.Add(reg);
        //    _Context.SaveChanges();

        //    return Request.CreateResponse(HttpStatusCode.OK);
        //}


    }
}


