namespace JenzaBank
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.helpUsuario = new System.Windows.Forms.HelpProvider();
            this.UsuarioText = new System.Windows.Forms.Label();
            this.helpClave = new System.Windows.Forms.HelpProvider();
            this.ClaveText = new System.Windows.Forms.Label();
            this.Ingresar = new System.Windows.Forms.Button();
            this.Registro = new System.Windows.Forms.Button();
            this.Consig = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpUsuario.SetHelpString(this.txtUsuario, "Ingrese su  numero de cuenta");
            this.txtUsuario.Location = new System.Drawing.Point(127, 161);
            this.txtUsuario.MaxLength = 6;
            this.txtUsuario.Name = "txtUsuario";
            this.helpUsuario.SetShowHelp(this.txtUsuario, true);
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // txtClave
            // 
            this.txtClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpClave.SetHelpString(this.txtClave, "Ingrese su contraseña, si la olvido comuniquese con el administrador");
            this.txtClave.Location = new System.Drawing.Point(127, 214);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.helpClave.SetShowHelp(this.txtClave, true);
            this.txtClave.Size = new System.Drawing.Size(100, 20);
            this.txtClave.TabIndex = 2;
            this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClave_KeyPress);
            // 
            // UsuarioText
            // 
            this.UsuarioText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsuarioText.AutoSize = true;
            this.UsuarioText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpUsuario.SetHelpKeyword(this.UsuarioText, "xdxd");
            this.UsuarioText.Location = new System.Drawing.Point(127, 142);
            this.UsuarioText.Name = "UsuarioText";
            this.helpUsuario.SetShowHelp(this.UsuarioText, true);
            this.helpClave.SetShowHelp(this.UsuarioText, false);
            this.UsuarioText.Size = new System.Drawing.Size(115, 14);
            this.UsuarioText.TabIndex = 4;
            this.UsuarioText.Text = "Numero de Cuenta";
            // 
            // ClaveText
            // 
            this.ClaveText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClaveText.AutoSize = true;
            this.ClaveText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClaveText.Location = new System.Drawing.Point(127, 195);
            this.ClaveText.Name = "ClaveText";
            this.ClaveText.Size = new System.Drawing.Size(40, 14);
            this.ClaveText.TabIndex = 5;
            this.ClaveText.Text = "Clave";
            // 
            // Ingresar
            // 
            this.Ingresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ingresar.AutoEllipsis = true;
            this.Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ingresar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingresar.ForeColor = System.Drawing.Color.Firebrick;
            this.Ingresar.Location = new System.Drawing.Point(139, 255);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Size = new System.Drawing.Size(75, 23);
            this.Ingresar.TabIndex = 6;
            this.Ingresar.Text = "Ingresar";
            this.Ingresar.UseVisualStyleBackColor = true;
            this.Ingresar.Click += new System.EventHandler(this.Ingresar_Click);
            // 
            // Registro
            // 
            this.Registro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Registro.AutoEllipsis = true;
            this.Registro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registro.ForeColor = System.Drawing.Color.Firebrick;
            this.Registro.Location = new System.Drawing.Point(253, 294);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(86, 23);
            this.Registro.TabIndex = 7;
            this.Registro.Text = "Registrarse";
            this.Registro.UseVisualStyleBackColor = true;
            this.Registro.Click += new System.EventHandler(this.Registro_Click);
            // 
            // Consig
            // 
            this.Consig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Consig.AutoEllipsis = true;
            this.Consig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Consig.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consig.ForeColor = System.Drawing.Color.Firebrick;
            this.Consig.Location = new System.Drawing.Point(3, 294);
            this.Consig.Name = "Consig";
            this.Consig.Size = new System.Drawing.Size(86, 23);
            this.Consig.TabIndex = 8;
            this.Consig.Text = "Consignar";
            this.Consig.UseVisualStyleBackColor = true;
            this.Consig.Click += new System.EventHandler(this.Consig_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblError.Location = new System.Drawing.Point(129, 299);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(91, 12);
            this.lblError.TabIndex = 9;
            this.lblError.Text = "Datos Erroneos";
            this.lblError.Visible = false;
            // 
            // Logo
            // 
            this.Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Logo.Image = global::JenzaBank.Properties.Resources.Logo_Bank_Epico_5;
            this.Logo.Location = new System.Drawing.Point(44, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(267, 133);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // Login
            // 
            this.AccessibleName = "Login";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(344, 321);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.Consig);
            this.Controls.Add(this.Registro);
            this.Controls.Add(this.Ingresar);
            this.Controls.Add(this.ClaveText);
            this.Controls.Add(this.UsuarioText);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.Logo);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sucursal Virtual";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.HelpProvider helpUsuario;
        private System.Windows.Forms.HelpProvider helpClave;
        private System.Windows.Forms.Label UsuarioText;
        private System.Windows.Forms.Label ClaveText;
        private System.Windows.Forms.Button Ingresar;
        private System.Windows.Forms.Button Registro;
        private System.Windows.Forms.Button Consig;
        private System.Windows.Forms.Label lblError;
    }
}

