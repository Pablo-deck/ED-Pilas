using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S3_1_2 {
    public partial class Form1: Form {
        Pila miPila = new Pila();
        public Form1() {
            InitializeComponent();
        }

        private void btnApilar_Click(object sender,EventArgs e) {
            miPila.Push(txtNombre.Text);
            lsNombres.Items.Clear();
            miPila.Mostrar(lsNombres);
        }

        private void btnDesapilar_Click(object sender,EventArgs e) {
            string nom = miPila.Pop();
            if (miPila.Pop()!=null) {
                MessageBox.Show("Desapilado: "+miPila.Pop());
                lsNombres.Items.Clear();
                miPila.Mostrar(lsNombres);
            }
        }

        private void btnVistazo_Click(object sender,EventArgs e) {
            MessageBox.Show("Cima: "+miPila.Peek());
        }

        private void btnElementos_Click(object sender,EventArgs e) {
            MessageBox.Show("# Elementos: "+miPila.Contar());
        }

        private void btnLimpiar_Click(object sender,EventArgs e) {
            miPila.Clear();
            lsNombres.Items.Clear();
        }
    }
}
