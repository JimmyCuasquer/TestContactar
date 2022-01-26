using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensajeria
{
    public class PagoMSJ
    {
        public PagoMSJ(int sECUENCIAL, int sECUENCIALPRESTAMO, decimal vALORPAGO, DateTime fECHA, decimal sALDOPRESTAMO)
        {
            SECUENCIAL = sECUENCIAL;
            SECUENCIALPRESTAMO = sECUENCIALPRESTAMO;
            VALORPAGO = vALORPAGO;
            FECHA = fECHA;
            SALDOPRESTAMO = sALDOPRESTAMO;
            
        }
        public PagoMSJ()
        {

        }

        public int SECUENCIAL { get; set; }
        public int SECUENCIALPRESTAMO { get; set; }
        public decimal VALORPAGO { get; set; }
        public DateTime FECHA { get; set; }
        public decimal SALDOPRESTAMO { get; set; }
     
    }
}
