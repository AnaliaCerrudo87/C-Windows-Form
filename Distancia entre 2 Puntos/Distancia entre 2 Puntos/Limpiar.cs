using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distancia_entre_2_Puntos
{
    class Limpiar
    {
        public void BorrarCampos(Control control)
        {

            foreach (var txt in control.Controls)
            {
                if(txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
            }
        }

    }
}
