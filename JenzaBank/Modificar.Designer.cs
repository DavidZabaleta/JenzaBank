namespace JenzaBank
{
    partial class Modificar
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtNClave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.txtTe = new System.Windows.Forms.TextBox();
            this.txtUs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btModificar = new System.Windows.Forms.Button();
            this.ClaveText = new System.Windows.Forms.Label();
            this.UsuarioText = new System.Windows.Forms.Label();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 64;
            this.label3.Text = "Nuevo Email:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNClave
            // 
            this.txtNClave.Location = new System.Drawing.Point(315, 248);
            this.txtNClave.Name = "txtNClave";
            this.txtNClave.PasswordChar = '*';
            this.txtNClave.Size = new System.Drawing.Size(100, 20);
            this.txtNClave.TabIndex = 63;
            this.txtNClave.TextChanged += new System.EventHandler(this.txtNClave_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 62;
            this.label2.Text = "Nueva Clave";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(315, 196);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(100, 20);
            this.txtClave.TabIndex = 61;
            this.txtClave.TextChanged += new System.EventHandler(this.txtClave_TextChanged);
            this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClave_KeyPress);
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(58, 308);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(100, 20);
            this.txtCor.TabIndex = 60;
            this.txtCor.TextChanged += new System.EventHandler(this.txtCor_TextChanged);
            this.txtCor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCor_KeyPress);
            // 
            // txtTe
            // 
            this.txtTe.Location = new System.Drawing.Point(57, 248);
            this.txtTe.Name = "txtTe";
            this.txtTe.Size = new System.Drawing.Size(100, 20);
            this.txtTe.TabIndex = 59;
            this.txtTe.TextChanged += new System.EventHandler(this.txtTe_TextChanged);
            this.txtTe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTe_KeyPress);
            // 
            // txtUs
            // 
            this.txtUs.Location = new System.Drawing.Point(57, 196);
            this.txtUs.Name = "txtUs";
            this.txtUs.Size = new System.Drawing.Size(100, 20);
            this.txtUs.TabIndex = 58;
            this.txtUs.TextChanged += new System.EventHandler(this.txtUs_TextChanged);
            this.txtUs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUs_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 57;
            this.label1.Text = "Nueva Dirección:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btModificar
            // 
            this.btModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btModificar.AutoEllipsis = true;
            this.btModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btModificar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModificar.ForeColor = System.Drawing.Color.Firebrick;
            this.btModificar.Location = new System.Drawing.Point(191, 327);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(100, 27);
            this.btModificar.TabIndex = 56;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // ClaveText
            // 
            this.ClaveText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClaveText.AutoSize = true;
            this.ClaveText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClaveText.Location = new System.Drawing.Point(310, 176);
            this.ClaveText.Name = "ClaveText";
            this.ClaveText.Size = new System.Drawing.Size(100, 17);
            this.ClaveText.TabIndex = 55;
            this.ClaveText.Text = "Clave Actual";
            this.ClaveText.Click += new System.EventHandler(this.ClaveText_Click);
            // 
            // UsuarioText
            // 
            this.UsuarioText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsuarioText.AutoSize = true;
            this.UsuarioText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioText.Location = new System.Drawing.Point(52, 228);
            this.UsuarioText.Name = "UsuarioText";
            this.UsuarioText.Size = new System.Drawing.Size(126, 17);
            this.UsuarioText.TabIndex = 54;
            this.UsuarioText.Text = "Nuevo Teléfono:";
            this.UsuarioText.Click += new System.EventHandler(this.UsuarioText_Click);
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(316, 308);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(100, 20);
            this.txtDir.TabIndex = 65;
            this.txtDir.TextChanged += new System.EventHandler(this.txtDir_TextChanged);
            this.txtDir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDir_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 17);
            this.label4.TabIndex = 66;
            this.label4.Text = "Numero de Cuenta:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Logo
            // 
            this.Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Logo.Image = global::JenzaBank.Properties.Resources.Logo_Bank_Epico_5;
            this.Logo.Location = new System.Drawing.Point(107, 20);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(262, 133);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 53;
            this.Logo.TabStop = false;
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(480, 393);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNClave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.txtTe);
            this.Controls.Add(this.txtUs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.ClaveText);
            this.Controls.Add(this.UsuarioText);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Modificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Modificar";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNClave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.TextBox txtTe;
        private System.Windows.Forms.TextBox txtUs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Label ClaveText;
        private System.Windows.Forms.Label UsuarioText;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Label label4;
    }
}