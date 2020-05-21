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
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            int cddd;
            cddd = Convert.ToInt32(txbcodigo.Text);

           Tienda.buscar_producto_indice(cddd, grpeliminar, lblresultado);
        }

        private void btnquitar_Click(object sender, EventArgs e)
        {
            int agr,cod;
            agr = Convert.ToInt32(txbeliminar.Text);
            cod = Convert.ToInt32(txbcodigo.Text);

            if (Tienda.restriccion_quitar(agr, cod))//para saber si se va a devolver mas de lo que se compro
            {
                Tienda.Devolver_unidades(agr,cod);
                this.Close();
            }
            else { MessageBox.Show("No puede devolver ma productos de los que ya compro"); }

        }






        private void txbcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void txbeliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }
    }
}
