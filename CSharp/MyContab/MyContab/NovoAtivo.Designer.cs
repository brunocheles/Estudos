namespace MyContab
{
    partial class NovoAtivo
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
            this.BTNConfirmarAtivo = new System.Windows.Forms.Button();
            this.TBValAtivo = new System.Windows.Forms.TextBox();
            this.LBLValAtivo = new System.Windows.Forms.Label();
            this.BTNCancelarAtivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNConfirmarAtivo
            // 
            this.BTNConfirmarAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNConfirmarAtivo.Location = new System.Drawing.Point(129, 53);
            this.BTNConfirmarAtivo.Name = "BTNConfirmarAtivo";
            this.BTNConfirmarAtivo.Size = new System.Drawing.Size(75, 23);
            this.BTNConfirmarAtivo.TabIndex = 3;
            this.BTNConfirmarAtivo.Text = "Confirmar";
            this.BTNConfirmarAtivo.UseVisualStyleBackColor = true;
            // 
            // TBValAtivo
            // 
            this.TBValAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBValAtivo.Location = new System.Drawing.Point(100, 12);
            this.TBValAtivo.Name = "TBValAtivo";
            this.TBValAtivo.Size = new System.Drawing.Size(104, 21);
            this.TBValAtivo.TabIndex = 5;
            // 
            // LBLValAtivo
            // 
            this.LBLValAtivo.AutoSize = true;
            this.LBLValAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLValAtivo.Location = new System.Drawing.Point(13, 13);
            this.LBLValAtivo.Name = "LBLValAtivo";
            this.LBLValAtivo.Size = new System.Drawing.Size(81, 15);
            this.LBLValAtivo.TabIndex = 4;
            this.LBLValAtivo.Text = "Digite o valor:";
            // 
            // BTNCancelarAtivo
            // 
            this.BTNCancelarAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCancelarAtivo.Location = new System.Drawing.Point(16, 53);
            this.BTNCancelarAtivo.Name = "BTNCancelarAtivo";
            this.BTNCancelarAtivo.Size = new System.Drawing.Size(75, 23);
            this.BTNCancelarAtivo.TabIndex = 6;
            this.BTNCancelarAtivo.Text = "Cancelar";
            this.BTNCancelarAtivo.UseVisualStyleBackColor = true;
            this.BTNCancelarAtivo.Click += new System.EventHandler(this.BTNCancelarAtivo_Click);
            // 
            // NovoAtivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 88);
            this.Controls.Add(this.BTNCancelarAtivo);
            this.Controls.Add(this.TBValAtivo);
            this.Controls.Add(this.LBLValAtivo);
            this.Controls.Add(this.BTNConfirmarAtivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NovoAtivo";
            this.Text = "Inserir Ativo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNConfirmarAtivo;
        private System.Windows.Forms.TextBox TBValAtivo;
        private System.Windows.Forms.Label LBLValAtivo;
        private System.Windows.Forms.Button BTNCancelarAtivo;
    }
}