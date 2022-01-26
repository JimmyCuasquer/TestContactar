using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensajeria
{
    public class PrestamoMSJ
    {
        public PrestamoMSJ(int sECUENCIAL, int sECUENCIALPERSONA, decimal mONTO, string eSTADO, decimal sALDO)
        {
            SECUENCIAL = sECUENCIAL;
            SECUENCIALPERSONA = sECUENCIALPERSONA;
            MONTO = mONTO;
            ESTADO = eSTADO;
            SALDO = sALDO;

        }
        public PrestamoMSJ()
        {

        }

        public int SECUENCIAL { get; set; }
        public int SECUENCIALPERSONA { get; set; }
        public decimal MONTO { get; set; }
        public string ESTADO { get; set; }
        public decimal SALDO { get; set; }

    }

    public class PrestamoBase
    {
        public PrestamoBase(string iDENTIFICACION, string mONTO)
        {
            IDENTIFICACION = iDENTIFICACION;
            MONTO = mONTO;

        }
        public PrestamoBase()
        {

        }

        public string IDENTIFICACION { get; set; }
        public string MONTO { get; set; }
        public string MENSAJE { get; set; }
        public int SECUENCIAL { get; set; }

    }
}
