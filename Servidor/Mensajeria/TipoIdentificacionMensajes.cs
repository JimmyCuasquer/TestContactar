using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensajeria
{
    public class TipoIdentificacionMSJ
    {
        public TipoIdentificacionMSJ(
            string cODIGO, string nOMBRE, bool eSTAACTIVO
            )
        {
            CODIGO = cODIGO;
            NOMBRE = nOMBRE;
            ESTAACTIVO = eSTAACTIVO;
        }
        public TipoIdentificacionMSJ()
        {

        }
        public string CODIGO { get; set; }
        public string NOMBRE { get; set; }
        public bool ESTAACTIVO { get; set; }
    }
}
