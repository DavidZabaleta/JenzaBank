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
    
    public partial class Login : Form
    {
        public string[] DatosAux = new string[8];
        VntConsignar consignar;
        Validacion val = new Validacion();
        public Login()
        {
            InitializeComponent();
        }
        public void Logeado()
        {
            Interfaz inte = new Interfaz();
            int Ncuenta;
            //este es el nombre del archivo que administra los clientes
            string fileName = "clientes.txt";
            //este es el nombre de un archivo de copia
            string fileCopia = "copia_clientes.txt";
            // esto inserta texto en un archivo existente, si el archivo no existe lo crea
            StreamWriter writer = File.AppendText(fileCopia);
            StreamReader reader = File.OpenText(fileName);

            //este vector es para realizar la presentación de los datos

            string clave = (txtClave.Text);

            Ncuenta = int.Parse(txtUsuario.Text);


            while (!reader.EndOfStream)
            {
                //este contador es para moverse entre las diferentes etiquetas
                string lineaActual = reader.ReadLine();
                string[] datos = lineaActual.Split('/');
                if (Ncuenta  ==  int.Parse(datos[0])&& clave == datos[7])
                {      
                        this.Hide();
                        writer.WriteLine("{0}/{1}/{2}/{3}/{4}/{5}/{6}/{7}", datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], datos[6], datos[7]);
                        inte.lblNombreInt.Text = datos[1];
                        inte.lblNombreInt.Text = inte.lblNombreInt.Text.ToUpper();
                        inte.lblApellidoInt.Text = datos[2];
                        inte.lblApellidoInt.Text = inte.lblApellidoInt.Text.ToUpper();
                        inte.lblSaldoInt.Text = datos[6];
                        inte.lblCuentaInt.Text = datos[0];
                        inte.Show();
                }
                else
                {
                    writer.WriteLine(lineaActual);
                    lblError.Visible = true;
                    //txtUsuario.Clear();
                    //txtClave.Clear();
                }
            }
            writer.Close();
            reader.Close();
            File.Replace(fileCopia, fileName, null, true);



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

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtClave.Text == "")
            {

            }
            else
            {    
                
                Logeado();
            }
           
        }

        private void Consig_Click(object sender, EventArgs e)
        {
            if (consignar == null)
            {

                consignar = new VntConsignar();
                
                consignar.FormClosed += new FormClosedEventHandler(Consignar_FormClosed);
                consignar.Show();
                this.Hide();
            }
            else
            {
                consignar.Activate();
            }
        }
        void Consignar_FormClosed(object sender, EventArgs e)
        {
            consignar = null;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloNumeros(e);
        }

        private void Registro_Click(object sender, EventArgs e)
        {
            Registro open = new Registro();
            open.Show();
            this.Hide();   
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.Contrasena(e);
        }
    }
}
