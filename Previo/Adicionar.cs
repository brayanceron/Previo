﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//comentario de prueba
namespace Previo
{
    public partial class Adicionar : Form
    {
        public Adicionar()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

                int cddd;
                cddd = Convert.ToInt32(txbcodigo.Text);
                
                Tienda.buscar_producto_indice(cddd, grpadicionar, lblresultado);

        }

        private void txbcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            int agr;
            agr = Convert.ToInt32(txbadicionar.Text);

            Tienda.agregar_unidades_aproducto(agr);

            this.Close();
        }



        private void txbcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void txbadicionar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void Adicionar_Load(object sender, EventArgs e)
        {
            txbcodigo.Text = "";
        }
    }
}
