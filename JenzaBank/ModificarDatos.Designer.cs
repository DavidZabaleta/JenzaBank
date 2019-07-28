namespace JenzaBank
{
    partial class vntModificarDatos
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
            this.label1 = new System.Windows.Forms.Label();
            this.btModificar = new System.Windows.Forms.Button();
            this.ClaveText = new System.Windows.Forms.Label();
            this.UsuarioText = new System.Windows.Forms.Label();
            this.txtDi = new System.Windows.Forms.TextBox();
            this.txtTe = new System.Windows.Forms.TextBox();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNClave = new System.Windows.Forms.TextBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Nueva Dirección:";
            // 
            // btModificar
            // 
            this.btModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btModificar.AutoEllipsis = true;
            this.btModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btModificar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModificar.ForeColor = System.Drawing.Color.Firebrick;
            this.btModificar.Location = new System.Drawing.Point(285, 293);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(100, 27);
            this.btModificar.TabIndex = 43;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // ClaveText
            // 
            this.ClaveText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClaveText.AutoSize = true;
            this.ClaveText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClaveText.Location = new System.Drawing.Point(286, 166);
            this.ClaveText.Name = "ClaveText";
            this.ClaveText.Size = new System.Drawing.Size(100, 17);
            this.ClaveText.TabIndex = 41;
            this.ClaveText.Text = "Clave Actual";
            this.ClaveText.Click += new System.EventHandler(this.ClaveText_Click);
            // 
            // UsuarioText
            // 
            this.UsuarioText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsuarioText.AutoSize = true;
            this.UsuarioText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioText.Location = new System.Drawing.Point(82, 218);
            this.UsuarioText.Name = "UsuarioText";
            this.UsuarioText.Size = new System.Drawing.Size(126, 17);
            this.UsuarioText.TabIndex = 40;
            this.UsuarioText.Text = "Nuevo Teléfono:";
            // 
            // txtDi
            // 
            this.txtDi.Location = new System.Drawing.Point(85, 186);
            this.txtDi.Name = "txtDi";
            this.txtDi.Size = new System.Drawing.Size(100, 20);
            this.txtDi.TabIndex = 46;
            // 
            // txtTe
            // 
            this.txtTe.Location = new System.Drawing.Point(85, 238);
            this.txtTe.Name = "txtTe";
            this.txtTe.Size = new System.Drawing.Size(100, 20);
            this.txtTe.TabIndex = 47;
            this.txtTe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTe_KeyPress);
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(86, 298);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(100, 20);
            this.txtCor.TabIndex = 48;
            this.txtCor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCor_KeyPress);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(285, 186);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(100, 20);
            this.txtClave.TabIndex = 49;
            this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClave_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "Nueva Clave";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "Nuevo Email:";
            // 
            // txtNClave
            // 
            this.txtNClave.Location = new System.Drawing.Point(285, 238);
            this.txtNClave.Name = "txtNClave";
            this.txtNClave.PasswordChar = '*';
            this.txtNClave.Size = new System.Drawing.Size(100, 20);
            this.txtNClave.TabIndex = 51;
            this.txtNClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNClave_KeyPress);
            // 
            // Logo
            // 
            this.Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Logo.Image = global::JenzaBank.Properties.Resources.Logo_Bank_Epico_5;
            this.Logo.Location = new System.Drawing.Point(109, 2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(262, 133);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 37;
            this.Logo.TabStop = false;
            // 
            // vntModificarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(480, 393);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNClave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.txtTe);
            this.Controls.Add(this.txtDi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.ClaveText);
            this.Controls.Add(this.UsuarioText);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "vntModificarDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ModificarDatos";
            this.Load += new System.EventHandler(this.vntModificarDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Label ClaveText;
        private System.Windows.Forms.Label UsuarioText;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.TextBox txtDi;
        private System.Windows.Forms.TextBox txtTe;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNClave;
    }
}