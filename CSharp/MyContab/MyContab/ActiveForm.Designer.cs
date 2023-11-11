namespace MyContab
{
    partial class ActiveForm
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
            this.GBMesesAtivos = new System.Windows.Forms.GroupBox();
            this.CBDezembro = new System.Windows.Forms.CheckBox();
            this.CBNovembro = new System.Windows.Forms.CheckBox();
            this.CBOutubro = new System.Windows.Forms.CheckBox();
            this.CBSetembro = new System.Windows.Forms.CheckBox();
            this.CBAgosto = new System.Windows.Forms.CheckBox();
            this.CBJulho = new System.Windows.Forms.CheckBox();
            this.CBJunho = new System.Windows.Forms.CheckBox();
            this.CBMaio = new System.Windows.Forms.CheckBox();
            this.CBAbril = new System.Windows.Forms.CheckBox();
            this.CBMarço = new System.Windows.Forms.CheckBox();
            this.CBFevereiro = new System.Windows.Forms.CheckBox();
            this.CBJaneiro = new System.Windows.Forms.CheckBox();
            this.GBAnos = new System.Windows.Forms.GroupBox();
            this.LVAnosAtivos = new System.Windows.Forms.ListView();
            this.CHAno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LBLAno = new System.Windows.Forms.Label();
            this.GBAtivarAno = new System.Windows.Forms.GroupBox();
            this.BTNHabilitar = new System.Windows.Forms.Button();
            this.RBDesativarAno = new System.Windows.Forms.RadioButton();
            this.RBAtivarAno = new System.Windows.Forms.RadioButton();
            this.NUDAnoAtivo = new System.Windows.Forms.NumericUpDown();
            this.BTNConfirmarAnoMes = new System.Windows.Forms.Button();
            this.BTNCancelarAnoMes = new System.Windows.Forms.Button();
            this.GBMesesAtivos.SuspendLayout();
            this.GBAnos.SuspendLayout();
            this.GBAtivarAno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAnoAtivo)).BeginInit();
            this.SuspendLayout();
            // 
            // GBMesesAtivos
            // 
            this.GBMesesAtivos.Controls.Add(this.CBDezembro);
            this.GBMesesAtivos.Controls.Add(this.CBNovembro);
            this.GBMesesAtivos.Controls.Add(this.CBOutubro);
            this.GBMesesAtivos.Controls.Add(this.CBSetembro);
            this.GBMesesAtivos.Controls.Add(this.CBAgosto);
            this.GBMesesAtivos.Controls.Add(this.CBJulho);
            this.GBMesesAtivos.Controls.Add(this.CBJunho);
            this.GBMesesAtivos.Controls.Add(this.CBMaio);
            this.GBMesesAtivos.Controls.Add(this.CBAbril);
            this.GBMesesAtivos.Controls.Add(this.CBMarço);
            this.GBMesesAtivos.Controls.Add(this.CBFevereiro);
            this.GBMesesAtivos.Controls.Add(this.CBJaneiro);
            this.GBMesesAtivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBMesesAtivos.Location = new System.Drawing.Point(24, 107);
            this.GBMesesAtivos.Name = "GBMesesAtivos";
            this.GBMesesAtivos.Size = new System.Drawing.Size(198, 356);
            this.GBMesesAtivos.TabIndex = 0;
            this.GBMesesAtivos.TabStop = false;
            this.GBMesesAtivos.Text = "Meses Ativos";
            // 
            // CBDezembro
            // 
            this.CBDezembro.Enabled = false;
            this.CBDezembro.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBDezembro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBDezembro.Location = new System.Drawing.Point(6, 327);
            this.CBDezembro.Name = "CBDezembro";
            this.CBDezembro.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CBDezembro.Size = new System.Drawing.Size(186, 21);
            this.CBDezembro.TabIndex = 23;
            this.CBDezembro.Text = "Dezembro";
            this.CBDezembro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBDezembro.UseVisualStyleBackColor = true;
            this.CBDezembro.UseWaitCursor = true;
            this.CBDezembro.Click += new System.EventHandler(this.CBMesClicked);
            // 
            // CBNovembro
            // 
            this.CBNovembro.Enabled = false;
            this.CBNovembro.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBNovembro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBNovembro.Location = new System.Drawing.Point(6, 300);
            this.CBNovembro.Name = "CBNovembro";
            this.CBNovembro.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CBNovembro.Size = new System.Drawing.Size(186, 21);
            this.CBNovembro.TabIndex = 22;
            this.CBNovembro.Text = "Novembro";
            this.CBNovembro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBNovembro.UseVisualStyleBackColor = true;
            this.CBNovembro.UseWaitCursor = true;
            this.CBNovembro.Click += new System.EventHandler(this.CBMesClicked);
            // 
            // CBOutubro
            // 
            this.CBOutubro.Enabled = false;
            this.CBOutubro.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBOutubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOutubro.Location = new System.Drawing.Point(6, 273);
            this.CBOutubro.Name = "CBOutubro";
            this.CBOutubro.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CBOutubro.Size = new System.Drawing.Size(186, 21);
            this.CBOutubro.TabIndex = 21;
            this.CBOutubro.Text = "Outubro";
            this.CBOutubro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBOutubro.UseVisualStyleBackColor = true;
            this.CBOutubro.UseWaitCursor = true;
            this.CBOutubro.Click += new System.EventHandler(this.CBMesClicked);
            // 
            // CBSetembro
            // 
            this.CBSetembro.Enabled = false;
            this.CBSetembro.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBSetembro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBSetembro.Location = new System.Drawing.Point(6, 246);
            this.CBSetembro.Name = "CBSetembro";
            this.CBSetembro.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CBSetembro.Size = new System.Drawing.Size(186, 21);
            this.CBSetembro.TabIndex = 20;
            this.CBSetembro.Text = "Setembro";
            this.CBSetembro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBSetembro.UseVisualStyleBackColor = true;
            this.CBSetembro.UseWaitCursor = true;
            this.CBSetembro.Click += new System.EventHandler(this.CBMesClicked);
            // 
            // CBAgosto
            // 
            this.CBAgosto.Enabled = false;
            this.CBAgosto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBAgosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBAgosto.Location = new System.Drawing.Point(6, 219);
            this.CBAgosto.Name = "CBAgosto";
            this.CBAgosto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CBAgosto.Size = new System.Drawing.Size(186, 21);
            this.CBAgosto.TabIndex = 19;
            this.CBAgosto.Text = "Agosto";
            this.CBAgosto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBAgosto.UseVisualStyleBackColor = true;
            this.CBAgosto.UseWaitCursor = true;
            this.CBAgosto.Click += new System.EventHandler(this.CBMesClicked);
            // 
            // CBJulho
            // 
            this.CBJulho.Enabled = false;
            this.CBJulho.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBJulho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBJulho.Location = new System.Drawing.Point(6, 192);
            this.CBJulho.Name = "CBJulho";
            this.CBJulho.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CBJulho.Size = new System.Drawing.Size(186, 21);
            this.CBJulho.TabIndex = 18;
            this.CBJulho.Text = "Julho";
            this.CBJulho.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBJulho.UseVisualStyleBackColor = true;
            this.CBJulho.UseWaitCursor = true;
            this.CBJulho.Click += new System.EventHandler(this.CBMesClicked);
            // 
            // CBJunho
            // 
            this.CBJunho.Enabled = false;
            this.CBJunho.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBJunho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBJunho.Location = new System.Drawing.Point(6, 165);
            this.CBJunho.Name = "CBJunho";
            this.CBJunho.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CBJunho.Size = new System.Drawing.Size(186, 21);
            this.CBJunho.TabIndex = 17;
            this.CBJunho.Text = "Junho";
            this.CBJunho.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBJunho.UseVisualStyleBackColor = true;
            this.CBJunho.UseWaitCursor = true;
            this.CBJunho.Click += new System.EventHandler(this.CBMesClicked);
            // 
            // CBMaio
            // 
            this.CBMaio.Enabled = false;
            this.CBMaio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBMaio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBMaio.Location = new System.Drawing.Point(6, 138);
            this.CBMaio.Name = "CBMaio";
            this.CBMaio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CBMaio.Size = new System.Drawing.Size(186, 21);
            this.CBMaio.TabIndex = 16;
            this.CBMaio.Text = "Maio";
            this.CBMaio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBMaio.UseVisualStyleBackColor = true;
            this.CBMaio.UseWaitCursor = true;
            this.CBMaio.Click += new System.EventHandler(this.CBMesClicked);
            // 
            // CBAbril
            // 
            this.CBAbril.Enabled = false;
            this.CBAbril.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBAbril.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBAbril.Location = new System.Drawing.Point(6, 111);
            this.CBAbril.Name = "CBAbril";
            this.CBAbril.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CBAbril.Size = new System.Drawing.Size(186, 21);
            this.CBAbril.TabIndex = 15;
            this.CBAbril.Text = "Abril";
            this.CBAbril.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBAbril.UseVisualStyleBackColor = true;
            this.CBAbril.UseWaitCursor = true;
            this.CBAbril.Click += new System.EventHandler(this.CBMesClicked);
            // 
            // CBMarço
            // 
            this.CBMarço.Enabled = false;
            this.CBMarço.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBMarço.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBMarço.Location = new System.Drawing.Point(6, 84);
            this.CBMarço.Name = "CBMarço";
            this.CBMarço.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CBMarço.Size = new System.Drawing.Size(186, 21);
            this.CBMarço.TabIndex = 14;
            this.CBMarço.Text = "Março";
            this.CBMarço.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBMarço.UseVisualStyleBackColor = true;
            this.CBMarço.UseWaitCursor = true;
            this.CBMarço.Click += new System.EventHandler(this.CBMesClicked);
            // 
            // CBFevereiro
            // 
            this.CBFevereiro.Enabled = false;
            this.CBFevereiro.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBFevereiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBFevereiro.Location = new System.Drawing.Point(6, 57);
            this.CBFevereiro.Name = "CBFevereiro";
            this.CBFevereiro.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CBFevereiro.Size = new System.Drawing.Size(186, 21);
            this.CBFevereiro.TabIndex = 13;
            this.CBFevereiro.Text = "Fevereiro";
            this.CBFevereiro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBFevereiro.UseVisualStyleBackColor = true;
            this.CBFevereiro.UseWaitCursor = true;
            this.CBFevereiro.Click += new System.EventHandler(this.CBMesClicked);
            // 
            // CBJaneiro
            // 
            this.CBJaneiro.Enabled = false;
            this.CBJaneiro.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBJaneiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBJaneiro.Location = new System.Drawing.Point(6, 30);
            this.CBJaneiro.Name = "CBJaneiro";
            this.CBJaneiro.Padding = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.CBJaneiro.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CBJaneiro.Size = new System.Drawing.Size(186, 21);
            this.CBJaneiro.TabIndex = 12;
            this.CBJaneiro.Text = "Janeiro";
            this.CBJaneiro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBJaneiro.UseVisualStyleBackColor = true;
            this.CBJaneiro.UseWaitCursor = true;
            this.CBJaneiro.Click += new System.EventHandler(this.CBMesClicked);
            // 
            // GBAnos
            // 
            this.GBAnos.Controls.Add(this.LVAnosAtivos);
            this.GBAnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBAnos.Location = new System.Drawing.Point(322, 107);
            this.GBAnos.Name = "GBAnos";
            this.GBAnos.Size = new System.Drawing.Size(208, 355);
            this.GBAnos.TabIndex = 2;
            this.GBAnos.TabStop = false;
            this.GBAnos.Text = "Anos Ativos";
            // 
            // LVAnosAtivos
            // 
            this.LVAnosAtivos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CHAno});
            this.LVAnosAtivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVAnosAtivos.HideSelection = false;
            this.LVAnosAtivos.Location = new System.Drawing.Point(12, 30);
            this.LVAnosAtivos.Name = "LVAnosAtivos";
            this.LVAnosAtivos.Size = new System.Drawing.Size(184, 317);
            this.LVAnosAtivos.TabIndex = 0;
            this.LVAnosAtivos.UseCompatibleStateImageBehavior = false;
            this.LVAnosAtivos.View = System.Windows.Forms.View.Details;
            // 
            // CHAno
            // 
            this.CHAno.Text = "Ano";
            this.CHAno.Width = 179;
            // 
            // LBLAno
            // 
            this.LBLAno.AutoSize = true;
            this.LBLAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLAno.Location = new System.Drawing.Point(16, 36);
            this.LBLAno.Name = "LBLAno";
            this.LBLAno.Size = new System.Drawing.Size(43, 16);
            this.LBLAno.TabIndex = 5;
            this.LBLAno.Text = "ANO:";
            // 
            // GBAtivarAno
            // 
            this.GBAtivarAno.Controls.Add(this.BTNHabilitar);
            this.GBAtivarAno.Controls.Add(this.RBDesativarAno);
            this.GBAtivarAno.Controls.Add(this.RBAtivarAno);
            this.GBAtivarAno.Controls.Add(this.NUDAnoAtivo);
            this.GBAtivarAno.Controls.Add(this.LBLAno);
            this.GBAtivarAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBAtivarAno.Location = new System.Drawing.Point(24, 12);
            this.GBAtivarAno.Name = "GBAtivarAno";
            this.GBAtivarAno.Size = new System.Drawing.Size(506, 77);
            this.GBAtivarAno.TabIndex = 6;
            this.GBAtivarAno.TabStop = false;
            this.GBAtivarAno.Text = "Ativar Ano";
            // 
            // BTNHabilitar
            // 
            this.BTNHabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNHabilitar.Location = new System.Drawing.Point(417, 32);
            this.BTNHabilitar.Name = "BTNHabilitar";
            this.BTNHabilitar.Size = new System.Drawing.Size(77, 23);
            this.BTNHabilitar.TabIndex = 10;
            this.BTNHabilitar.Text = "Habilitar";
            this.BTNHabilitar.UseVisualStyleBackColor = true;
            this.BTNHabilitar.Click += new System.EventHandler(this.BTNHabilitar_Click);
            // 
            // RBDesativarAno
            // 
            this.RBDesativarAno.AutoSize = true;
            this.RBDesativarAno.BackColor = System.Drawing.SystemColors.Control;
            this.RBDesativarAno.Location = new System.Drawing.Point(300, 32);
            this.RBDesativarAno.Name = "RBDesativarAno";
            this.RBDesativarAno.Size = new System.Drawing.Size(97, 22);
            this.RBDesativarAno.TabIndex = 9;
            this.RBDesativarAno.TabStop = true;
            this.RBDesativarAno.Text = "Desativar";
            this.RBDesativarAno.UseVisualStyleBackColor = false;
            this.RBDesativarAno.Click += new System.EventHandler(this.RBDesativarAno_Click);
            // 
            // RBAtivarAno
            // 
            this.RBAtivarAno.AutoSize = true;
            this.RBAtivarAno.BackColor = System.Drawing.SystemColors.Control;
            this.RBAtivarAno.Location = new System.Drawing.Point(211, 32);
            this.RBAtivarAno.Name = "RBAtivarAno";
            this.RBAtivarAno.Size = new System.Drawing.Size(68, 22);
            this.RBAtivarAno.TabIndex = 8;
            this.RBAtivarAno.TabStop = true;
            this.RBAtivarAno.Text = "Ativar";
            this.RBAtivarAno.UseVisualStyleBackColor = false;
            this.RBAtivarAno.Click += new System.EventHandler(this.RBAtivarAno_Click);
            // 
            // NUDAnoAtivo
            // 
            this.NUDAnoAtivo.Location = new System.Drawing.Point(83, 32);
            this.NUDAnoAtivo.Maximum = new decimal(new int[] {
            2090,
            0,
            0,
            0});
            this.NUDAnoAtivo.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.NUDAnoAtivo.Name = "NUDAnoAtivo";
            this.NUDAnoAtivo.Size = new System.Drawing.Size(93, 24);
            this.NUDAnoAtivo.TabIndex = 6;
            this.NUDAnoAtivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUDAnoAtivo.Value = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.NUDAnoAtivo.ValueChanged += new System.EventHandler(this.NUDAnoAtivo_ValueChanged);
            // 
            // BTNConfirmarAnoMes
            // 
            this.BTNConfirmarAnoMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNConfirmarAnoMes.Location = new System.Drawing.Point(446, 468);
            this.BTNConfirmarAnoMes.Name = "BTNConfirmarAnoMes";
            this.BTNConfirmarAnoMes.Size = new System.Drawing.Size(84, 23);
            this.BTNConfirmarAnoMes.TabIndex = 7;
            this.BTNConfirmarAnoMes.Text = "Confirmar";
            this.BTNConfirmarAnoMes.UseVisualStyleBackColor = true;
            this.BTNConfirmarAnoMes.Click += new System.EventHandler(this.BTNConfirmarAnoMes_Click);
            // 
            // BTNCancelarAnoMes
            // 
            this.BTNCancelarAnoMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCancelarAnoMes.Location = new System.Drawing.Point(24, 469);
            this.BTNCancelarAnoMes.Name = "BTNCancelarAnoMes";
            this.BTNCancelarAnoMes.Size = new System.Drawing.Size(82, 23);
            this.BTNCancelarAnoMes.TabIndex = 8;
            this.BTNCancelarAnoMes.Text = "Cancelar";
            this.BTNCancelarAnoMes.UseVisualStyleBackColor = true;
            this.BTNCancelarAnoMes.Click += new System.EventHandler(this.BTNCancelarAnoMes_Click);
            // 
            // ActiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 508);
            this.Controls.Add(this.BTNCancelarAnoMes);
            this.Controls.Add(this.BTNConfirmarAnoMes);
            this.Controls.Add(this.GBAtivarAno);
            this.Controls.Add(this.GBAnos);
            this.Controls.Add(this.GBMesesAtivos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ActiveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ativar Ano/Mês";
            this.GBMesesAtivos.ResumeLayout(false);
            this.GBAnos.ResumeLayout(false);
            this.GBAtivarAno.ResumeLayout(false);
            this.GBAtivarAno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAnoAtivo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBMesesAtivos;
        private System.Windows.Forms.CheckBox CBJaneiro;
        private System.Windows.Forms.CheckBox CBDezembro;
        private System.Windows.Forms.CheckBox CBNovembro;
        private System.Windows.Forms.CheckBox CBOutubro;
        private System.Windows.Forms.CheckBox CBSetembro;
        private System.Windows.Forms.CheckBox CBAgosto;
        private System.Windows.Forms.CheckBox CBJulho;
        private System.Windows.Forms.CheckBox CBJunho;
        private System.Windows.Forms.CheckBox CBMaio;
        private System.Windows.Forms.CheckBox CBAbril;
        private System.Windows.Forms.CheckBox CBMarço;
        private System.Windows.Forms.CheckBox CBFevereiro;
        private System.Windows.Forms.GroupBox GBAnos;
        private System.Windows.Forms.ListView LVAnosAtivos;
        private System.Windows.Forms.ColumnHeader CHAno;
        private System.Windows.Forms.Label LBLAno;
        private System.Windows.Forms.GroupBox GBAtivarAno;
        private System.Windows.Forms.RadioButton RBDesativarAno;
        private System.Windows.Forms.RadioButton RBAtivarAno;
        private System.Windows.Forms.NumericUpDown NUDAnoAtivo;
        private System.Windows.Forms.Button BTNConfirmarAnoMes;
        private System.Windows.Forms.Button BTNCancelarAnoMes;
        private System.Windows.Forms.Button BTNHabilitar;
    }
}