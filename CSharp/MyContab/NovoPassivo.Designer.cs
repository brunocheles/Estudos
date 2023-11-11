namespace MyContab
{
    partial class NovoPassivo
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
            this.LBLValPassivo = new System.Windows.Forms.Label();
            this.TBValPassivo = new System.Windows.Forms.TextBox();
            this.BTNConfirmarPas = new System.Windows.Forms.Button();
            this.BTNCancelarPassivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLValPassivo
            // 
            this.LBLValPassivo.AutoSize = true;
            this.LBLValPassivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLValPassivo.Location = new System.Drawing.Point(13, 13);
            this.LBLValPassivo.Name = "LBLValPassivo";
            this.LBLValPassivo.Size = new System.Drawing.Size(81, 15);
            this.LBLValPassivo.TabIndex = 0;
            this.LBLValPassivo.Text = "Digite o valor:";
            // 
            // TBValPassivo
            // 
            this.TBValPassivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBValPassivo.Location = new System.Drawing.Point(100, 12);
            this.TBValPassivo.Name = "TBValPassivo";
            this.TBValPassivo.Size = new System.Drawing.Size(104, 21);
            this.TBValPassivo.TabIndex = 1;
            // 
            // BTNConfirmarPas
            // 
            this.BTNConfirmarPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNConfirmarPas.Location = new System.Drawing.Point(129, 53);
            this.BTNConfirmarPas.Name = "BTNConfirmarPas";
            this.BTNConfirmarPas.Size = new System.Drawing.Size(75, 23);
            this.BTNConfirmarPas.TabIndex = 2;
            this.BTNConfirmarPas.Text = "Confirmar";
            this.BTNConfirmarPas.UseVisualStyleBackColor = true;
            // 
            // BTNCancelarPassivo
            // 
            this.BTNCancelarPassivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCancelarPassivo.Location = new System.Drawing.Point(16, 53);
            this.BTNCancelarPassivo.Name = "BTNCancelarPassivo";
            this.BTNCancelarPassivo.Size = new System.Drawing.Size(75, 23);
            this.BTNCancelarPassivo.TabIndex = 7;
            this.BTNCancelarPassivo.Text = "Cancelar";
            this.BTNCancelarPassivo.UseVisualStyleBackColor = true;
            this.BTNCancelarPassivo.Click += new System.EventHandler(this.BTNCancelarPassivo_Click);
            // 
            // NovoPassivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 88);
            this.Controls.Add(this.BTNCancelarPassivo);
            this.Controls.Add(this.BTNConfirmarPas);
            this.Controls.Add(this.TBValPassivo);
            this.Controls.Add(this.LBLValPassivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NovoPassivo";
            this.Text = "Inserir Passivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLValPassivo;
        private System.Windows.Forms.TextBox TBValPassivo;
        private System.Windows.Forms.Button BTNConfirmarPas;
        private System.Windows.Forms.Button BTNCancelarPassivo;
    }
}