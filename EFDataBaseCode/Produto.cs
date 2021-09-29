namespace EFDataBaseCode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Produto")]
    public partial class Produto
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Nome { get; set; }

        public double? Valor { get; set; }

        public virtual PedidoProduto PedidoProduto { get; set; }
    }
}
