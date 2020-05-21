using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Previo
{
    public partial class Comprar2 : Form
    {
        public Comprar2()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            int cddd;
            cddd = Convert.ToInt32(txbcodigo.Text);
            
            Tienda.buscar_producto_indice(cddd, grpadicionar, lblresultado);
        }



        private void btnañadircarrito_Click(object sender, EventArgs e)
        {
            int comp,cod;
            comp = Convert.ToInt32(txbcantcomprar.Text);
            cod = Convert.ToInt32(txbcodigo.Text);

            Tienda.reductor_existencias(comp);
            Tienda.agregar_carrito(cod, comp);
            
            this.Close();
        }

















        private void btnagregar_Click(object sender, EventArgs e)
        {

        }

        private void txbadicionar_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpadicionar_Enter(object sender, EventArgs e)
        {

        }

        private void txbcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void txbcantcomprar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }
    }
}
