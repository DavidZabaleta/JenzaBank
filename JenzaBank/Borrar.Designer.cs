namespace JenzaBank
{
    partial class Borrar
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
            this.btBorrar = new System.Windows.Forms.Button();
            this.txtUs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btBorrar
            // 
            this.btBorrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btBorrar.AutoEllipsis = true;
            this.btBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBorrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBorrar.ForeColor = System.Drawing.Color.Firebrick;
            this.btBorrar.Location = new System.Drawing.Point(190, 321);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(100, 27);
            this.btBorrar.TabIndex = 32;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // txtUs
            // 
            this.txtUs.Location = new System.Drawing.Point(190, 243);
            this.txtUs.MaxLength = 6;
            this.txtUs.Name = "txtUs";
            this.txtUs.Size = new System.Drawing.Size(100, 20);
            this.txtUs.TabIndex = 33;
            this.txtUs.TextChanged += new System.EventHandler(this.txtUs_TextChanged);
            this.txtUs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUs_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(168, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Numero de cuenta:";
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
            this.Logo.TabIndex = 34;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // Borrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(480, 393);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.txtUs);
            this.Controls.Add(this.btBorrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Borrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Borrar";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.TextBox txtUs;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label label4;
    }
}