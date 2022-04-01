using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ControleEstoque1
{
    public class DtoProduto2
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public string marca { get; set; }
        public string observacao { get; set; }
        public double preco { get; set; }

    }
}
