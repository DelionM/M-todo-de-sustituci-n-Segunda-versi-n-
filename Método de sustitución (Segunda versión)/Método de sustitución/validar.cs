using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Método_de_sustitución
{
    class validar
    {
        public static void SoloNumero(KeyPressEventArgs pE)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsControl(pE.KeyChar)) //permitir teclas de control como retroceso
            {
                pE.Handled = false;
            }
            else if (Char.IsWhiteSpace(pE.KeyChar)) //no permitir teclas de control como espacio
            {
                pE.Handled = true;
            }
            else if (pE.KeyChar == '=')//permitir tecla 
            {
                pE.Handled = false;
            }
            else if (pE.KeyChar == '-')//permitir tecla -
            {
                pE.Handled = false;
            }
            else if (Char.IsPunctuation(pE.KeyChar))// no permitir teclas de puntuacion
            {
                pE.Handled = true;
            }
            else if (pE.KeyChar == 'y')//permitir tecla y
            {
                pE.Handled = false;
            }
            else if (pE.KeyChar == 'x')//permitir tecla x
            {
                pE.Handled = false;
            }
            else if (pE.KeyChar == '+')//permitir tecla +
            {
                pE.Handled = false;
            }
            else if (pE.KeyChar == '.')//permitir tecla 
            {
                pE.Handled = false;
            }
            else //el resto de teclas pulsadas se desactivan
            {
                pE.Handled = true;
            }

        }
    }
}
