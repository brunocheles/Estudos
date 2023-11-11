namespace MyContab
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
            this.LBLUsuario = new System.Windows.Forms.Label();
            this.LBLSenha = new System.Windows.Forms.Label();
            this.TBUsuario = new System.Windows.Forms.TextBox();
            this.TBSenha = new System.Windows.Forms.TextBox();
            this.BTNLogar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLUsuario
            // 
            this.LBLUsuario.AutoSize = true;
            this.LBLUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLUsuario.Location = new System.Drawing.Point(13, 13);
            this.LBLUsuario.Name = "LBLUsuario";
            this.LBLUsuario.Size = new System.Drawing.Size(53, 15);
            this.LBLUsuario.TabIndex = 0;
            this.LBLUsuario.Text = "Usuário:";
            // 
            // LBLSenha
            // 
            this.LBLSenha.AutoSize = true;
            this.LBLSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLSenha.Location = new System.Drawing.Point(13, 38);
            this.LBLSenha.Name = "LBLSenha";
            this.LBLSenha.Size = new System.Drawing.Size(46, 15);
            this.LBLSenha.TabIndex = 1;
            this.LBLSenha.Text = "Senha:";
            // 
            // TBUsuario
            // 
            this.TBUsuario.Location = new System.Drawing.Point(72, 12);
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.Size = new System.Drawing.Size(100, 20);
            this.TBUsuario.TabIndex = 2;
            // 
            // TBSenha
            // 
            this.TBSenha.Location = new System.Drawing.Point(72, 37);
            this.TBSenha.Name = "TBSenha";
            this.TBSenha.PasswordChar = '*';
            this.TBSenha.Size = new System.Drawing.Size(100, 20);
            this.TBSenha.TabIndex = 3;
            this.TBSenha.UseSystemPasswordChar = true;
            // 
            // BTNLogar
            // 
            this.BTNLogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLogar.Location = new System.Drawing.Point(16, 63);
            this.BTNLogar.Name = "BTNLogar";
            this.BTNLogar.Size = new System.Drawing.Size(156, 23);
            this.BTNLogar.TabIndex = 4;
            this.BTNLogar.Text = "Login";
            this.BTNLogar.UseVisualStyleBackColor = true;
            this.BTNLogar.Click += new System.EventHandler(this.BTNLogar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 97);
            this.Controls.Add(this.BTNLogar);
            this.Controls.Add(this.TBSenha);
            this.Controls.Add(this.TBUsuario);
            this.Controls.Add(this.LBLSenha);
            this.Controls.Add(this.LBLUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLUsuario;
        private System.Windows.Forms.Label LBLSenha;
        private System.Windows.Forms.TextBox TBUsuario;
        private System.Windows.Forms.TextBox TBSenha;
        private System.Windows.Forms.Button BTNLogar;
    }
}