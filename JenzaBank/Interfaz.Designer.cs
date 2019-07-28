namespace JenzaBank
{
    partial class Interfaz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interfaz));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.queDeseaHacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RetirarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransferirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModificarDatosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblNombreInt = new System.Windows.Forms.Label();
            this.lblApellidoInt = new System.Windows.Forms.Label();
            this.lblCuentaInt = new System.Windows.Forms.Label();
            this.lblSaldoInt = new System.Windows.Forms.Label();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salidaSeguraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidaSeguraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.jenzaBankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queDeseaHacerToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.administradorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(771, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // queDeseaHacerToolStripMenuItem
            // 
            this.queDeseaHacerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RetirarToolStripMenuItem,
            this.TransferirToolStripMenuItem,
            this.ModificarDatosToolStripMenuItem1,
            this.toolStripSeparator1,
            this.salidaSeguraToolStripMenuItem});
            this.queDeseaHacerToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queDeseaHacerToolStripMenuItem.Name = "queDeseaHacerToolStripMenuItem";
            this.queDeseaHacerToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.queDeseaHacerToolStripMenuItem.Text = "¿Que desea hacer?";
            // 
            // RetirarToolStripMenuItem
            // 
            this.RetirarToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RetirarToolStripMenuItem.Name = "RetirarToolStripMenuItem";
            this.RetirarToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.RetirarToolStripMenuItem.Text = "Retirar";
            this.RetirarToolStripMenuItem.Click += new System.EventHandler(this.retirarToolStripMenuItem_Click);
            // 
            // TransferirToolStripMenuItem
            // 
            this.TransferirToolStripMenuItem.Name = "TransferirToolStripMenuItem";
            this.TransferirToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.TransferirToolStripMenuItem.Text = "Transferir";
            this.TransferirToolStripMenuItem.Click += new System.EventHandler(this.TransferirToolStripMenuItem_Click);
            // 
            // ModificarDatosToolStripMenuItem1
            // 
            this.ModificarDatosToolStripMenuItem1.Name = "ModificarDatosToolStripMenuItem1";
            this.ModificarDatosToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.ModificarDatosToolStripMenuItem1.Text = "Modificar datos";
            this.ModificarDatosToolStripMenuItem1.Click += new System.EventHandler(this.ModificarDatosToolStripMenuItem1_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jenzaBankToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem,
            this.crearToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.toolStripSeparator2,
            this.salidaSeguraToolStripMenuItem1});
            this.administradorToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(176, 20);
            this.administradorToolStripMenuItem.Text = "Administrador de Usuarios";
            this.administradorToolStripMenuItem.Visible = false;
            this.administradorToolStripMenuItem.Click += new System.EventHandler(this.administradorToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.crearToolStripMenuItem.Text = "Crear";
            this.crearToolStripMenuItem.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(494, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido a JenzaBank sr(a):";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(494, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Saldo actual:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(494, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Numero de cuenta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(576, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ubicación: Rionegro, Antioquia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(494, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "$";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLogo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.Firebrick;
            this.lblLogo.Location = new System.Drawing.Point(125, 119);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(169, 28);
            this.lblLogo.TabIndex = 11;
            this.lblLogo.Text = "Bienvenido a:";
            this.lblLogo.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblNombreInt
            // 
            this.lblNombreInt.AutoSize = true;
            this.lblNombreInt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNombreInt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreInt.Location = new System.Drawing.Point(494, 207);
            this.lblNombreInt.Name = "lblNombreInt";
            this.lblNombreInt.Size = new System.Drawing.Size(17, 17);
            this.lblNombreInt.TabIndex = 14;
            this.lblNombreInt.Text = "$";
            this.lblNombreInt.Click += new System.EventHandler(this.lblNombreInt_Click);
            // 
            // lblApellidoInt
            // 
            this.lblApellidoInt.AutoSize = true;
            this.lblApellidoInt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblApellidoInt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoInt.Location = new System.Drawing.Point(494, 231);
            this.lblApellidoInt.Name = "lblApellidoInt";
            this.lblApellidoInt.Size = new System.Drawing.Size(17, 17);
            this.lblApellidoInt.TabIndex = 15;
            this.lblApellidoInt.Text = "$";
            // 
            // lblCuentaInt
            // 
            this.lblCuentaInt.AutoSize = true;
            this.lblCuentaInt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCuentaInt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentaInt.Location = new System.Drawing.Point(494, 359);
            this.lblCuentaInt.Name = "lblCuentaInt";
            this.lblCuentaInt.Size = new System.Drawing.Size(17, 17);
            this.lblCuentaInt.TabIndex = 16;
            this.lblCuentaInt.Text = "$";
            // 
            // lblSaldoInt
            // 
            this.lblSaldoInt.AutoSize = true;
            this.lblSaldoInt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSaldoInt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoInt.Location = new System.Drawing.Point(517, 295);
            this.lblSaldoInt.Name = "lblSaldoInt";
            this.lblSaldoInt.Size = new System.Drawing.Size(17, 17);
            this.lblSaldoInt.TabIndex = 17;
            this.lblSaldoInt.Text = "$";
            this.lblSaldoInt.TextChanged += new System.EventHandler(this.lblSaldoInt_Click);
            this.lblSaldoInt.Click += new System.EventHandler(this.lblSaldoInt_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // salidaSeguraToolStripMenuItem
            // 
            this.salidaSeguraToolStripMenuItem.Name = "salidaSeguraToolStripMenuItem";
            this.salidaSeguraToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.salidaSeguraToolStripMenuItem.Text = "Salida Segura";
            this.salidaSeguraToolStripMenuItem.Click += new System.EventHandler(this.salidaSeguraToolStripMenuItem_Click);
            // 
            // salidaSeguraToolStripMenuItem1
            // 
            this.salidaSeguraToolStripMenuItem1.Name = "salidaSeguraToolStripMenuItem1";
            this.salidaSeguraToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.salidaSeguraToolStripMenuItem1.Text = "Salida Segura";
            this.salidaSeguraToolStripMenuItem1.Click += new System.EventHandler(this.salidaSeguraToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(152, 6);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::JenzaBank.Properties.Resources.actualizar;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(696, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Logo
            // 
            this.Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Logo.Image = global::JenzaBank.Properties.Resources.Logo_Bank_Hiperepico;
            this.Logo.Location = new System.Drawing.Point(560, 30);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(130, 130);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 9;
            this.Logo.TabStop = false;
            // 
            // picLogo
            // 
            this.picLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picLogo.Image = global::JenzaBank.Properties.Resources.Logo_Bank_Epico_5;
            this.picLogo.Location = new System.Drawing.Point(77, 167);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(262, 133);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 12;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // jenzaBankToolStripMenuItem
            // 
            this.jenzaBankToolStripMenuItem.Name = "jenzaBankToolStripMenuItem";
            this.jenzaBankToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.jenzaBankToolStripMenuItem.Text = "JenzaBank";
            this.jenzaBankToolStripMenuItem.Click += new System.EventHandler(this.jenzaBankToolStripMenuItem_Click);
            // 
            // Interfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(771, 421);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSaldoInt);
            this.Controls.Add(this.lblCuentaInt);
            this.Controls.Add(this.lblApellidoInt);
            this.Controls.Add(this.lblNombreInt);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Interfaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sucursal Virtual";
            this.Load += new System.EventHandler(this.Interfaz_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem queDeseaHacerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RetirarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TransferirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModificarDatosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox Logo;
        public System.Windows.Forms.Label lblNombreInt;
        public System.Windows.Forms.Label lblApellidoInt;
        public System.Windows.Forms.Label lblCuentaInt;
        public System.Windows.Forms.Label lblSaldoInt;
        public System.Windows.Forms.Label lblLogo;
        public System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salidaSeguraToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem salidaSeguraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jenzaBankToolStripMenuItem;
    }
}