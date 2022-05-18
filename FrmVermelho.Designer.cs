namespace teste_michele
{
    partial class FrmVermelho
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.exibir = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFrmamarelo = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFrmazul = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFrmvermelho = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.txt_nascimento = new System.Windows.Forms.TextBox();
            this.txt_cep = new System.Windows.Forms.TextBox();
            this.txt_rua = new System.Windows.Forms.TextBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.txt_complemento = new System.Windows.Forms.TextBox();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.txt_pais = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibir});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 3;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data de Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = " CEP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rua/AV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Número";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Complemento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Bairro";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = " Cidade";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Estado";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(55, 341);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "País";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(157, 85);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 15;
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(157, 111);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(100, 20);
            this.txt_cpf.TabIndex = 16;
            // 
            // txt_nascimento
            // 
            this.txt_nascimento.Location = new System.Drawing.Point(157, 136);
            this.txt_nascimento.Name = "txt_nascimento";
            this.txt_nascimento.Size = new System.Drawing.Size(100, 20);
            this.txt_nascimento.TabIndex = 17;
            // 
            // txt_cep
            // 
            this.txt_cep.Location = new System.Drawing.Point(157, 161);
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(100, 20);
            this.txt_cep.TabIndex = 18;
            // 
            // txt_rua
            // 
            this.txt_rua.Location = new System.Drawing.Point(157, 187);
            this.txt_rua.Name = "txt_rua";
            this.txt_rua.Size = new System.Drawing.Size(100, 20);
            this.txt_rua.TabIndex = 19;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(157, 213);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(100, 20);
            this.txt_numero.TabIndex = 20;
            // 
            // txt_complemento
            // 
            this.txt_complemento.Location = new System.Drawing.Point(157, 242);
            this.txt_complemento.Name = "txt_complemento";
            this.txt_complemento.Size = new System.Drawing.Size(100, 20);
            this.txt_complemento.TabIndex = 21;
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(157, 268);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(100, 20);
            this.txt_bairro.TabIndex = 22;
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(157, 294);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(100, 20);
            this.txt_cidade.TabIndex = 23;
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(157, 320);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(100, 20);
            this.txt_estado.TabIndex = 24;
            // 
            // txt_pais
            // 
            this.txt_pais.Location = new System.Drawing.Point(157, 346);
            this.txt_pais.Name = "txt_pais";
            this.txt_pais.Size = new System.Drawing.Size(100, 20);
            this.txt_pais.TabIndex = 25;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 51;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 50;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmVermelho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_pais);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.txt_complemento);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.txt_rua);
            this.Controls.Add(this.txt_cep);
            this.Controls.Add(this.txt_nascimento);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "FrmVermelho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Número";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem exibir;
        private System.Windows.Forms.ToolStripMenuItem exibirFrmamarelo;
        private System.Windows.Forms.ToolStripMenuItem exibirFrmazul;
        private System.Windows.Forms.ToolStripMenuItem exibirFrmvermelho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.TextBox txt_nascimento;
        private System.Windows.Forms.TextBox txt_cep;
        private System.Windows.Forms.TextBox txt_rua;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TextBox txt_complemento;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.TextBox txt_pais;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}