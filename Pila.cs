using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S3_1_2 {
    internal class Pila {
        private Nodo cima = null;
        private int contador = 0;

        public void Push(string nom) {
            Nodo nuevo = new Nodo();
            nuevo.Nombre = nom;

            nuevo.Sig=cima;
            cima = nuevo;
            contador++;
        }
        public void Mostrar(ListBox ls) {
            Nodo actual = new Nodo();
            ls.Items.Clear();
            while(actual !=null) {
                ls.Items.Add(actual.Nombre);
                actual=actual.Sig;
            }
        }
        public string Pop() {
            if(cima !=null) {
                string nom = cima.Nombre;
                cima=cima.Sig;
                contador--;
                return nom;
            }
            return null;
        }
        public int Contar() {
            return contador;
        }
        public string Peek() {
            if(cima !=null) {
                return cima.Nombre;
            }
            return null;
        }
        public void Clear() {
            cima = null;
            contador=0;
        }
    }
}
