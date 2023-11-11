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
            this.label1 = new System.Windows.Forms.Label();
            this.TBValAtivo = new System.Windows.Forms.TextBox();
            this.BTNConfirmarAtivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o valor:";
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
            // NovoPassivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 88);
            this.Controls.Add(this.BTNConfirmarPas);
            this.Controls.Add(this.TBValPassivo);
            this.Controls.Add(this.label1);
            this.Name = "NovoPassivo";
            this.Text = "Inserir Passivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBValPassivo;
        private System.Windows.Forms.Button BTNConfirmarPas;
    }
}