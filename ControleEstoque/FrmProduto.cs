using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControleEstoque1
{
    public partial class FrmProduto : ControleEstoque1.FrmBase
    {
        public FrmProduto()
        {
            InitializeComponent();
            BloqueiaCampos();
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            ModelProduto get = new ModelProduto();
            List<DtoProduto2> lista = get.ListProdutos();
            this.dtgridProdutos.DataSource = lista;
            this.dtgridProdutos.Refresh();
        }

        private void LimpaCampos()
        {
            txtId.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtObservacao.Text = string.Empty;
            txtPreco.Text = string.Empty;
        }

        #region Tratamento Visual
        private void LiberaCampos()
        {
            txtDescricao.Enabled = true;
            txtMarca.Enabled = true;
            txtObservacao.Enabled = true;
            txtPreco.Enabled = true;
        }
        private void BloqueiaCampos()
        {
            txtId.Enabled = false;
            txtDescricao.Enabled = false;
            txtMarca.Enabled = false;
            txtObservacao.Enabled = false;
            txtPreco.Enabled = false;
        }
        #endregion

        private void bntNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            LiberaCampos();
            txtDescricao.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModelProduto set = new ModelProduto();
                DtoProduto p = new DtoProduto();
                p.descricao = txtDescricao.Text;
                p.marca = txtMarca.Text;
                p.observacao = txtObservacao.Text;
                if (txtPreco.Text == string.Empty){
                    p.preco = 0.00;
                }else
                {
                    p.preco = Convert.ToDouble(txtPreco.Text);
                }

                if (txtId.Text != string.Empty)
                {
                    p.id = int.Parse(txtId.Text);
                    set.EditProduto(p);
                }
                else
                {
                    set.SetProduto(p);
                }

                BloqueiaCampos();
                CarregarGrid();
                LimpaCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int ID = (Int32)dtgridProdutos.CurrentRow.Cells[0].Value;

            ModelProduto get = new ModelProduto();
            DtoProduto2 p = get.GetProdutoId(ID);
            txtId.Text = p.id.ToString();
            txtDescricao.Text = p.descricao;
            txtMarca.Text = p.marca;
            txtObservacao.Text = p.observacao;
            txtPreco.Text = p.preco.ToString();
            LiberaCampos();
            txtDescricao.Focus();
        
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty)
            {
                ModelProduto del = new ModelProduto();
                del.DeletarProduto(int.Parse(txtId.Text));
                BloqueiaCampos();
                CarregarGrid();
                LimpaCampos();
            }
        }

        private void dtgridProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = (Int32)dtgridProdutos.CurrentRow.Cells[0].Value;

            ModelProduto get = new ModelProduto();
            DtoProduto2 p = get.GetProdutoId(ID);
            txtId.Text = p.id.ToString();
            txtDescricao.Text = p.descricao;
            txtMarca.Text = p.marca;
            txtObservacao.Text = p.observacao;
            txtPreco.Text = p.preco.ToString();
            LiberaCampos();
            txtDescricao.Focus();
        }
    }
}
