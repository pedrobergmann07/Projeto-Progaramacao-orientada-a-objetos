namespace teste_michele
{
    partial class FrmAzul
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.exibir = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFrmamarelo = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFrmazul = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFrmvermelho = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_valord = new System.Windows.Forms.TextBox();
            this.txt_v_compra = new System.Windows.Forms.TextBox();
            this.txt_calorias = new System.Windows.Forms.TextBox();
            this.txt_ingredientes = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibir});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // exibir
            // 
            this.exibir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirFrmamarelo,
            this.exibirFrmazul,
            this.exibirFrmvermelho});
            this.exibir.Name = "exibir";
            this.exibir.Size = new System.Drawing.Size(47, 20);
            this.exibir.Text = "Exibir";
            // 
            // exibirFrmamarelo
            // 
            this.exibirFrmamarelo.Name = "exibirFrmamarelo";
            this.exibirFrmamarelo.Size = new System.Drawing.Size(180, 22);
            this.exibirFrmamarelo.Text = "FrmLoja";
            this.exibirFrmamarelo.Click += new System.EventHandler(this.exibirFrmamarelo_Click);
            // 
            // exibirFrmazul
            // 
            this.exibirFrmazul.Name = "exibirFrmazul";
            this.exibirFrmazul.Size = new System.Drawing.Size(180, 22);
            this.exibirFrmazul.Text = "FrmAlimento";
            this.exibirFrmazul.Click += new System.EventHandler(this.exibirFrmazul_Click);
            // 
            // exibirFrmvermelho
            // 
            this.exibirFrmvermelho.Name = "exibirFrmvermelho";
            this.exibirFrmvermelho.Size = new System.Drawing.Size(180, 22);
            this.exibirFrmvermelho.Text = "FrmPrefeito";
            this.exibirFrmvermelho.Click += new System.EventHandler(this.exibirFrmvermelho_Click);
            // 
            // txt_valord
            // 
            this.txt_valord.Location = new System.Drawing.Point(405, 188);
            this.txt_valord.Name = "txt_valord";
            this.txt_valord.Size = new System.Drawing.Size(100, 20);
            this.txt_valord.TabIndex = 41;
            // 
            // txt_v_compra
            // 
            this.txt_v_compra.Location = new System.Drawing.Point(405, 162);
            this.txt_v_compra.Name = "txt_v_compra";
            this.txt_v_compra.Size = new System.Drawing.Size(100, 20);
            this.txt_v_compra.TabIndex = 40;
            // 
            // txt_calorias
            // 
            this.txt_calorias.Location = new System.Drawing.Point(405, 137);
            this.txt_calorias.Name = "txt_calorias";
            this.txt_calorias.Size = new System.Drawing.Size(100, 20);
            this.txt_calorias.TabIndex = 39;
            // 
            // txt_ingredientes
            // 
            this.txt_ingredientes.Location = new System.Drawing.Point(405, 112);
            this.txt_ingredientes.Name = "txt_ingredientes";
            this.txt_ingredientes.Size = new System.Drawing.Size(100, 20);
            this.txt_ingredientes.TabIndex = 38;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(405, 86);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(258, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "valor com 10% de aumento. ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(296, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "valor de compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(296, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "calorias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(296, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "ingredientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(296, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nome:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(403, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 51;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 50;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmAzul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_valord);
            this.Controls.Add(this.txt_v_compra);
            this.Controls.Add(this.txt_calorias);
            this.Controls.Add(this.txt_ingredientes);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "FrmAzul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem exibir;
        private System.Windows.Forms.ToolStripMenuItem exibirFrmamarelo;
        private System.Windows.Forms.ToolStripMenuItem exibirFrmazul;
        private System.Windows.Forms.ToolStripMenuItem exibirFrmvermelho;
        private System.Windows.Forms.TextBox txt_valord;
        private System.Windows.Forms.TextBox txt_v_compra;
        private System.Windows.Forms.TextBox txt_calorias;
        private System.Windows.Forms.TextBox txt_ingredientes;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}