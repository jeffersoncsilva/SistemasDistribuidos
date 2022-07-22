namespace Servidoes
{
    partial class Main
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
            this.lblIpServidor = new System.Windows.Forms.Label();
            this.lblPorta = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblMsgEnviada = new System.Windows.Forms.Label();
            this.LblMsgRecebida = new System.Windows.Forms.Label();
            this.LblIpConectado = new System.Windows.Forms.Label();
            this.BtnIniciaServidor = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIpServidor
            // 
            this.lblIpServidor.AutoSize = true;
            this.lblIpServidor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIpServidor.Location = new System.Drawing.Point(14, 12);
            this.lblIpServidor.Name = "lblIpServidor";
            this.lblIpServidor.Size = new System.Drawing.Size(115, 28);
            this.lblIpServidor.TabIndex = 1;
            this.lblIpServidor.Text = "IP: 127.0.0.1";
            // 
            // lblPorta
            // 
            this.lblPorta.AutoSize = true;
            this.lblPorta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPorta.Location = new System.Drawing.Point(14, 51);
            this.lblPorta.Name = "lblPorta";
            this.lblPorta.Size = new System.Drawing.Size(122, 28);
            this.lblPorta.TabIndex = 2;
            this.lblPorta.Text = "Porta: 23456";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblMsgEnviada);
            this.groupBox1.Controls.Add(this.LblMsgRecebida);
            this.groupBox1.Controls.Add(this.LblIpConectado);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(14, 83);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(578, 301);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados recebido e enviados";
            // 
            // LblMsgEnviada
            // 
            this.LblMsgEnviada.AutoSize = true;
            this.LblMsgEnviada.Location = new System.Drawing.Point(26, 200);
            this.LblMsgEnviada.Name = "LblMsgEnviada";
            this.LblMsgEnviada.Size = new System.Drawing.Size(24, 28);
            this.LblMsgEnviada.TabIndex = 2;
            this.LblMsgEnviada.Text = "...";
            // 
            // LblMsgRecebida
            // 
            this.LblMsgRecebida.AutoSize = true;
            this.LblMsgRecebida.Location = new System.Drawing.Point(26, 132);
            this.LblMsgRecebida.Name = "LblMsgRecebida";
            this.LblMsgRecebida.Size = new System.Drawing.Size(24, 28);
            this.LblMsgRecebida.TabIndex = 1;
            this.LblMsgRecebida.Text = "...";
            // 
            // LblIpConectado
            // 
            this.LblIpConectado.AutoSize = true;
            this.LblIpConectado.Location = new System.Drawing.Point(26, 63);
            this.LblIpConectado.Name = "LblIpConectado";
            this.LblIpConectado.Size = new System.Drawing.Size(24, 28);
            this.LblIpConectado.TabIndex = 0;
            this.LblIpConectado.Text = "...";
            // 
            // BtnIniciaServidor
            // 
            this.BtnIniciaServidor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnIniciaServidor.Location = new System.Drawing.Point(143, 403);
            this.BtnIniciaServidor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnIniciaServidor.Name = "BtnIniciaServidor";
            this.BtnIniciaServidor.Size = new System.Drawing.Size(272, 55);
            this.BtnIniciaServidor.TabIndex = 7;
            this.BtnIniciaServidor.Text = "Iniciar Servidor";
            this.BtnIniciaServidor.UseVisualStyleBackColor = true;
            this.BtnIniciaServidor.Click += new System.EventHandler(this.BtEscuta_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 490);
            this.Controls.Add(this.BtnIniciaServidor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPorta);
            this.Controls.Add(this.lblIpServidor);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblIpServidor;
        private Label lblPorta;
        private GroupBox groupBox1;
        private Button BtnIniciaServidor;
        private Label LblMsgEnviada;
        private Label LblMsgRecebida;
        private Label LblIpConectado;
    }
}