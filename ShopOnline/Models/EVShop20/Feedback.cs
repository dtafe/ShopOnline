namespace ShopOnline.Models.EVShop20
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Feedback")]
    public partial class Feedback
    {
        public int Id { get; set; }

        [StringLength(250)]
        public string Subject { get; set; }

        public string Comment { get; set; }

        public string Note { get; set; }
    }
}
