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
    public partial class VntConsignar : Form
    {
        Validacion val = new Validacion();
        public VntConsignar()
        {
            
            InitializeComponent();
        }
         public bool p = true;
        public void RealizarConsignacion()
        {
            bool s = true;
            Double consig = 0;
            //este es el nombre del archivo que administra los clientes
            string fileName = "clientes.txt";
            //este es el nombre de un archivo de copia
            string fileCopia = "Clientes_Copia.txt";
            // esto inserta texto en un archivo existente, si el archivo no existe lo crea
            StreamWriter writer = File.AppendText(fileCopia);
            StreamReader reader = File.OpenText(fileName);

            //este vector es para realizar la presentación de los datos

            string consigA = (textNumero.Text);

            consig = Convert.ToDouble(txtValor.Text);

        
            while (!reader.EndOfStream)
            {
                //este contador es para moverse entre las diferentes etiquetas
                string lineaActual = reader.ReadLine();
                string[] datos = lineaActual.Split('/');
                while (s == true)
                {
                    if (consigA != datos[0])
                    {

                        //MessageBox.Show("Usuario invalido", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        s = false;
                        p = false;
                        this.Close();
                    }
                    s = false;
                }
               
                if (datos[0] == consigA)
                {
                    consig = consig + Convert.ToDouble(datos[6]);
                    p = true;
                    writer.WriteLine("{0}/{1}/{2}/{3}/{4}/{5}/{6}/{7}", datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], consig, datos[7]);
                    
                }
                else
                {
                        
                        writer.WriteLine(lineaActual);
                    
                }
                    
               
                
               


            }

            Login mostrar = new Login();
            mostrar.Show();
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

        private void VntConsignar_Load(object sender, EventArgs e)
        {

        }

        private void btConsignar_Click(object sender, EventArgs e)
        {
           if(textNumero.Text == ""||txtValor.Text == "")
            {

            }
            else
            {
                RealizarConsignacion();
                if (p == true)
                {
                    MessageBox.Show("Transacción Éxitosa", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    {
                        this.Close();

                    }
                }
            }

            
          

        }

        private void textNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloNumeros(e);
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloNumeros(e);
        }
    }
}
