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
    public partial class vntModificarDatos : Form
    {
        public vntModificarDatos()
        {
            InitializeComponent();
        }
        Interfaz inte = new Interfaz();
        Validacion val = new Validacion();      
        
        private void ClaveText_Click(object sender, EventArgs e)
        {

        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            if ( txtCor.Text == "" || txtClave.Text == "" || txtTe.Text == "" || txtDi.Text == "" || txtNClave.Text == "")
            {
                MessageBox.Show("Revise que haya ingresado correctamente todos los datos.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string fileName = "clientes.txt";
                //este es el nombre de un archivo de copia
                string fileCopia = "copia_clientes.txt";
                // esto inserta texto en un archivo existente, si el archivo no existe lo crea
                StreamWriter writer = File.AppendText(fileCopia);
                StreamReader reader = File.OpenText(fileName);
                Cliente cliente = new Cliente();

                while (!reader.EndOfStream)
                {
                    string lineaActual = reader.ReadLine();
                    string[] datos = lineaActual.Split('/');

                    string a = inte.lblCuentaInt.Text;
                    if (datos[7] == Convert.ToString(txtClave.Text))
                    {


                        cliente.direccion = txtDi.Text;

                        cliente.telefono = txtTe.Text;

                        cliente.email = txtCor.Text;

                        cliente.contrasena = txtNClave.Text;

                        writer.WriteLine("{0}/{1}/{2}/{3}/{4}/{5}/{6}/{7}", datos[0], datos[1], datos[2],
                        cliente.direccion, cliente.telefono, cliente.email, datos[6], cliente.contrasena);
                        

                        txtDi.Clear();
                        txtTe.Clear();
                        txtCor.Clear();
                        txtClave.Clear();
                        txtNClave.Clear();
                        MessageBox.Show("Sus datos han sido modificados correctamente", "Actualización Éxitosa ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        writer.WriteLine(lineaActual);
                    }
                }
                writer.Close();
                reader.Close();
                File.Replace(fileCopia, fileName, null, true);
                this.Close();

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

        private void txtTe_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloNumeros(e);
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.Contrasena(e);
        }

        private void txtNClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.Contrasena(e);
        }

        private void txtCor_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.Correo(e);
        }

        private void vntModificarDatos_Load(object sender, EventArgs e)
        {

        }
    }
}
