using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Previo
{
    public partial class Tienda : Form
    {

        public Tienda()
        {
            InitializeComponent();
        }





        //globales
        static ArrayList productos = new ArrayList();
        static ArrayList carrito = new ArrayList();





 
        //Codigo con filosofia orientado a objetos

            //VENTAS
        private void btnregistrar_Click(object sender, EventArgs e)
        {
            string n;
            int c, u, v;



            if (tbxnombre_producto.Text == "") { n = ""; }
            else { n = tbxnombre_producto.Text; }

            if (txbcodigoproducto.Text == "") { c = 0; }
            else { c = Convert.ToInt32(txbcodigoproducto.Text); }

            if (txbunidades.Text =="") { u = 0; }
            else { u = Convert.ToInt32(txbunidades.Text); }

            if (txbxvalor.Text==""){ v = 0; }
            else { v = Convert.ToInt32(txbxvalor.Text); ; }
            
            if(Validar.no_vacio_registrar(n, c, u, v)) {

                registrar(n, c, u, v);
                tbxnombre_producto.Text = "";
                txbcodigoproducto.Text = "";
                txbunidades.Text = "";
                txbxvalor.Text = "";


                btnactualizar_Click(sender, e);
            }

            else { MessageBox.Show("DEBE LLENAR TODOS LOS CAMPOS"); }


        }

        public static void registrar(string n, int c, int u, int v)
        {
            Vender objetoI = new Vender();
            Vender.setnombre(ref objetoI,n);
            Vender.setcodigo(ref objetoI,c);
            Vender.setunidades(ref objetoI,u);
            Vender.setvalor(ref objetoI,v);

            productos.Add(objetoI);
        }

        static int ind;
        public static void buscar_producto_indice(int cd, GroupBox grpadicionar, Label lblresultado)
        {
            Vender objetoIII = new Vender();
            ind = 0;
            for (int i = 0; i < productos.Count; i++)
            {

                objetoIII = (Vender)productos[i];
                if (cd ==  Vender.getcodigo(objetoIII))
                {
                    grpadicionar.Visible = true;
                    lblresultado.Text = "";
                    ind = i;
                    break;
                }
                else
                {
                    grpadicionar.Visible = false;
                    lblresultado.Text = "PRODUCTO NO ENCONTRADO";
                }
            }
        }

        public static void agregar_unidades_aproducto(int agr)
        {
            int u;
            
            Vender objetoIV = new Vender();
            objetoIV = (Vender)productos[ind];

            u = Vender.getunidades(objetoIV) + agr;
            Vender.setunidades(ref objetoIV, u);
         
            productos.RemoveAt(ind);
            productos.Insert(ind, objetoIV);
        }

        public static void reductor_existencias(int comp)
        {
            //DISMINUYE LAS UNIDADES DISPONIBLES
            int nc,u;
            Vender obj_aux = new Vender();
            obj_aux = (Vender)productos[ind];

            u = Vender.getunidades(obj_aux);


            if (comp > u) { MessageBox.Show("NO SE CUENTA CON ESE NUMERO DE UNIDADES"); }
            else
            {
                Vender objetoIV = new Vender();
                objetoIV = (Vender)productos[ind];
                nc = Vender.getunidades(objetoIV) - comp;

                Vender.setunidades(ref objetoIV, nc);
                productos.RemoveAt(ind);
                productos.Insert(ind, objetoIV);
            }
        }




        //COMPRAS O CARRITO

        public static void agregar_carrito(int cod , int comp)
        {
            string nombre;
            int valor;
            int c,u;

            Vender obj_aux = new Vender();
            obj_aux = (Vender)productos[ind];

            nombre = Vender.getnombre(obj_aux);
            valor = Vender.getvalor(obj_aux);
            u = Vender.getunidades(obj_aux);

            int d = carrito.Count; ;

            //PREGUNTAR SI LAS UNIDADES COMPRADAS NO SUPERAN LA OFERTA....
            if (comp > u) { /*mensaje*/}

            else
        {
                //SABIENDO SI YA AÑADI EL PRODUCTO

                Comprar obj_auxII = new Comprar();
                if (d == 0)
                {                    //registrando en el arraylist del carrito
                    Comprar objetoX = new Comprar();
                    Comprar.setnombre(ref objetoX, nombre);
                    Comprar.setcodigo(ref objetoX, cod);
                    Comprar.setvalor(ref objetoX, valor);
                    Comprar.set_unidades_compradas(ref objetoX, comp);

                    carrito.Add(objetoX);
                }


                else
                {
                    bool b = false;
                    int ii = 0;
                    for (int i = 0; i < carrito.Count; i++)
                    {
                        obj_auxII = (Comprar)carrito[i];
                        if (cod == Comprar.getcodigo(obj_auxII))
                        {
                            b = true;
                            ii = i;
                            break;

                        }
                    }

                    if (b == true)
                    {
                        c = Comprar.get_unidadescompradas(obj_auxII) + comp;
                        Comprar.set_unidades_compradas(ref obj_auxII, c);
                        carrito.Remove(ii);
                        //carrito.Insert(ii, obj_auxII);
                    }
                    else
                    {
                        Comprar objetoX = new Comprar();
                        Comprar.setnombre(ref objetoX, nombre);
                        Comprar.setcodigo(ref objetoX, cod);
                        Comprar.setvalor(ref objetoX, valor);
                        Comprar.set_unidades_compradas(ref objetoX, comp);
                        carrito.Add(objetoX);
                    }
                }
            }


        }


        public static Boolean restriccion_quitar(int agr, int cod)
        {
            Boolean r = true;
            Comprar objetoXI = new Comprar();
            for (int i = 0; i < carrito.Count; i++)
            {
                objetoXI = (Comprar)carrito[i];
                if (cod == Comprar.getcodigo(objetoXI))
                {
                    if (agr > Comprar.get_unidadescompradas(objetoXI))
                    {
                        r = false;
                        break;
                    }
                    else
                    {
                        r = true;
                        break;
                    }
                }
            }
            return r;
        }

        public static void Devolver_unidades(int agr, int cod)
        {
            Vender objetoIV = new Vender();
            objetoIV =(Vender) productos[ind];

            int ii=0;
            Comprar objetoV = new Comprar();
            for (int i = 0; i < carrito.Count; i++)
            {
                objetoV = (Comprar)carrito[i];
                if(cod == Comprar.getcodigo(objetoV)) { ii = i; break; }
            }

            if (agr > Comprar.get_unidadescompradas(objetoV))
            {
                MessageBox.Show("ESTA DEVOLVIENDO MAS PRODUCTOS DE LOS QUE COMPRO");
            }
            else
            {
                int nw;
                //DEvolviendo las unidades al catalogo producto
                nw = Vender.getunidades(objetoIV) + agr;
                Vender.setunidades(ref objetoIV, nw);

                productos.RemoveAt(ind);
                productos.Insert(ind, objetoIV);


                nw = Comprar.get_unidadescompradas(objetoV) - agr;
                Comprar.set_unidades_compradas(ref objetoV, nw);
                carrito.RemoveAt(ii);
                carrito.Insert(ii, objetoV);

            }
            ////Vender objetoIV = new Vender();

            ////objetoIV = (Vender)productos[ind];

            ////if (agr > Comprar.get_unidadescompradas(objetoIV))
            ////{
            ////    
            ////}
            ////else
            ////{
            ////    int nw;
            ////    Vender objetoV = new Vender();
            ////    nw = Vender.getunidades(objetoV)+agr;
            ////    Vender.setunidades(ref objetoV, nw);

            ////    productos.RemoveAt(ind);
            ////    productos.Insert(ind, objetoIV);
            ////}
        }























        //botones y otros controles

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            Adicionar abrir = new Adicionar();
            abrir.ShowDialog();
        }

        private void btncomprar_Click(object sender, EventArgs e)
        {
            Comprar2 abrir = new Comprar2();
            abrir.ShowDialog();
            btnactualizar_Click(sender, e);
            button1_Click(sender, e);
        }





        private void lsbxmostrador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void lsbxmostradorcarrito_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public static void obtener_mostrador_carrito()
        {
            
        }

        //bOTON aCTUALIZAR
        private void button1_Click(object sender, EventArgs e)
        {
            btnactualizar_Click(sender, e);

            mostrar_carrito(lsbxmostradorcarrito);
            lbltotal.Visible = true;
            lbltotal.Text = "TOTAL COMPRA : " + total_compra() ;

        }

        private void btnquitar_Click(object sender, EventArgs e)
        {
            Eliminar abrir = new Eliminar();
            abrir.ShowDialog();
            button1_Click(sender, e);
        }

        private void tbxnombre_producto_TextChanged(object sender, EventArgs e)
        {

        }


        //Validar
        private void tbxnombre_producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }
        private void txbunidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }



        private void txbcodigoproducto_KeyPress(object sender, EventArgs e)
        {

        }

        private void txbcodigoproducto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txbunidades_TextChanged(object sender, EventArgs e)
        {

        }

        //boton para generear codigo aleatorio
        private void button2_Click(object sender, EventArgs e)
        {
            Random aleatorio = new Random();
            int ale;
            ale = aleatorio.Next(10000, 99999);
            txbcodigoproducto.Text = Convert.ToString(ale);

        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            Mostrar_misproductos_pestaña_vender(pantalla);
            Mostrador_pestaña_comprar(productos, lsbxmostrador);
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }









        //Mostrando:::

        public static void Mostrar_misproductos_pestaña_vender(ListBox pantalla)
        {

            pantalla.Items.Clear();
            Vender objetoII = new Vender();
            for (int i = 0; i < productos.Count; i++)
            {
                objetoII = (Vender)productos[i];

                pantalla.Items.Add("NOMBRE   : " + Vender.getnombre(objetoII) + "               VALOR : " + Vender.getvalor(objetoII));
                pantalla.Items.Add("CODIGO   : " + Vender.getcodigo(objetoII) + "              UNIDADES : " + Vender.getunidades(objetoII));
                pantalla.Items.Add("_________________________________________________________________________________");
            }
        }

        public static void Mostrador_pestaña_comprar(ArrayList productos, ListBox lsbxmostrador)
        {
            Vender objetoV = new Vender();
            lsbxmostrador.Items.Clear();
            for (int i = 0; i < productos.Count; i++)
            {
                objetoV = (Vender)productos[i];
                lsbxmostrador.Items.Add("NOMBRE   : " +Vender.getnombre(objetoV) + "                         VALOR : " + Vender.getvalor(objetoV));
                lsbxmostrador.Items.Add("CODIGO   : " + Vender.getcodigo(objetoV)+ "                         UNIDADES : " + Vender.getunidades(objetoV));
                lsbxmostrador.Items.Add("_______________________________________________________________________________________________");

            }
        }



        //Mostrando lo de ventas
        public static void mostrar_carrito(ListBox lsbxmostradorcarrito)
        {
            string n;
            int u,c;
            Comprar objetoVIII = new Comprar();
            

            lsbxmostradorcarrito.Items.Clear();
            for (int i = 0; i < carrito.Count; i++)
            {
                objetoVIII = (Comprar)carrito[i];
                n = Comprar.getnombre(objetoVIII);
                c = Comprar.getcodigo(objetoVIII);
                u = Comprar.get_unidadescompradas(objetoVIII);
                lsbxmostradorcarrito.Items.Add("NOMBRE   : " + n+"               CODIGO : "+c  );
                lsbxmostradorcarrito.Items.Add("UNIDADES COMPRADAS: " + u);
                lsbxmostradorcarrito.Items.Add("_______________________________________________________________________________________________");
            }
        }

        public static int total_compra()
        {
            int ct=0;
            Comprar objetoXII = new Comprar();
            for (int i = 0; i < carrito.Count; i++)
            {
                objetoXII = (Comprar)carrito[i];
                ct += (Comprar.getcvalor(objetoXII)*Comprar.get_unidadescompradas(objetoXII));
            }
            return ct;
        }

        private void Tienda_Load(object sender, EventArgs e)
        {

        }
    }





}
