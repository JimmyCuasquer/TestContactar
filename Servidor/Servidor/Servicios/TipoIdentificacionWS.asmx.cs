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
    /// Summary description for PersonaWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TipoIdentificacionWS : System.Web.Services.WebService
    {

        [WebMethod]
        public List<TipoIdentificacionMSJ> Listar()
        {
            List<TipoIdentificacionMSJ> mensajesSalida = new List<TipoIdentificacionMSJ>();
            try
            {
                List<TIPOIDENTIFICACION> listaTipoIdentificacion = TIPOIDENTIFICAION_Negocio.Listar();
                foreach (TIPOIDENTIFICACION tipoidentificacion in listaTipoIdentificacion)
                {
                    TipoIdentificacionMSJ iden = new TipoIdentificacionMSJ(
                        tipoidentificacion.CODIGO,
                        tipoidentificacion.NOMBRE,
                        tipoidentificacion.ESTAACTIVO
                        );

                    mensajesSalida.Add(iden);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return mensajesSalida;
        }

    }
}
