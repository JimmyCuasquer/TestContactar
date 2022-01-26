using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public partial class PAGO_Negocio
    {
        public static PAGO Guardar(PAGO p)
        {
            TestContactarEntities db = new TestContactarEntities();
            try
            {

                if (p != null)
                {
                    db.PAGO.Add(p);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return p;
        }


    }
}
