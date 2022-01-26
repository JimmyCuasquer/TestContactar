using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public partial class TIPOIDENTIFICAION_Negocio
    {
        public static List<TIPOIDENTIFICACION> Listar()
        {
            List<TIPOIDENTIFICACION> listaTipoIdentificacion = new List<TIPOIDENTIFICACION>();

            TestContactarEntities db = new TestContactarEntities();
            try
            {
                listaTipoIdentificacion = db.TIPOIDENTIFICACION.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listaTipoIdentificacion;

        }
    }
}
