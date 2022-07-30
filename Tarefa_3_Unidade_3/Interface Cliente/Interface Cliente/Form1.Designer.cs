namespace Interface_Cliente
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
            this.BtnConectaServidor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxbIpServidor = new System.Windows.Forms.TextBox();
            this.TxbPortaServidor = new System.Windows.Forms.TextBox();
            this.GpbQuestoes = new System.Windows.Forms.GroupBox();
            this.BtnQuestao9 = new System.Windows.Forms.Button();
            this.BtnQuestao8 = new System.Windows.Forms.Button();
            this.BtnQuestao6 = new System.Windows.Forms.Button();
            this.BtnQuestao5 = new System.Windows.Forms.Button();
            this.BtnQuestao4 = new System.Windows.Forms.Button();
            this.BtnQuestao7 = new System.Windows.Forms.Button();
            this.BtnQuestao3 = new System.Windows.Forms.Button();
            this.BtnQuestao2 = new System.Windows.Forms.Button();
            this.BtnQuestao1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblResult = new System.Windows.Forms.Label();
            this.GpbQuestoes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnConectaServidor
            // 
            this.BtnConectaServidor.Location = new System.Drawing.Point(275, 7);
            this.BtnConectaServidor.Name = "BtnConectaServidor";
            this.BtnConectaServidor.Size = new System.Drawing.Size(166, 84);
            this.BtnConectaServidor.TabIndex = 0;
            this.BtnConectaServidor.Text = "Conectar Servidor Negocios";
            this.BtnConectaServidor.UseVisualStyleBackColor = true;
            this.BtnConectaServidor.Click += new System.EventHandler(this.BtnConectaServidor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Servidor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Porta Servidor:";
            // 
            // TxbIpServidor
            // 
            this.TxbIpServidor.Location = new System.Drawing.Point(123, 12);
            this.TxbIpServidor.Name = "TxbIpServidor";
            this.TxbIpServidor.Size = new System.Drawing.Size(124, 27);
            this.TxbIpServidor.TabIndex = 3;
            this.TxbIpServidor.Text = "127.0.0.1";
            // 
            // TxbPortaServidor
            // 
            this.TxbPortaServidor.Location = new System.Drawing.Point(123, 59);
            this.TxbPortaServidor.Name = "TxbPortaServidor";
            this.TxbPortaServidor.Size = new System.Drawing.Size(124, 27);
            this.TxbPortaServidor.TabIndex = 4;
            this.TxbPortaServidor.Text = "12345";
            // 
            // GpbQuestoes
            // 
            this.GpbQuestoes.Controls.Add(this.BtnQuestao9);
            this.GpbQuestoes.Controls.Add(this.BtnQuestao8);
            this.GpbQuestoes.Controls.Add(this.BtnQuestao6);
            this.GpbQuestoes.Controls.Add(this.BtnQuestao5);
            this.GpbQuestoes.Controls.Add(this.BtnQuestao4);
            this.GpbQuestoes.Controls.Add(this.BtnQuestao7);
            this.GpbQuestoes.Controls.Add(this.BtnQuestao3);
            this.GpbQuestoes.Controls.Add(this.BtnQuestao2);
            this.GpbQuestoes.Controls.Add(this.BtnQuestao1);
            this.GpbQuestoes.Enabled = false;
            this.GpbQuestoes.Location = new System.Drawing.Point(12, 111);
            this.GpbQuestoes.Name = "GpbQuestoes";
            this.GpbQuestoes.Size = new System.Drawing.Size(292, 302);
            this.GpbQuestoes.TabIndex = 5;
            this.GpbQuestoes.TabStop = false;
            this.GpbQuestoes.Text = "Questoes";
            // 
            // BtnQuestao9
            // 
            this.BtnQuestao9.Location = new System.Drawing.Point(22, 242);
            this.BtnQuestao9.Name = "BtnQuestao9";
            this.BtnQuestao9.Size = new System.Drawing.Size(117, 45);
            this.BtnQuestao9.TabIndex = 8;
            this.BtnQuestao9.Text = "Questão 9";
            this.BtnQuestao9.UseVisualStyleBackColor = true;
            this.BtnQuestao9.Click += new System.EventHandler(this.BtnQuestao_Click);
            // 
            // BtnQuestao8
            // 
            this.BtnQuestao8.Location = new System.Drawing.Point(156, 191);
            this.BtnQuestao8.Name = "BtnQuestao8";
            this.BtnQuestao8.Size = new System.Drawing.Size(117, 45);
            this.BtnQuestao8.TabIndex = 7;
            this.BtnQuestao8.Text = "Questão 8";
            this.BtnQuestao8.UseVisualStyleBackColor = true;
            this.BtnQuestao8.Click += new System.EventHandler(this.BtnQuestao_Click);
            // 
            // BtnQuestao6
            // 
            this.BtnQuestao6.Location = new System.Drawing.Point(156, 140);
            this.BtnQuestao6.Name = "BtnQuestao6";
            this.BtnQuestao6.Size = new System.Drawing.Size(117, 45);
            this.BtnQuestao6.TabIndex = 6;
            this.BtnQuestao6.Text = "Questão 6";
            this.BtnQuestao6.UseVisualStyleBackColor = true;
            this.BtnQuestao6.Click += new System.EventHandler(this.BtnQuestao_Click);
            // 
            // BtnQuestao5
            // 
            this.BtnQuestao5.Location = new System.Drawing.Point(22, 140);
            this.BtnQuestao5.Name = "BtnQuestao5";
            this.BtnQuestao5.Size = new System.Drawing.Size(117, 45);
            this.BtnQuestao5.TabIndex = 5;
            this.BtnQuestao5.Text = "Questão 5";
            this.BtnQuestao5.UseVisualStyleBackColor = true;
            this.BtnQuestao5.Click += new System.EventHandler(this.BtnQuestao_Click);
            // 
            // BtnQuestao4
            // 
            this.BtnQuestao4.Location = new System.Drawing.Point(156, 89);
            this.BtnQuestao4.Name = "BtnQuestao4";
            this.BtnQuestao4.Size = new System.Drawing.Size(117, 45);
            this.BtnQuestao4.TabIndex = 4;
            this.BtnQuestao4.Text = "Questão 4";
            this.BtnQuestao4.UseVisualStyleBackColor = true;
            this.BtnQuestao4.Click += new System.EventHandler(this.BtnQuestao_Click);
            // 
            // BtnQuestao7
            // 
            this.BtnQuestao7.Location = new System.Drawing.Point(22, 191);
            this.BtnQuestao7.Name = "BtnQuestao7";
            this.BtnQuestao7.Size = new System.Drawing.Size(117, 45);
            this.BtnQuestao7.TabIndex = 3;
            this.BtnQuestao7.Text = "Questão 7";
            this.BtnQuestao7.UseVisualStyleBackColor = true;
            this.BtnQuestao7.Click += new System.EventHandler(this.BtnQuestao_Click);
            // 
            // BtnQuestao3
            // 
            this.BtnQuestao3.Location = new System.Drawing.Point(22, 89);
            this.BtnQuestao3.Name = "BtnQuestao3";
            this.BtnQuestao3.Size = new System.Drawing.Size(117, 45);
            this.BtnQuestao3.TabIndex = 2;
            this.BtnQuestao3.Text = "Questão 3";
            this.BtnQuestao3.UseVisualStyleBackColor = true;
            this.BtnQuestao3.Click += new System.EventHandler(this.BtnQuestao_Click);
            // 
            // BtnQuestao2
            // 
            this.BtnQuestao2.Location = new System.Drawing.Point(156, 38);
            this.BtnQuestao2.Name = "BtnQuestao2";
            this.BtnQuestao2.Size = new System.Drawing.Size(117, 45);
            this.BtnQuestao2.TabIndex = 1;
            this.BtnQuestao2.Text = "Questão 2";
            this.BtnQuestao2.UseVisualStyleBackColor = true;
            this.BtnQuestao2.Click += new System.EventHandler(this.BtnQuestao_Click);
            // 
            // BtnQuestao1
            // 
            this.BtnQuestao1.Location = new System.Drawing.Point(22, 38);
            this.BtnQuestao1.Name = "BtnQuestao1";
            this.BtnQuestao1.Size = new System.Drawing.Size(117, 45);
            this.BtnQuestao1.TabIndex = 0;
            this.BtnQuestao1.Text = "Questão 1";
            this.BtnQuestao1.UseVisualStyleBackColor = true;
            this.BtnQuestao1.Click += new System.EventHandler(this.BtnQuestao_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblResult);
            this.groupBox1.Location = new System.Drawing.Point(319, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 293);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado Servidor Negocio:";
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(6, 29);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(50, 20);
            this.LblResult.TabIndex = 0;
            this.LblResult.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 429);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GpbQuestoes);
            this.Controls.Add(this.TxbPortaServidor);
            this.Controls.Add(this.TxbIpServidor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnConectaServidor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interface cliente";
            this.GpbQuestoes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnConectaServidor;
        private Label label1;
        private Label label2;
        private TextBox TxbIpServidor;
        private TextBox TxbPortaServidor;
        private GroupBox GpbQuestoes;
        private Button BtnQuestao1;
        private Button BtnQuestao3;
        private Button BtnQuestao2;
        private Button BtnQuestao9;
        private Button BtnQuestao8;
        private Button BtnQuestao6;
        private Button BtnQuestao5;
        private Button BtnQuestao4;
        private Button BtnQuestao7;
        private GroupBox groupBox1;
        private Label LblResult;
    }
}