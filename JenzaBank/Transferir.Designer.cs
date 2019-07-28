namespace JenzaBank
{
    partial class vntTransferir
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
            this.btConsignar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ClaveText = new System.Windows.Forms.Label();
            this.UsuarioText = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtTrans = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btConsignar
            // 
            this.btConsignar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btConsignar.AutoEllipsis = true;
            this.btConsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsignar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsignar.ForeColor = System.Drawing.Color.Firebrick;
            this.btConsignar.Location = new System.Drawing.Point(196, 322);
            this.btConsignar.Name = "btConsignar";
            this.btConsignar.Size = new System.Drawing.Size(100, 27);
            this.btConsignar.TabIndex = 34;
            this.btConsignar.Text = "Transferir";
            this.btConsignar.UseVisualStyleBackColor = true;
            this.btConsignar.Click += new System.EventHandler(this.btConsignar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(177, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "$";
            // 
            // ClaveText
            // 
            this.ClaveText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClaveText.AutoSize = true;
            this.ClaveText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClaveText.Location = new System.Drawing.Point(177, 267);
            this.ClaveText.Name = "ClaveText";
            this.ClaveText.Size = new System.Drawing.Size(49, 17);
            this.ClaveText.TabIndex = 32;
            this.ClaveText.Text = "Clave";
            // 
            // UsuarioText
            // 
            this.UsuarioText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsuarioText.AutoSize = true;
            this.UsuarioText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioText.Location = new System.Drawing.Point(177, 207);
            this.UsuarioText.Name = "UsuarioText";
            this.UsuarioText.Size = new System.Drawing.Size(143, 17);
            this.UsuarioText.TabIndex = 31;
            this.UsuarioText.Text = "Valor a Transferir:";
            // 
            // txtClave
            // 
            this.txtClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClave.Location = new System.Drawing.Point(195, 287);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(100, 20);
            this.txtClave.TabIndex = 30;
            // 
            // txtTrans
            // 
            this.txtTrans.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTrans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrans.Location = new System.Drawing.Point(195, 175);
            this.txtTrans.Name = "txtTrans";
            this.txtTrans.Size = new System.Drawing.Size(100, 20);
            this.txtTrans.TabIndex = 29;
            this.txtTrans.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Cuenta a Transferir:";
            // 
            // txtValor
            // 
            this.txtValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Location = new System.Drawing.Point(195, 227);
            this.txtValor.MaxLength = 100000;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 35;
            // 
            // Logo
            // 
            this.Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Logo.Image = global::JenzaBank.Properties.Resources.Logo_Bank_Epico_5;
            this.Logo.Location = new System.Drawing.Point(107, 2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(262, 133);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 28;
            this.Logo.TabStop = false;
            // 
            // vntTransferir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(480, 393);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btConsignar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ClaveText);
            this.Controls.Add(this.UsuarioText);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtTrans);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "vntTransferir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Transferir";
            this.Load += new System.EventHandler(this.vntTransferir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConsignar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ClaveText;
        private System.Windows.Forms.Label UsuarioText;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtTrans;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
    }
}