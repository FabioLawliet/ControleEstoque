namespace ControleEstoque1
{
    partial class FrmProduto
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
            this.lbId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lbMarca = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lbObservacao = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lbPreco = new System.Windows.Forms.Label();
            this.dtgridProdutos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // bntNovo
            // 
            this.bntNovo.FlatAppearance.BorderSize = 0;
            this.bntNovo.Click += new System.EventHandler(this.bntNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(12, 123);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(16, 13);
            this.lbId.TabIndex = 2;
            this.lbId.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(15, 139);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 3;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(121, 139);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(398, 20);
            this.txtDescricao.TabIndex = 5;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(118, 123);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(55, 13);
            this.lbDescricao.TabIndex = 4;
            this.lbDescricao.Text = "Descrição";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(525, 139);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(263, 20);
            this.txtMarca.TabIndex = 7;
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Location = new System.Drawing.Point(522, 123);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(37, 13);
            this.lbMarca.TabIndex = 6;
            this.lbMarca.Text = "Marca";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(15, 188);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(504, 20);
            this.txtObservacao.TabIndex = 9;
            // 
            // lbObservacao
            // 
            this.lbObservacao.AutoSize = true;
            this.lbObservacao.Location = new System.Drawing.Point(12, 172);
            this.lbObservacao.Name = "lbObservacao";
            this.lbObservacao.Size = new System.Drawing.Size(65, 13);
            this.lbObservacao.TabIndex = 8;
            this.lbObservacao.Text = "Observação";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(525, 188);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(263, 20);
            this.txtPreco.TabIndex = 11;
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.Location = new System.Drawing.Point(522, 172);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(35, 13);
            this.lbPreco.TabIndex = 10;
            this.lbPreco.Text = "Preço";
            // 
            // dtgridProdutos
            // 
            this.dtgridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridProdutos.Location = new System.Drawing.Point(15, 224);
            this.dtgridProdutos.Name = "dtgridProdutos";
            this.dtgridProdutos.Size = new System.Drawing.Size(773, 214);
            this.dtgridProdutos.TabIndex = 12;
            this.dtgridProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridProdutos_CellDoubleClick);
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgridProdutos);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.lbPreco);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.lbObservacao);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lbDescricao);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lbId);
            this.Name = "FrmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Produto";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.lbId, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.lbDescricao, 0);
            this.Controls.SetChildIndex(this.txtDescricao, 0);
            this.Controls.SetChildIndex(this.lbMarca, 0);
            this.Controls.SetChildIndex(this.txtMarca, 0);
            this.Controls.SetChildIndex(this.lbObservacao, 0);
            this.Controls.SetChildIndex(this.txtObservacao, 0);
            this.Controls.SetChildIndex(this.lbPreco, 0);
            this.Controls.SetChildIndex(this.txtPreco, 0);
            this.Controls.SetChildIndex(this.dtgridProdutos, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbObservacao;
        private System.Windows.Forms.Label lbPreco;
        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.TextBox txtDescricao;
        public System.Windows.Forms.TextBox txtMarca;
        public System.Windows.Forms.TextBox txtObservacao;
        public System.Windows.Forms.TextBox txtPreco;
        public System.Windows.Forms.DataGridView dtgridProdutos;
    }
}
