using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ControleEstoque1
{
    public class ModelProduto
    {
        public void SetProduto(DtoProduto p)
        {
            Context db = new Context();

            db.produto.Add(p);
            db.SaveChanges();
        }

        public void EditProduto(DtoProduto p)
        {
            Context db = new Context();
            DtoProduto prod = db.produto.FirstOrDefault(pro => pro.id == p.id);
            prod.descricao = p.descricao;
            prod.marca = p.marca;
            prod.observacao = p.observacao;
            prod.preco = p.preco;

            db.SaveChanges();
        }

        public List<DtoProduto2> ListProdutos()
        {
            Context db = new Context();
            List<DtoProduto2> result = (from p in db.produto
                                        select new DtoProduto2
                                        {
                                            id = p.id,
                                            descricao = p.descricao,
                                            marca = p.marca,
                                            observacao = p.observacao,
                                            preco = p.preco
                                        }).ToList();

            return new List<DtoProduto2>(result);


        }

        public DtoProduto2 GetProdutoId(int id)
        {
            Context db = new Context();
            var result = (from p in db.produto
                          where p.id == id
                          select new DtoProduto2
                          {
                              id = p.id,
                              descricao = p.descricao,
                              marca = p.marca,
                              observacao = p.observacao,
                              preco = p.preco
                          }).FirstOrDefault();

            var result1 = db.produto.Where(p => p.id == id).FirstOrDefault();

            return result;
        }

        public void DeletarProduto(int id)
        {
            Context db = new Context();
            DtoProduto prod = db.produto.FirstOrDefault(p => p.id == id);
            try
            {
                db.produto.Remove(prod);
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                db.SaveChanges();
            }
           
        }
    }
}
