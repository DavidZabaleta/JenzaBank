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
    public partial class vntTransferir : Form
    {
        Validacion val = new Validacion();
        Interfaz ocultar = new Interfaz();
        public vntTransferir()
        {
            InitializeComponent();
        }
        bool aux = true;
        Int32 cnta;

        //Resta
        public void RealizarTransfRes()
        {
            

            Double reti = 0;
            //este es el nombre del archivo que administra los clientes
            string fileName = "clientes.txt";
            //este es el nombre de un archivo de copia
            string fileCopia = "copia_clientes.txt";
            // esto inserta texto en un archivo existente, si el archivo no existe lo crea
            StreamWriter writer = File.AppendText(fileCopia);
            StreamReader reader = File.OpenText(fileName);
            StreamReader readeer = File.OpenText(fileName);

            //este vector es para realizar la presentación de los datos

            string clave = (txtClave.Text);

            reti = Convert.ToDouble(txtValor.Text);

            cnta = Convert.ToInt32(txtTrans.Text);



            while (!reader.EndOfStream)
            {
                //este contador es para moverse entre las diferentes etiquetas
                string lineaActual = reader.ReadLine();
                string[] dato = lineaActual.Split('/');
                if (dato[7] == clave)
                {
                    string lineaAux = readeer.ReadLine();
                    string[] datos = lineaActual.Split('/');
                    if (cnta == Convert.ToInt32(datos[0]))
                    {
                        if (reti <= Convert.ToDouble(datos[6]))
                        {
                            reti = Convert.ToDouble(datos[6]) - reti;
                            writer.WriteLine("{0}/{1}/{2}/{3}/{4}/{5}/{6}/{7}", datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], reti, datos[7]);

                        }
                        else
                        {
                            MessageBox.Show("No posee los fondos suficientes para realizar esta operación.", "Transacción Declinada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            aux = false;
                            writer.WriteLine(lineaActual);
                        } 
                    }

                }
                else
                {                    
                    writer.WriteLine(lineaActual);
                    
                }
            }



            writer.Close();
            reader.Close();
            readeer.Close();
            File.Replace(fileCopia, fileName, null, true);
           


        }
        //Suma
        public void RealizarTransfSum()
        {
            
            
            //este es el nombre del archivo que administra los clientes
            string fileName = "clientes.txt";
            //este es el nombre de un archivo de copia
            string fileCopia = "copia_clientes.txt";
            // esto inserta texto en un archivo existente, si el archivo no existe lo crea
            StreamWriter writer = File.AppendText(fileCopia);
            StreamReader reader = File.OpenText(fileName);

            //este vector es para realizar la presentación de los datos

            string clave = (txtClave.Text);

            Int32 retir = Convert.ToInt32(txtValor.Text);
            cnta= Convert.ToInt32(txtTrans.Text);


            while (!reader.EndOfStream)
            {
                //este contador es para moverse entre las diferentes etiquetas
                string lineaActual = reader.ReadLine();
                string[] datos = lineaActual.Split('/');
                if (cnta == Convert.ToInt32(datos[0]))
                {

                    if (aux == true)
                    {
                        retir = Convert.ToInt32(datos[6]) + retir;

                        writer.WriteLine("{0}/{1}/{2}/{3}/{4}/{5}/{6}/{7}", datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], retir, datos[7]);

                        MessageBox.Show("Se transfirio correctamente a la cuenta #" + cnta, "Transacción Éxitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else
                    {
                        
                        writer.WriteLine(lineaActual);
                    }

                }
                else
                {

                    
                    //MessageBox.Show("La cuenta ingresada no existe.", "Transacción Declinada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
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

        private void vntTransferir_Load(object sender, EventArgs e)
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
                RealizarTransfRes();
                RealizarTransfSum();

            }
        }
    }
}
