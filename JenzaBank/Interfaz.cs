using System;
using System.Windows.Forms;
using System.IO;

namespace JenzaBank
{
    public partial class Interfaz : Form
    {       
        VntRetirar retirar;
        vntTransferir transferir;
        vntModificarDatos modificar;
        Crear crear;
        Borrar ver;
        Login tx = new Login();
        Consultar ob;
        Modificar exp;
        Acerca anali;
        public Interfaz()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void retirarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (retirar == null)
            {
                
                retirar = new VntRetirar();
                retirar.MdiParent = this;
                retirar.FormClosed += new FormClosedEventHandler(retirar_FormClosed);
                retirar.Show();
                lblLogo.Visible = false;
                picLogo.Visible = false;
            }
            else
            {
                retirar.Activate();
                lblLogo.Visible = false;
                picLogo.Visible = false;
            }
        }
        void retirar_FormClosed(object sender, EventArgs e)
        {
            retirar = null;
            lblLogo.Visible = true;
            picLogo.Visible = true;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
                
        

        private void Interfaz_Load(object sender, EventArgs e)
        {
            MdiClient ctlMDI;
            // Loop through all of the form's controls looking
            // for the control of type MdiClient.
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    ctlMDI = (MdiClient)ctl;

                    // Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                    // Catch and ignore the error if casting failed.
                }
            }
            if (lblCuentaInt.Text == "123456" || lblCuentaInt.Text == "654321")
            {
                administradorToolStripMenuItem.Visible = true;
                queDeseaHacerToolStripMenuItem.Visible = false;
            }
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TransferirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (transferir == null)
            {

                transferir = new vntTransferir();
                transferir.MdiParent = this;
                transferir.FormClosed += new FormClosedEventHandler(Transferir_FormClosed);
                transferir.Show();
                lblLogo.Visible = false;
                picLogo.Visible = false;
            }
            else
            {
                transferir.Activate();
                lblLogo.Visible = false;
                picLogo.Visible = false;
            }
        }
        void Transferir_FormClosed(object sender, EventArgs e)
        {
            transferir = null;
            lblLogo.Visible = true;
            picLogo.Visible = true;
        }

        private void ModificarDatosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (modificar == null)
            {

                modificar = new vntModificarDatos();
                modificar.MdiParent = this;
                modificar.FormClosed += new FormClosedEventHandler(ModificarDatos_FormClosed);
                modificar.Show();
                lblLogo.Visible = false;
                picLogo.Visible = false;
            }
            else
            {
                modificar.Activate();
                lblLogo.Visible = false;
                picLogo.Visible = false;
            }
        }
        void ModificarDatos_FormClosed(object sender, EventArgs e)
        {
            modificar = null;
            lblLogo.Visible = true;
            picLogo.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
            
        }

        private void picLogo_Click(object sender, EventArgs e)
        {         
               
               
        }

        private void lblNombreInt_Click(object sender, EventArgs e)
        {

        }

        private void lblSaldoInt_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblSaldoInt.ResetText();
            if (lblSaldoInt.Text == String.Empty)
            {
                lblSaldoInt.Text = "Refresh saldo";
            }
        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (crear == null)
            {

                crear = new Crear();
                crear.MdiParent = this;
                crear.FormClosed += new FormClosedEventHandler(Crear_FormClosed);
                crear.Show();
                lblLogo.Visible = false;
                picLogo.Visible = false;
            }
            else
            {
                crear.Activate();
                lblLogo.Visible = false;
                picLogo.Visible = false;
            }
        }
        void Crear_FormClosed(object sender, EventArgs e)
        {
            crear = null;
            lblLogo.Visible = true;
            picLogo.Visible = true;
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ver == null)
            {

                ver = new Borrar();
                ver.MdiParent = this;
                ver.FormClosed += new FormClosedEventHandler(ver_FormClosed);
                ver.Show();
                lblLogo.Visible = false;
                picLogo.Visible = false;
            }
            else
            {
                ver.Activate();
                lblLogo.Visible = false;
                picLogo.Visible = false;
            }
        }
        void ver_FormClosed(object sender, EventArgs e)
        {
            ver = null;
            lblLogo.Visible = true;
            picLogo.Visible = true;
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ob == null)
            {

                ob = new Consultar();
                ob.MdiParent = this;
                ob.FormClosed += new FormClosedEventHandler(ob_FormClosed);
                ob.Show();
                lblLogo.Visible = false;
                picLogo.Visible = false;
            }
            else
            {
                ob.Activate();
                lblLogo.Visible = false;
                picLogo.Visible = false;
            }
        }
        void ob_FormClosed(object sender, EventArgs e)
        {
            ob = null;
            lblLogo.Visible = true;
            picLogo.Visible = true;
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (exp== null)
            {

                exp = new Modificar();
                exp.MdiParent = this;
                exp.FormClosed += new FormClosedEventHandler(exp_FormClosed);
                exp.Show();
                lblLogo.Visible = false;
                picLogo.Visible = false;
            }
            else
            {
                exp.Activate();
                lblLogo.Visible = false;
                picLogo.Visible = false;
            }

        }
        void exp_FormClosed(object sender, EventArgs e)
        {
            exp = null;
            lblLogo.Visible = true;
            picLogo.Visible = true;
        }

        private void salidaSeguraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            tx.Show();
        }

        private void salidaSeguraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            tx.Show();
        }

        private void jenzaBankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (anali == null)
            {

                anali = new Acerca();
                anali.MdiParent = this;
                anali.FormClosed += new FormClosedEventHandler(anali_FormClosed);
                anali.Show();
                lblLogo.Visible = false;
                picLogo.Visible = false;
            }
            else
            {
                anali.Activate();
                lblLogo.Visible = false;
                picLogo.Visible = false;
            }
        }
        void anali_FormClosed(object sender, EventArgs e)
        {
            anali = null;
            lblLogo.Visible = true;
            picLogo.Visible = true;
        }
    }
}
