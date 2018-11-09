namespace Projeto_Atendimento
{
    partial class Atendimento
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
            this.buttonGerar = new System.Windows.Forms.Button();
            this.buttonChamar = new System.Windows.Forms.Button();
            this.labelGuiche = new System.Windows.Forms.Label();
            this.textGuiche = new System.Windows.Forms.TextBox();
            this.listSenhas = new System.Windows.Forms.ListBox();
            this.listAtendimentos = new System.Windows.Forms.ListBox();
            this.labelQtdGuiche = new System.Windows.Forms.Label();
            this.labelNumQtdGuiche = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonListarSenhas = new System.Windows.Forms.Button();
            this.buttonListarAtendimentos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGerar
            // 
            this.buttonGerar.AccessibleName = "buttonGerar";
            this.buttonGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGerar.Location = new System.Drawing.Point(83, 30);
            this.buttonGerar.Name = "buttonGerar";
            this.buttonGerar.Size = new System.Drawing.Size(154, 51);
            this.buttonGerar.TabIndex = 0;
            this.buttonGerar.Tag = "buttonGerar";
            this.buttonGerar.Text = "Gerar Senha";
            this.buttonGerar.UseVisualStyleBackColor = true;
            this.buttonGerar.Click += new System.EventHandler(this.buttonClickGerarSenha);
            // 
            // buttonChamar
            // 
            this.buttonChamar.AccessibleName = "buttonChamar";
            this.buttonChamar.Location = new System.Drawing.Point(602, 38);
            this.buttonChamar.Name = "buttonChamar";
            this.buttonChamar.Size = new System.Drawing.Size(90, 36);
            this.buttonChamar.TabIndex = 1;
            this.buttonChamar.Text = "Chamar";
            this.buttonChamar.UseVisualStyleBackColor = false;
            this.buttonChamar.Click += new System.EventHandler(this.clickButtonChamarSenha);
            // 
            // labelGuiche
            // 
            this.labelGuiche.AccessibleName = "labelGuiche";
            this.labelGuiche.AutoSize = true;
            this.labelGuiche.Location = new System.Drawing.Point(441, 49);
            this.labelGuiche.Name = "labelGuiche";
            this.labelGuiche.Size = new System.Drawing.Size(41, 13);
            this.labelGuiche.TabIndex = 2;
            this.labelGuiche.Tag = "labelGuiche";
            this.labelGuiche.Text = "Guiche";
            // 
            // textGuiche
            // 
            this.textGuiche.Location = new System.Drawing.Point(482, 46);
            this.textGuiche.Name = "textGuiche";
            this.textGuiche.Size = new System.Drawing.Size(100, 20);
            this.textGuiche.TabIndex = 3;
            // 
            // listSenhas
            // 
            this.listSenhas.FormattingEnabled = true;
            this.listSenhas.Location = new System.Drawing.Point(45, 95);
            this.listSenhas.Name = "listSenhas";
            this.listSenhas.Size = new System.Drawing.Size(244, 238);
            this.listSenhas.TabIndex = 4;
            // 
            // listAtendimentos
            // 
            this.listAtendimentos.FormattingEnabled = true;
            this.listAtendimentos.Location = new System.Drawing.Point(470, 95);
            this.listAtendimentos.Name = "listAtendimentos";
            this.listAtendimentos.Size = new System.Drawing.Size(291, 238);
            this.listAtendimentos.TabIndex = 5;
            // 
            // labelQtdGuiche
            // 
            this.labelQtdGuiche.AccessibleName = "labelGuiche";
            this.labelQtdGuiche.AutoSize = true;
            this.labelQtdGuiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQtdGuiche.Location = new System.Drawing.Point(314, 136);
            this.labelQtdGuiche.Name = "labelQtdGuiche";
            this.labelQtdGuiche.Size = new System.Drawing.Size(93, 18);
            this.labelQtdGuiche.TabIndex = 6;
            this.labelQtdGuiche.Text = "Qtd Guichê";
            // 
            // labelNumQtdGuiche
            // 
            this.labelNumQtdGuiche.AutoSize = true;
            this.labelNumQtdGuiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumQtdGuiche.Location = new System.Drawing.Point(346, 167);
            this.labelNumQtdGuiche.Name = "labelNumQtdGuiche";
            this.labelNumQtdGuiche.Size = new System.Drawing.Size(23, 25);
            this.labelNumQtdGuiche.TabIndex = 7;
            this.labelNumQtdGuiche.Text = "0";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(309, 207);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(109, 63);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Tag = "buttonAdd";
            this.buttonAdd.Text = "Adicionar";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.cliqueButtonAdicionarGuiche);
            // 
            // buttonListarSenhas
            // 
            this.buttonListarSenhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListarSenhas.Location = new System.Drawing.Point(83, 352);
            this.buttonListarSenhas.Name = "buttonListarSenhas";
            this.buttonListarSenhas.Size = new System.Drawing.Size(154, 53);
            this.buttonListarSenhas.TabIndex = 9;
            this.buttonListarSenhas.Text = "Listar Senhas";
            this.buttonListarSenhas.UseVisualStyleBackColor = true;
            this.buttonListarSenhas.Click += new System.EventHandler(this.clickButtonListarSenha);
            // 
            // buttonListarAtendimentos
            // 
            this.buttonListarAtendimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListarAtendimentos.Location = new System.Drawing.Point(491, 352);
            this.buttonListarAtendimentos.Name = "buttonListarAtendimentos";
            this.buttonListarAtendimentos.Size = new System.Drawing.Size(172, 53);
            this.buttonListarAtendimentos.TabIndex = 10;
            this.buttonListarAtendimentos.Text = "Listar Atendimentos";
            this.buttonListarAtendimentos.UseVisualStyleBackColor = true;
            this.buttonListarAtendimentos.Click += new System.EventHandler(this.clickButtonListarAtendimento);
            // 
            // Atendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonListarAtendimentos);
            this.Controls.Add(this.buttonListarSenhas);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelNumQtdGuiche);
            this.Controls.Add(this.labelQtdGuiche);
            this.Controls.Add(this.listAtendimentos);
            this.Controls.Add(this.listSenhas);
            this.Controls.Add(this.textGuiche);
            this.Controls.Add(this.labelGuiche);
            this.Controls.Add(this.buttonChamar);
            this.Controls.Add(this.buttonGerar);
            this.Name = "Atendimento";
            this.Text = "Atendimento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGerar;
        private System.Windows.Forms.Button buttonChamar;
        private System.Windows.Forms.Label labelGuiche;
        private System.Windows.Forms.TextBox textGuiche;
        private System.Windows.Forms.ListBox listSenhas;
        private System.Windows.Forms.ListBox listAtendimentos;
        private System.Windows.Forms.Label labelQtdGuiche;
        private System.Windows.Forms.Label labelNumQtdGuiche;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonListarSenhas;
        private System.Windows.Forms.Button buttonListarAtendimentos;
    }
}

