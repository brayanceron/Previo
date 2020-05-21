using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Previo
{
    class Validar
    {

        public static void sololetras(KeyPressEventArgs v)
        {
            if (char.IsLetter(v.KeyChar)) { v.Handled = false; }
            else if (char.IsSeparator(v.KeyChar)) { v.Handled = false; }
            else if (char.IsControl(v.KeyChar)) { v.Handled = false; }
            else { v.Handled = true; MessageBox.Show("EN ESTE CAMPO SOLO PUEDES INGRESAR CARACTERES"); }
        }



        public static void solonumeros(KeyPressEventArgs v)
        {
            if (char.IsDigit(v.KeyChar)) { v.Handled = false; }
            else if (char.IsSeparator(v.KeyChar)) { v.Handled = false; }
            else if (char.IsControl(v.KeyChar)) { v.Handled = false; }
            else { v.Handled = true; MessageBox.Show("EN ESTE CAMPO SOLO PUEDES INGRESAR NUMEROS"); }
        }

        public static Boolean no_vacio_registrar(string n,int c,int u ,int v)
        {
            Boolean bol = true;
            if (n == "") { bol = false; }
            if (c == 0) { bol = false; }
            if (u == 0) { bol = false; }
            if (v == 0) { bol = false; }
            return bol;
        }
    }
}
