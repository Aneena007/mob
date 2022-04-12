using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Domain.Order
{
    public class OrderStatus
    {
        [Key]
        [Column("id", Order = 0)]
        [Required]
        public int Id { get; set; }

        [Column("order_id", Order = 1)]
        [Required]
        public int OrderId { get; set; }
        public virtual CatalogOrder CatalogOrder { get; set; }

        [Column("order_status", Order = 2)]
        [Required]
        public Status Status { get; set; }

        [Column("created_at", Order = 3)]
        public DateTime CreatedAt { get; set; }

        [Column("modified_at", Order = 4)]
        public DateTime ModifiedAt { get; set; }

        [Column("created_by", Order = 5)]
        public string CreatedBy { get; set; }

        [Column("modified_by", Order = 6)]
        public string ModifiedBy { get; set; }
    }
}
