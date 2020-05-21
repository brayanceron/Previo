using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Previo
{
    class Vender
    {
        string nombre;
        private int codigo;
        private int unidades;
        private int valor;
        



     //METODOS SETTERS
        public static void setnombre(ref Vender objetox, string n)
        {
            objetox.nombre = n;
        }
        public static void setcodigo(ref Vender objetox,int c)
        {
            objetox.codigo = c;
        }
        public static void setunidades(ref Vender objetox,int u)
        {
            objetox.unidades = u;
        }
        public static void setvalor(ref Vender objetox, int v)
        {
            objetox.valor = v;
        }


    //METODOS GETTERS
        public static string getnombre(Vender objetox)
        {
            string r;
            r = objetox.nombre;
            return r;
        }
        public static int getcodigo(Vender objetox)
        {
            int c;
            c = objetox.codigo;
            return c;
        }
        public static int getunidades(Vender objetox)
        {
            int u;
            u = objetox.unidades;
            return u;
        }
        public static int getvalor(Vender objetox)
        {
            int v;
            v = objetox.valor;
            return v;
        }

        
    }
    }

