using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public partial class PRESTAMO_Negocio
    {
        public static PRESTAMO Guardar(PRESTAMO p)
        {
            TestContactarEntities db = new TestContactarEntities();
            try
            {

                if (p != null)
                {
                    PRESTAMO prestamo = db.PRESTAMO.Where(x => x.SECUENCIALPERSONA == p.SECUENCIALPERSONA && x.ESTADOPRESTAMO.CODIGO.Equals("V")).FirstOrDefault();

                    if (prestamo == null)
                    {
                        db.PRESTAMO.Add(p);
                        db.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Cliente ya tiene un préstamo vigente, Por favor cancele el préstamo para otorgarle uno nuevo");
                    }
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
