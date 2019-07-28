using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JenzaBank
{
    class Validacion
    {
        public void SoloNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                } 
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

            }
            catch (Exception ex)
            {

            }
        }
        public void Contrasena(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if(Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

            }
            catch (Exception ex)
            {

            }
        }
        public void Correo(KeyPressEventArgs b)
        {
            try
            {
                if (Char.IsWhiteSpace(b.KeyChar))
                {
                    b.Handled = true;
                }
                else if (Char.IsControl(b.KeyChar))
                {
                    b.Handled = false;
                }
                else if (Char.IsUpper(b.KeyChar))
                {
                    b.Handled = true;
                }
                else if (Char.IsLower(b.KeyChar))
                {
                    b.Handled = false;
                }
                else if (Char.IsPunctuation(b.KeyChar))
                {
                    b.Handled = false;
                }
                else if (Char.IsNumber(b.KeyChar))
                {
                    b.Handled = false;
                }
                else
                {
                    b.Handled = true;
                }

            }
            catch (Exception ex)
            {

            }
        }
        public void SoloLetras(KeyPressEventArgs a)
        {
            try
            {
                if (Char.IsNumber(a.KeyChar))
                {
                    a.Handled = true;
                }
                else if (Char.IsLetter(a.KeyChar))
                {
                    a.Handled = false;
                }
                else if (Char.IsSeparator(a.KeyChar))
                {
                    a.Handled = false;
                }
                else if (Char.IsControl(a.KeyChar))
                {
                    a.Handled = false;
                }
                else
                {
                    a.Handled = true;
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}
