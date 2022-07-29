namespace Trarefa_Um.FormsClientes
{
    partial class FrmQuestao9
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
            this.BtnPegarCarta = new System.Windows.Forms.Button();
            this.LstCartas = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // BtnPegarCarta
            // 
            this.BtnPegarCarta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnPegarCarta.Location = new System.Drawing.Point(135, 343);
            this.BtnPegarCarta.Name = "BtnPegarCarta";
            this.BtnPegarCarta.Size = new System.Drawing.Size(270, 77);
            this.BtnPegarCarta.TabIndex = 0;
            this.BtnPegarCarta.Text = "Pegar carta do servidor";
            this.BtnPegarCarta.UseVisualStyleBackColor = true;
            this.BtnPegarCarta.Click += new System.EventHandler(this.BtnPegarCarta_Click);
            // 
            // LstCartas
            // 
            this.LstCartas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1});
            this.LstCartas.FullRowSelect = true;
            this.LstCartas.Location = new System.Drawing.Point(12, 12);
            this.LstCartas.Name = "LstCartas";
            this.LstCartas.Size = new System.Drawing.Size(539, 306);
            this.LstCartas.TabIndex = 1;
            this.LstCartas.UseCompatibleStateImageBehavior = false;
            this.LstCartas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "IDCarta";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Carta";
            this.columnHeader1.Width = 450;
            // 
            // FrmQuestao9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 435);
            this.Controls.Add(this.LstCartas);
            this.Controls.Add(this.BtnPegarCarta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmQuestao9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmQuestao9";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnPegarCarta;
        private ListView LstCartas;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}