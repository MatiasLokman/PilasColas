using PilasyColas.Clases;
using PilasyColas.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilasyColas
{
    public partial class FrmPila : Form
    {
        private IColeccion collection;
        public FrmPila()
        {
            InitializeComponent();
            collection = new Pila(20);
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPilas.Text))
            {
                object pila = txtPilas.Text;
                if (collection.Añadir(pila))
                {
                    lstPilas.Items.Add(pila);
                    MessageBox.Show("Se agrego la pila a la coleccion", "Pila", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lista Llena", "Pila", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            txtPilas.Text = "";
            txtPilas.Focus();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (!collection.EstaVacia())
            {
                MessageBox.Show("Primer Elemento " + collection.Primero());
            }
        }

        private void btnVacia_Click(object sender, EventArgs e)
        {
            string Mensaje = collection.EstaVacia() ? "Pila Vacia" : "Pila Con Elementos";
            MessageBox.Show(Mensaje, "Elemento", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {
            object Pila = collection.Extraer();
            lstPilas.Items.Remove(Pila);
        }
    }
}
