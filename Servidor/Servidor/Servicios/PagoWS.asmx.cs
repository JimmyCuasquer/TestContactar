using Mensajeria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Model;

namespace Servidor.Servicios
{
    /// <summary>
    /// Summary description for PagoWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class PagoWS : System.Web.Services.WebService
    {

        [WebMethod]
        public PagoMSJ Guardar(PagoMSJ p)
        {

            PAGO pago = new PAGO();
            pago.SECUENCIALPRESTAMO = p.SECUENCIALPRESTAMO;
            pago.VALORPAGO = p.VALORPAGO;
            pago.FECHA = p.FECHA;
            pago.SALDOPRESTAMO = p.SALDOPRESTAMO;
            
           

            pago = PAGO_Negocio.Guardar(pago);
            p.SECUENCIAL = pago.SECUENCIAL;

            return p;
        }
    }
}
