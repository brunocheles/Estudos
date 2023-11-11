namespace MyContab
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTNAddAtivo = new System.Windows.Forms.Button();
            this.GBAtivos = new System.Windows.Forms.GroupBox();
            this.LVAtivos = new System.Windows.Forms.ListView();
            this.COLAtivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.COLValorAtivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LBLAtivos = new System.Windows.Forms.Label();
            this.LBLSomaAtivos = new System.Windows.Forms.Label();
            this.LBLSomaPassivos = new System.Windows.Forms.Label();
            this.LBLPassivos = new System.Windows.Forms.Label();
            this.GBPassivos = new System.Windows.Forms.GroupBox();
            this.LVPassivos = new System.Windows.Forms.ListView();
            this.COLPassivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.COLValorPassivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BTNAddPassivo = new System.Windows.Forms.Button();
            this.LBLValTotMes = new System.Windows.Forms.Label();
            this.LBLSomaTotal = new System.Windows.Forms.Label();
            this.CBMes = new System.Windows.Forms.ComboBox();
            this.GPData = new System.Windows.Forms.GroupBox();
            this.CBAno = new System.Windows.Forms.ComboBox();
            this.LBAno = new System.Windows.Forms.Label();
            this.LBMes = new System.Windows.Forms.Label();
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.BTNAtivarAnoMes = new System.Windows.Forms.Button();
            this.GBAtivos.SuspendLayout();
            this.GBPassivos.SuspendLayout();
            this.GPData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNAddAtivo
            // 
            this.BTNAddAtivo.Location = new System.Drawing.Point(11, 543);
            this.BTNAddAtivo.Name = "BTNAddAtivo";
            this.BTNAddAtivo.Size = new System.Drawing.Size(251, 27);
            this.BTNAddAtivo.TabIndex = 0;
            this.BTNAddAtivo.Text = "Inserir novo ativo";
            this.BTNAddAtivo.UseVisualStyleBackColor = true;
            this.BTNAddAtivo.Click += new System.EventHandler(this.button1_Click);
            // 
            // GBAtivos
            // 
            this.GBAtivos.Controls.Add(this.LVAtivos);
            this.GBAtivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBAtivos.Location = new System.Drawing.Point(11, 211);
            this.GBAtivos.Name = "GBAtivos";
            this.GBAtivos.Size = new System.Drawing.Size(251, 326);
            this.GBAtivos.TabIndex = 2;
            this.GBAtivos.TabStop = false;
            this.GBAtivos.Text = "Ativos do Mês";
            // 
            // LVAtivos
            // 
            this.LVAtivos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.COLAtivo,
            this.COLValorAtivo});
            this.LVAtivos.HideSelection = false;
            this.LVAtivos.Location = new System.Drawing.Point(6, 19);
            this.LVAtivos.Name = "LVAtivos";
            this.LVAtivos.Size = new System.Drawing.Size(239, 301);
            this.LVAtivos.TabIndex = 0;
            this.LVAtivos.UseCompatibleStateImageBehavior = false;
            this.LVAtivos.View = System.Windows.Forms.View.Details;
            // 
            // COLAtivo
            // 
            this.COLAtivo.Text = "Ativo";
            this.COLAtivo.Width = 150;
            // 
            // COLValorAtivo
            // 
            this.COLValorAtivo.Text = "Valor";
            this.COLValorAtivo.Width = 85;
            // 
            // LBLAtivos
            // 
            this.LBLAtivos.AutoSize = true;
            this.LBLAtivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLAtivos.Location = new System.Drawing.Point(7, 174);
            this.LBLAtivos.Name = "LBLAtivos";
            this.LBLAtivos.Size = new System.Drawing.Size(124, 24);
            this.LBLAtivos.TabIndex = 3;
            this.LBLAtivos.Text = "Total Ativos:";
            // 
            // LBLSomaAtivos
            // 
            this.LBLSomaAtivos.AutoSize = true;
            this.LBLSomaAtivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLSomaAtivos.ForeColor = System.Drawing.Color.Green;
            this.LBLSomaAtivos.Location = new System.Drawing.Point(137, 177);
            this.LBLSomaAtivos.Name = "LBLSomaAtivos";
            this.LBLSomaAtivos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LBLSomaAtivos.Size = new System.Drawing.Size(39, 20);
            this.LBLSomaAtivos.TabIndex = 4;
            this.LBLSomaAtivos.Text = "R$0";
            // 
            // LBLSomaPassivos
            // 
            this.LBLSomaPassivos.AutoSize = true;
            this.LBLSomaPassivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLSomaPassivos.ForeColor = System.Drawing.Color.Red;
            this.LBLSomaPassivos.Location = new System.Drawing.Point(532, 177);
            this.LBLSomaPassivos.Name = "LBLSomaPassivos";
            this.LBLSomaPassivos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LBLSomaPassivos.Size = new System.Drawing.Size(39, 20);
            this.LBLSomaPassivos.TabIndex = 8;
            this.LBLSomaPassivos.Text = "R$0";
            // 
            // LBLPassivos
            // 
            this.LBLPassivos.AutoSize = true;
            this.LBLPassivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLPassivos.Location = new System.Drawing.Point(377, 174);
            this.LBLPassivos.Name = "LBLPassivos";
            this.LBLPassivos.Size = new System.Drawing.Size(149, 24);
            this.LBLPassivos.TabIndex = 7;
            this.LBLPassivos.Text = "Total Passivos:";
            // 
            // GBPassivos
            // 
            this.GBPassivos.Controls.Add(this.LVPassivos);
            this.GBPassivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBPassivos.Location = new System.Drawing.Point(375, 211);
            this.GBPassivos.Name = "GBPassivos";
            this.GBPassivos.Size = new System.Drawing.Size(251, 326);
            this.GBPassivos.TabIndex = 6;
            this.GBPassivos.TabStop = false;
            this.GBPassivos.Text = "Passivos do Mês";
            // 
            // LVPassivos
            // 
            this.LVPassivos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.COLPassivo,
            this.COLValorPassivo});
            this.LVPassivos.HideSelection = false;
            this.LVPassivos.Location = new System.Drawing.Point(6, 19);
            this.LVPassivos.Name = "LVPassivos";
            this.LVPassivos.Size = new System.Drawing.Size(239, 301);
            this.LVPassivos.TabIndex = 0;
            this.LVPassivos.UseCompatibleStateImageBehavior = false;
            this.LVPassivos.View = System.Windows.Forms.View.Details;
            // 
            // COLPassivo
            // 
            this.COLPassivo.Text = "Passivo";
            this.COLPassivo.Width = 150;
            // 
            // COLValorPassivo
            // 
            this.COLValorPassivo.Text = "Valor";
            this.COLValorPassivo.Width = 85;
            // 
            // BTNAddPassivo
            // 
            this.BTNAddPassivo.Location = new System.Drawing.Point(375, 543);
            this.BTNAddPassivo.Name = "BTNAddPassivo";
            this.BTNAddPassivo.Size = new System.Drawing.Size(251, 27);
            this.BTNAddPassivo.TabIndex = 5;
            this.BTNAddPassivo.Text = "Inserir novo passivo";
            this.BTNAddPassivo.UseVisualStyleBackColor = true;
            this.BTNAddPassivo.Click += new System.EventHandler(this.BTNAddPassivo_Click);
            // 
            // LBLValTotMes
            // 
            this.LBLValTotMes.AutoSize = true;
            this.LBLValTotMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLValTotMes.Location = new System.Drawing.Point(6, 137);
            this.LBLValTotMes.Name = "LBLValTotMes";
            this.LBLValTotMes.Size = new System.Drawing.Size(243, 26);
            this.LBLValTotMes.TabIndex = 9;
            this.LBLValTotMes.Text = "Valor Líquido do Mês:";
            // 
            // LBLSomaTotal
            // 
            this.LBLSomaTotal.AutoSize = true;
            this.LBLSomaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLSomaTotal.ForeColor = System.Drawing.Color.Blue;
            this.LBLSomaTotal.Location = new System.Drawing.Point(255, 137);
            this.LBLSomaTotal.Name = "LBLSomaTotal";
            this.LBLSomaTotal.Size = new System.Drawing.Size(47, 25);
            this.LBLSomaTotal.TabIndex = 10;
            this.LBLSomaTotal.Text = "R$0";
            // 
            // CBMes
            // 
            this.CBMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBMes.FormattingEnabled = true;
            this.CBMes.Location = new System.Drawing.Point(6, 77);
            this.CBMes.Name = "CBMes";
            this.CBMes.Size = new System.Drawing.Size(163, 21);
            this.CBMes.TabIndex = 11;
            this.CBMes.SelectionChangeCommitted += new System.EventHandler(this.CBMes_SelectionChangeCommitted);
            // 
            // GPData
            // 
            this.GPData.Controls.Add(this.CBAno);
            this.GPData.Controls.Add(this.LBAno);
            this.GPData.Controls.Add(this.LBMes);
            this.GPData.Controls.Add(this.CBMes);
            this.GPData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPData.Location = new System.Drawing.Point(449, 15);
            this.GPData.Name = "GPData";
            this.GPData.Size = new System.Drawing.Size(177, 108);
            this.GPData.TabIndex = 12;
            this.GPData.TabStop = false;
            this.GPData.Text = "Data";
            // 
            // CBAno
            // 
            this.CBAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBAno.FormattingEnabled = true;
            this.CBAno.Items.AddRange(new object[] {
            "1999"});
            this.CBAno.Location = new System.Drawing.Point(6, 35);
            this.CBAno.Name = "CBAno";
            this.CBAno.Size = new System.Drawing.Size(163, 21);
            this.CBAno.TabIndex = 16;
            this.CBAno.SelectionChangeCommitted += new System.EventHandler(this.CBAno_SelectionChangeCommitted);
            // 
            // LBAno
            // 
            this.LBAno.AutoSize = true;
            this.LBAno.Location = new System.Drawing.Point(6, 17);
            this.LBAno.Name = "LBAno";
            this.LBAno.Size = new System.Drawing.Size(31, 15);
            this.LBAno.TabIndex = 15;
            this.LBAno.Text = "Ano:";
            // 
            // LBMes
            // 
            this.LBMes.AutoSize = true;
            this.LBMes.Location = new System.Drawing.Point(6, 59);
            this.LBMes.Name = "LBMes";
            this.LBMes.Size = new System.Drawing.Size(34, 15);
            this.LBMes.TabIndex = 14;
            this.LBMes.Text = "Mês:";
            // 
            // PBLogo
            // 
            this.PBLogo.Image = global::MyContab.Properties.Resources.Logo_Exemplo;
            this.PBLogo.Location = new System.Drawing.Point(17, 15);
            this.PBLogo.Name = "PBLogo";
            this.PBLogo.Size = new System.Drawing.Size(217, 98);
            this.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBLogo.TabIndex = 13;
            this.PBLogo.TabStop = false;
            // 
            // BTNAtivarAnoMes
            // 
            this.BTNAtivarAnoMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAtivarAnoMes.Location = new System.Drawing.Point(506, 129);
            this.BTNAtivarAnoMes.Name = "BTNAtivarAnoMes";
            this.BTNAtivarAnoMes.Size = new System.Drawing.Size(120, 34);
            this.BTNAtivarAnoMes.TabIndex = 14;
            this.BTNAtivarAnoMes.Text = "Ativar Ano/Mês";
            this.BTNAtivarAnoMes.UseVisualStyleBackColor = true;
            this.BTNAtivarAnoMes.Click += new System.EventHandler(this.BTNAtivarAnoMes_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 580);
            this.Controls.Add(this.BTNAtivarAnoMes);
            this.Controls.Add(this.PBLogo);
            this.Controls.Add(this.GPData);
            this.Controls.Add(this.LBLSomaTotal);
            this.Controls.Add(this.LBLValTotMes);
            this.Controls.Add(this.LBLSomaPassivos);
            this.Controls.Add(this.LBLPassivos);
            this.Controls.Add(this.GBPassivos);
            this.Controls.Add(this.BTNAddPassivo);
            this.Controls.Add(this.LBLSomaAtivos);
            this.Controls.Add(this.LBLAtivos);
            this.Controls.Add(this.GBAtivos);
            this.Controls.Add(this.BTNAddAtivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MyContab";
            this.GBAtivos.ResumeLayout(false);
            this.GBPassivos.ResumeLayout(false);
            this.GPData.ResumeLayout(false);
            this.GPData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNAddAtivo;
        private System.Windows.Forms.GroupBox GBAtivos;
        private System.Windows.Forms.ListView LVAtivos;
        private System.Windows.Forms.ColumnHeader COLAtivo;
        private System.Windows.Forms.ColumnHeader COLValorAtivo;
        private System.Windows.Forms.Label LBLAtivos;
        private System.Windows.Forms.Label LBLSomaAtivos;
        private System.Windows.Forms.Label LBLSomaPassivos;
        private System.Windows.Forms.Label LBLPassivos;
        private System.Windows.Forms.GroupBox GBPassivos;
        private System.Windows.Forms.ListView LVPassivos;
        private System.Windows.Forms.ColumnHeader COLPassivo;
        private System.Windows.Forms.ColumnHeader COLValorPassivo;
        private System.Windows.Forms.Button BTNAddPassivo;
        private System.Windows.Forms.Label LBLValTotMes;
        private System.Windows.Forms.Label LBLSomaTotal;
        private System.Windows.Forms.ComboBox CBMes;
        private System.Windows.Forms.GroupBox GPData;
        private System.Windows.Forms.Label LBAno;
        private System.Windows.Forms.Label LBMes;
        private System.Windows.Forms.ComboBox CBAno;
        private System.Windows.Forms.PictureBox PBLogo;
        private System.Windows.Forms.Button BTNAtivarAnoMes;
    }
}

