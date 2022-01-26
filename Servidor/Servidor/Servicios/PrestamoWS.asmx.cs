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
    public class PrestamoWS : System.Web.Services.WebService
    {

        [WebMethod]
        public PrestamoBase Guardar(PrestamoBase prestamoBase)
        {

            PRESTAMO prestamo = new PRESTAMO();

            PERSONA persona = PERSONA_Negocio.BuscarPorIdentificacion(prestamoBase.IDENTIFICACION);
            if (persona != null)
            {
                int secuencialPersona = persona.SECUENCIAL;
                decimal monto = Convert.ToDecimal(prestamoBase.MONTO);
                prestamo.SECUENCIALPERSONA = secuencialPersona;
                prestamo.MONTO = monto;
                prestamo.ESTADO = "V";
                prestamo.SALDO = monto;
                try
                {
                    if (monto < 500000 || monto > 20000000)
                    {
                        throw new Exception("El monto no puede ser inferior a 500.000 o mayor a 20.000.000");
                    }

                    prestamo = PRESTAMO_Negocio.Guardar(prestamo);
                    if (prestamo != null)
                    {
                        prestamoBase.SECUENCIAL = prestamo.SECUENCIAL;
                    }
                }
                catch (Exception ex)
                {
                    prestamoBase.MENSAJE = ex.Message;
                }
            }

            return prestamoBase;
        }


    }
}
