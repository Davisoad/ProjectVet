namespace ProjetoFinal
{
    partial class Form1
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
            this.btn_Cachorro = new System.Windows.Forms.Button();
            this.btn_Gato = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCaracteristica = new System.Windows.Forms.Label();
            this.btn_AddC = new System.Windows.Forms.Button();
            this.btn_AddG = new System.Windows.Forms.Button();
            this.btn_Pesquisa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtCaracteristica = new System.Windows.Forms.TextBox();
            this.txtPesquisaNome = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Cachorro
            // 
            this.btn_Cachorro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cachorro.Location = new System.Drawing.Point(36, 68);
            this.btn_Cachorro.Name = "btn_Cachorro";
            this.btn_Cachorro.Size = new System.Drawing.Size(109, 45);
            this.btn_Cachorro.TabIndex = 0;
            this.btn_Cachorro.Text = "Cachorro";
            this.btn_Cachorro.UseVisualStyleBackColor = true;
            this.btn_Cachorro.Click += new System.EventHandler(this.btn_Cachorro_Click);
            // 
            // btn_Gato
            // 
            this.btn_Gato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Gato.Location = new System.Drawing.Point(174, 67);
            this.btn_Gato.Name = "btn_Gato";
            this.btn_Gato.Size = new System.Drawing.Size(89, 46);
            this.btn_Gato.TabIndex = 1;
            this.btn_Gato.Text = "Gato";
            this.btn_Gato.UseVisualStyleBackColor = true;
            this.btn_Gato.Click += new System.EventHandler(this.btn_Gato_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Raça";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Preço";
            // 
            // lblCaracteristica
            // 
            this.lblCaracteristica.AutoSize = true;
            this.lblCaracteristica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaracteristica.Location = new System.Drawing.Point(39, 251);
            this.lblCaracteristica.Name = "lblCaracteristica";
            this.lblCaracteristica.Size = new System.Drawing.Size(106, 20);
            this.lblCaracteristica.TabIndex = 5;
            this.lblCaracteristica.Text = "Característica";
            // 
            // btn_AddC
            // 
            this.btn_AddC.Enabled = false;
            this.btn_AddC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddC.Location = new System.Drawing.Point(36, 295);
            this.btn_AddC.Name = "btn_AddC";
            this.btn_AddC.Size = new System.Drawing.Size(240, 43);
            this.btn_AddC.TabIndex = 6;
            this.btn_AddC.Text = "Adicionar Cachorro na Lista";
            this.btn_AddC.UseVisualStyleBackColor = true;
            this.btn_AddC.Click += new System.EventHandler(this.btn_AddC_Click);
            // 
            // btn_AddG
            // 
            this.btn_AddG.Enabled = false;
            this.btn_AddG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddG.Location = new System.Drawing.Point(36, 344);
            this.btn_AddG.Name = "btn_AddG";
            this.btn_AddG.Size = new System.Drawing.Size(240, 37);
            this.btn_AddG.TabIndex = 7;
            this.btn_AddG.Text = "Adicionar Gato na Lista";
            this.btn_AddG.UseVisualStyleBackColor = true;
            this.btn_AddG.Click += new System.EventHandler(this.btn_AddG_Click);
            // 
            // btn_Pesquisa
            // 
            this.btn_Pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pesquisa.Location = new System.Drawing.Point(37, 23);
            this.btn_Pesquisa.Name = "btn_Pesquisa";
            this.btn_Pesquisa.Size = new System.Drawing.Size(162, 46);
            this.btn_Pesquisa.TabIndex = 8;
            this.btn_Pesquisa.Text = "Pesquisar por Nome";
            this.btn_Pesquisa.UseVisualStyleBackColor = true;
            this.btn_Pesquisa.Click += new System.EventHandler(this.btn_Pesquisa_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(205, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(105, 141);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 26);
            this.txtNome.TabIndex = 10;
            // 
            // txtRaca
            // 
            this.txtRaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaca.Location = new System.Drawing.Point(105, 176);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.Size = new System.Drawing.Size(100, 26);
            this.txtRaca.TabIndex = 11;
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(105, 213);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 26);
            this.txtPreco.TabIndex = 12;
            // 
            // txtCaracteristica
            // 
            this.txtCaracteristica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaracteristica.Location = new System.Drawing.Point(151, 245);
            this.txtCaracteristica.Name = "txtCaracteristica";
            this.txtCaracteristica.Size = new System.Drawing.Size(100, 26);
            this.txtCaracteristica.TabIndex = 13;
            // 
            // txtPesquisaNome
            // 
            this.txtPesquisaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaNome.Location = new System.Drawing.Point(205, 46);
            this.txtPesquisaNome.Name = "txtPesquisaNome";
            this.txtPesquisaNome.Size = new System.Drawing.Size(100, 26);
            this.txtPesquisaNome.TabIndex = 14;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisa.Location = new System.Drawing.Point(37, 97);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(173, 20);
            this.lblPesquisa.TabIndex = 15;
            this.lblPesquisa.Text = "Resultado da Pesquisa";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_Pesquisa);
            this.panel1.Controls.Add(this.lblPesquisa);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtPesquisaNome);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(388, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 226);
            this.panel1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCaracteristica);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtRaca);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btn_AddG);
            this.Controls.Add(this.btn_AddC);
            this.Controls.Add(this.lblCaracteristica);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Gato);
            this.Controls.Add(this.btn_Cachorro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cachorro;
        private System.Windows.Forms.Button btn_Gato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCaracteristica;
        private System.Windows.Forms.Button btn_AddC;
        private System.Windows.Forms.Button btn_AddG;
        private System.Windows.Forms.Button btn_Pesquisa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRaca;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtCaracteristica;
        private System.Windows.Forms.TextBox txtPesquisaNome;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.Panel panel1;
    }
}

