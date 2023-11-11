namespace ACNauticaDocumentos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CBCliente = new ComboBox();
            label1 = new Label();
            LVCliente = new ListView();
            groupBox1 = new GroupBox();
            GBTpArq = new GroupBox();
            RB1 = new RadioButton();
            RB2 = new RadioButton();
            RB3 = new RadioButton();
            RB4 = new RadioButton();
            RB5 = new RadioButton();
            BTNGerarArq = new Button();
            BTNEditarDados = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            groupBox1.SuspendLayout();
            GBTpArq.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // CBCliente
            // 
            CBCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            CBCliente.FormattingEnabled = true;
            CBCliente.Location = new Point(67, 22);
            CBCliente.Name = "CBCliente";
            CBCliente.Size = new Size(140, 25);
            CBCliente.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(55, 17);
            label1.TabIndex = 1;
            label1.Text = "Cliente:";
            // 
            // LVCliente
            // 
            LVCliente.Location = new Point(6, 53);
            LVCliente.Name = "LVCliente";
            LVCliente.Size = new Size(201, 129);
            LVCliente.TabIndex = 3;
            LVCliente.UseCompatibleStateImageBehavior = false;
            LVCliente.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BTNEditarDados);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(LVCliente);
            groupBox1.Controls.Add(CBCliente);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(249, 373);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados do Cliente";
            // 
            // GBTpArq
            // 
            GBTpArq.Controls.Add(RB5);
            GBTpArq.Controls.Add(BTNGerarArq);
            GBTpArq.Controls.Add(RB4);
            GBTpArq.Controls.Add(RB3);
            GBTpArq.Controls.Add(RB2);
            GBTpArq.Controls.Add(RB1);
            GBTpArq.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            GBTpArq.Location = new Point(276, 6);
            GBTpArq.Name = "GBTpArq";
            GBTpArq.Size = new Size(250, 373);
            GBTpArq.TabIndex = 5;
            GBTpArq.TabStop = false;
            GBTpArq.Text = "Selecione o Tipo de Arquivo";
            // 
            // RB1
            // 
            RB1.AutoSize = true;
            RB1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            RB1.Location = new Point(6, 26);
            RB1.Name = "RB1";
            RB1.Size = new Size(65, 21);
            RB1.TabIndex = 0;
            RB1.TabStop = true;
            RB1.Text = "Tipo 1";
            RB1.UseVisualStyleBackColor = true;
            // 
            // RB2
            // 
            RB2.AutoSize = true;
            RB2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            RB2.Location = new Point(6, 53);
            RB2.Name = "RB2";
            RB2.Size = new Size(65, 21);
            RB2.TabIndex = 1;
            RB2.TabStop = true;
            RB2.Text = "Tipo 2";
            RB2.UseVisualStyleBackColor = true;
            // 
            // RB3
            // 
            RB3.AutoSize = true;
            RB3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            RB3.Location = new Point(6, 80);
            RB3.Name = "RB3";
            RB3.Size = new Size(65, 21);
            RB3.TabIndex = 2;
            RB3.TabStop = true;
            RB3.Text = "Tipo 3";
            RB3.UseVisualStyleBackColor = true;
            // 
            // RB4
            // 
            RB4.AutoSize = true;
            RB4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            RB4.Location = new Point(6, 107);
            RB4.Name = "RB4";
            RB4.Size = new Size(65, 21);
            RB4.TabIndex = 3;
            RB4.TabStop = true;
            RB4.Text = "Tipo 4";
            RB4.UseVisualStyleBackColor = true;
            // 
            // RB5
            // 
            RB5.AutoSize = true;
            RB5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            RB5.Location = new Point(6, 134);
            RB5.Name = "RB5";
            RB5.Size = new Size(65, 21);
            RB5.TabIndex = 4;
            RB5.TabStop = true;
            RB5.Text = "Tipo 5";
            RB5.UseVisualStyleBackColor = true;
            // 
            // BTNGerarArq
            // 
            BTNGerarArq.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BTNGerarArq.Location = new Point(138, 338);
            BTNGerarArq.Name = "BTNGerarArq";
            BTNGerarArq.Size = new Size(106, 29);
            BTNGerarArq.TabIndex = 6;
            BTNGerarArq.Text = "Gerar Arquivo";
            BTNGerarArq.UseVisualStyleBackColor = true;
            // 
            // BTNEditarDados
            // 
            BTNEditarDados.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BTNEditarDados.Location = new Point(81, 338);
            BTNEditarDados.Name = "BTNEditarDados";
            BTNEditarDados.Size = new Size(162, 29);
            BTNEditarDados.TabIndex = 7;
            BTNEditarDados.Text = "Editar Dados do Cliente";
            BTNEditarDados.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(542, 413);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(GBTpArq);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(534, 385);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(534, 385);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 426);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            GBTpArq.ResumeLayout(false);
            GBTpArq.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox CBCliente;
        private Label label1;
        private ListView LVCliente;
        private GroupBox groupBox1;
        private Button BTNEditarDados;
        private GroupBox GBTpArq;
        private RadioButton RB5;
        private Button BTNGerarArq;
        private RadioButton RB4;
        private RadioButton RB3;
        private RadioButton RB2;
        private RadioButton RB1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}