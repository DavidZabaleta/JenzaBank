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
    public partial class VntRetirar : Form
    {
        Interfaz inte = new Interfaz();
        Validacion val = new Validacion();
        //VntRetirar chao = new VntRetirar();
        
        public VntRetirar()
        {
            InitializeComponent();
        }
        
        //Realizar una consignacion
        public void RealizarRetiro()
        {
            bool una = true;
            
            Double reti = 0;
            //este es el nombre del archivo que administra los clientes
            string fileName = "clientes.txt";
            //este es el nombre de un archivo de copia
            string fileCopia = "copia_clientes.txt";
            // esto inserta texto en un archivo existente, si el archivo no existe lo crea
            StreamWriter writer = File.AppendText(fileCopia);
            StreamReader reader = File.OpenText(fileName);

            //este vector es para realizar la presentación de los datos

            string clave = (txtClave.Text);

            reti = Convert.ToDouble(txtValor.Text);


            
                while (!reader.EndOfStream)
                {
                    //este contador es para moverse entre las diferentes etiquetas
                    string lineaActual = reader.ReadLine();
                    string[] datos = lineaActual.Split('/');
                    if (datos[7] == clave)
                    {

                        if (reti <= Convert.ToDouble(datos[6]))
                        {
                            reti = Convert.ToDouble(datos[6]) - reti;

                            writer.WriteLine("{0}/{1}/{2}/{3}/{4}/{5}/{6}/{7}", datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], reti, datos[7]);

                            MessageBox.Show("Se retiro correctamente el valor de $" + txtValor.Text + ", su nuevo saldo es de $" + reti, "Retiro Éxitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         
                            
                        }
                        else
                        {
                            MessageBox.Show("No posee los fondos suficientes para realizar esta operación.", "Transacción Declinada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtValor.Clear();
                            txtClave.Clear();
                            writer.WriteLine(lineaActual);
                        }

                    }
                    else
                    {

                        if (datos[0]== Convert.ToString(inte.lblCuentaInt))
                        {
                            
                            if (una == true)
                            {
                                MessageBox.Show("Clave errónea", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                una = false;

                            } 
                        }
                        writer.WriteLine(lineaActual);
                        
                        
                        
                    }
                }
                
           
            
            writer.Close();
            reader.Close();
            File.Replace(fileCopia, fileName, null, true);
            this.Close();
            

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

    



    private void VntRetirar_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void Clave_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloNumeros(e);
        }

        private void btConsignar_Click(object sender, EventArgs e)
        {
            if (txtClave.Text == "" || txtValor.Text == "")
            {

            }
            else
            {
                RealizarRetiro();

               
            }
            
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.Contrasena(e);
        }
    }
}
