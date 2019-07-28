namespace JenzaBank
{
    partial class VntConsignar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VntConsignar));
            this.textNumero = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btConsignar = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.helpNumero = new System.Windows.Forms.HelpProvider();
            this.helpValor = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // textNumero
            // 
            this.textNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNumero.ForeColor = System.Drawing.SystemColors.WindowText;
            this.helpNumero.SetHelpString(this.textNumero, "Ingrese el número de cuenta de 6 digitos al que desea consignar");
            this.textNumero.Location = new System.Drawing.Point(118, 163);
            this.textNumero.MaxLength = 6;
            this.textNumero.Name = "textNumero";
            this.helpNumero.SetShowHelp(this.textNumero, true);
            this.textNumero.Size = new System.Drawing.Size(100, 20);
            this.textNumero.TabIndex = 0;
            this.textNumero.TextChanged += new System.EventHandler(this.textNumero_TextChanged);
            this.textNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNumero_KeyPress);
            // 
            // txtValor
            // 
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.helpValor.SetHelpKeyword(this.txtValor, "");
            this.helpValor.SetHelpString(this.txtValor, "Ingrese el valor total que desea consignar");
            this.txtValor.Location = new System.Drawing.Point(118, 235);
            this.txtValor.Name = "txtValor";
            this.helpValor.SetShowHelp(this.txtValor, true);
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 1;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Numero de cuenta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Valor a Consignar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "$";
            // 
            // btConsignar
            // 
            this.btConsignar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btConsignar.AutoEllipsis = true;
            this.btConsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsignar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsignar.ForeColor = System.Drawing.Color.Firebrick;
            this.btConsignar.Location = new System.Drawing.Point(118, 282);
            this.btConsignar.Name = "btConsignar";
            this.btConsignar.Size = new System.Drawing.Size(100, 27);
            this.btConsignar.TabIndex = 11;
            this.btConsignar.Text = "Consignar";
            this.btConsignar.UseVisualStyleBackColor = true;
            this.btConsignar.Click += new System.EventHandler(this.btConsignar_Click);
            // 
            // Logo
            // 
            this.Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Logo.Image = global::JenzaBank.Properties.Resources.Logo_Bank_Epico_5;
            this.Logo.Location = new System.Drawing.Point(43, -5);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(262, 133);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 10;
            this.Logo.TabStop = false;
            // 
            // VntConsignar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(344, 321);
            this.Controls.Add(this.btConsignar);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.textNumero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VntConsignar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consignación";
            this.Load += new System.EventHandler(this.VntConsignar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button btConsignar;
        private System.Windows.Forms.HelpProvider helpNumero;
        private System.Windows.Forms.HelpProvider helpValor;
    }
}