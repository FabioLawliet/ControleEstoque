using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ControleEstoque1
{
    [Table("produto", Schema = "public")]
    public class DtoProduto
    {
        [Key]
        public int id { get; set; }
        public string descricao { get; set; }
        public string marca { get; set; }
        public string observacao { get; set; }
        public double preco { get; set; }
    }
}
