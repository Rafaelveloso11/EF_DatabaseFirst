namespace EFDataBaseCode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PedidoProduto")]
    public partial class PedidoProduto
    {
        public int Id { get; set; }

        public int? PedidoId { get; set; }

        public int? ProdutoId { get; set; }

        public double? Valor { get; set; }

        public virtual Pedido Pedido { get; set; }

        public virtual Produto Produto { get; set; }
    }
}
