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
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
        }
        Validacion val = new Validacion();

        private void txtUs_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloNumeros(e);
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            {


                //este es el nombre del archivo que administra los clientes
                string fileName = "clientes.txt";
                //este es el nombre de un archivo de copia
                string fileCopia = "copia_clientes.txt";
                // esto inserta texto en un archivo existente, si el archivo no existe lo crea
                StreamWriter writer = File.AppendText(fileCopia);
                StreamReader reader = File.OpenText(fileName);




                string Cliente = (txtUs.Text);
                int band = 0;




                while (!reader.EndOfStream)
                {

                    string lineaActual = reader.ReadLine();
                    string[] datos = lineaActual.Split('/');
                    if (datos[0] == Cliente)

                    {
                        band = 1;
                        MessageBox.Show(" Nombre(s): "+ datos[1] +"  Apellido(s): "+ datos[2] + "  Direccion: "+ datos[3] + "  Telefono: "+ datos[4]+"  Email: "+ datos[5]+ "  Saldo: $"+ datos[6],"Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        writer.WriteLine("{0}/{1}/{2}/{3}/{4}/{5}/{6}/{7}", datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], datos[6], datos[7]);
                    }

                    else
                    {
                        writer.WriteLine(lineaActual);
                    }
                }
                if (band == 0)
                {
                    MessageBox.Show("El cliente no se encuentra en la Base de Datos", "Borrado Declinado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                writer.Close();
                reader.Close();
                File.Replace(fileCopia, fileName, null, true);
                this.Close();
            }
        }

        private void Consultar_Load(object sender, EventArgs e)
        {

        }
    }
}
