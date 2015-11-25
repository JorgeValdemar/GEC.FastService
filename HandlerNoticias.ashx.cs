using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GEC.FastService.Entity;

namespace GEC.FastService
{
    /// <summary>
    /// Summary description for HandlerNoticias
    /// </summary>
    public class HandlerNoticias : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            List<Noticia> INoticia = new List<Noticia>();

            Noticia n = new Noticia()
            {
                id = 1,
                title = @"Rubinho visita a Arena Corinthians em dia de clássico e posa com técnico Tite",
                link = @"http://globoesporte.globo.com/motor/stock-car/noticia/2015/11/rubinho-visita-arena-corinthians-antes-de-classico-e-posa-com-tite.html",
                description = @"<a href='http://globoesporte.globo.com/motor/stock-car/noticia/2015/11/rubinho-visita-arena-corinthians-antes-de-classico-e-posa-com-tite.html' alt='Rubinho visita a Arena Corinthians em dia de clássico e posa com técnico Tite'><img border='0' src='http://s2.glbimg.com/3JJlvF-FWbireWnCP2ynzOTpWL8=/160x108/smart/s.glbimg.com/es/ge/f/original/2015/11/22/ru1.jpg' alt='Rubinho visita a Arena Corinthians em dia de clássico e posa com técnico Tite' title='Rubinho visita a Arena Corinthians em dia de clássico e posa com técnico Tite' /></a><br />Treinador do campeão Corinthians segura camisa 10 personalizada com nome do piloto, que levou seu filho para o local do clássico contra o São Paulo neste domingo",
                category = "stock car",
                pubDate = DateTime.Now
            };

            Noticia n2 = new Noticia()
            {
                id = 2,
                title = @"Rubens Barrichello visita hospital em São Paulo e doa réplica de capacete",
                link = @"http://globoesporte.globo.com/motor/stock-car/noticia/2015/11/rubens-barrichello-visita-hospital-em-sao-paulo-e-doa-replica-de-capacete.html",
                description = @"<a href='http://globoesporte.globo.com/motor/stock-car/noticia/2015/11/rubens-barrichello-visita-hospital-em-sao-paulo-e-doa-replica-de-capacete.html' alt='Rubens Barrichello visita hospital em São Paulo e doa réplica de capacete '><img border='0' src='http://s2.glbimg.com/wMB0j9F0-uN9TEmVSo9aboDLMrk=/160x108/smart/s.glbimg.com/es/ge/f/original/2015/11/24/rubens_barrichello_assina_capacete_para_doar_ao_ibcc_-_baixa.jpg' alt='Rubens Barrichello visita hospital em São Paulo e doa réplica de capacete ' title='Rubens Barrichello visita hospital em São Paulo e doa réplica de capacete ' /></a><br />Campeão da temporada 2014 da Stock Car e recordista de GPs na Fórmula 1, Rubinho visita Instituto Brasileiro de Controle do Câncer e doa capacete para leilão",
                category = "stock car",
                pubDate = DateTime.Now
            };

            INoticia.Add(n);
            INoticia.Add(n2);

            string json = JsonConvert.SerializeObject(INoticia);
            context.Response.Write(json);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}