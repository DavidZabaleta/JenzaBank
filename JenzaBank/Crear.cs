using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JenzaBank
{
    public partial class Crear : Form
    {
        public Crear()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int a = 999999;
        Validacion val = new Validacion();

        private void btRegistro_Click(object sender, EventArgs e)
        {
            if (txtN.Text == "" || txtClave.Text == "" || txtA.Text == "" || txtCo.Text == "" || txtTe.Text == "" || txtDi.Text == "")
            {
                MessageBox.Show("Faltan datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Cliente cliente = new Cliente();

                cliente.codigo = Convert.ToString(rnd.Next(a));

                cliente.nombre = txtN.Text;

                cliente.apellido = txtA.Text;

                cliente.direccion = txtDi.Text;

                cliente.telefono = txtTe.Text;

                cliente.email = txtCo.Text;

                cliente.contrasena = txtClave.Text;

                cliente.saldo = "0";


                //se define el nombre del archivo en el cual se almacenarán los datos del sistema
                string fileName = "clientes.txt";
                // esto inserta texto en un archivo existente, si el archivo no existe lo crea
                StreamWriter writer = File.AppendText(fileName);
                //escribe cada campo separado por el signo & de esta forma el split ayudará en la recuperación
                writer.WriteLine("{0}/{1}/{2}/{3}/{4}/{5}/{6}/{7}", cliente.codigo, cliente.nombre, cliente.apellido,
                    cliente.direccion, cliente.telefono, cliente.email, cliente.saldo, cliente.contrasena);
                writer.Close();

                txtN.Clear();
                txtA.Clear();
                txtDi.Clear();
                txtTe.Clear();
                txtClave.Clear();
                txtCo.Clear();
                MessageBox.Show("El numero de cuenta es : " + cliente.codigo + " y el saldo es: $0", "Registro Éxitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public struct Cliente
        {
            public string codigo;
            public string nombre;
            public string apellido;
            public string direccion;
            public string telefono;
            public string email;
            public string saldo;
            public string contrasena;
        }

        private void txtN_KeyPress(object sender, KeyPressEventArgs a)
        {
            val.SoloLetras(a);
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs a)
        {
            val.SoloLetras(a);
        }

        private void txtTe_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloNumeros(e);
        }

        private void txtCo_KeyPress(object sender, KeyPressEventArgs b)
        {
            val.Correo(b);
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.Contrasena(e);
        }
    }
}
