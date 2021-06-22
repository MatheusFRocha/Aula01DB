using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula01DB.View
{
    public  class MyGlobal
    {
        public static string MontaMensagemErro(Exception ex)
        {
            
            string retorno = ex.Message;
            if (ex.InnerException == null)
            {
                return retorno;
            }
            else
            {
                string erro1 = MontaMensagemErro(ex.InnerException);
                return retorno + " - " + erro1;
            }
        }
    }
}
