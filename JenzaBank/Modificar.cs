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
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();
        }
        Validacion val = new Validacion();
        private void txtUs_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloNumeros(e);
        }

        private void txtTe_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloNumeros(e);
        }

        private void txtCor_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.Correo(e);
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.Contrasena(e);
        }

        private void txtDir_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.Contrasena(e);
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            if (txtCor.Text == "" || txtClave.Text == "" || txtTe.Text == "" || txtDir.Text == "" || txtNClave.Text == "")
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

                    string a = txtUs.Text;
                    if (datos[0]== a)
                    {
                        if (datos[7] == Convert.ToString(txtClave.Text))
                        {


                            cliente.direccion = txtDir.Text;

                            cliente.telefono = txtTe.Text;

                            cliente.email = txtCor.Text;

                            cliente.contrasena = txtNClave.Text;

                            writer.WriteLine("{0}/{1}/{2}/{3}/{4}/{5}/{6}/{7}", datos[0], datos[1], datos[2],
                            cliente.direccion, cliente.telefono, cliente.email, datos[6], cliente.contrasena);


                            txtDir.Clear();
                            txtTe.Clear();
                            txtCor.Clear();
                            txtClave.Clear();
                            txtNClave.Clear();
                            MessageBox.Show("Los datos han sido modificados correctamente", "Actualización Éxitosa ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            writer.WriteLine(lineaActual);
                        }
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

        private void UsuarioText_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtDir_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUs_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClaveText_Click(object sender, EventArgs e)
        {

        }
    }
}
