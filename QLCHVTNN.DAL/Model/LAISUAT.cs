namespace QLCHVTNN.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LAISUAT")]
    public partial class LAISUAT
    {
        [Key]
        [StringLength(10)]
        public string MaLai { get; set; }

        public decimal TyLeLai { get; set; }

        [StringLength(200)]
        public string GhiChu { get; set; }
    }
}
