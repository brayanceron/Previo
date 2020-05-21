using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Previo

{
    class Comprar
    {

        private string nombre;
        private int codigo;
        private int valor;
        private int unidades_compradas = 0;
    


        
        


        //Metodos Getters
        public static string getnombre(Comprar objetox)
        {
            string r;
            r = objetox.nombre;
            return r;
        }
        public static int getcodigo(Comprar objetox)
        {
            int r;
            r = objetox.codigo;

            return r;
        }
        public static int get_unidadescompradas(Comprar objetox)
        {
            int r;
            r = objetox.unidades_compradas;

            return r;
        }
        public static int getcvalor(Comprar objetox)
        {
            int r;
            r = objetox.valor;

            return r;
        }

        //Metodos Setters
        public static void setnombre(ref Comprar objetox, string n)
        {
            objetox.nombre = n;
        }
        public static void setcodigo(ref Comprar objetox, int c)
        {
            objetox.codigo = c;
        }
        public static void setvalor(ref Comprar objetox, int v)
        {
            objetox.valor = v;
        }

        public static void set_unidades_compradas(ref Comprar objetox, int uc)
        {
            objetox.unidades_compradas = uc;
        }



    }
}
