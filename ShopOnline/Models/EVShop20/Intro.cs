namespace ShopOnline.Models.EVShop20
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Intro")]
    public partial class Intro
    {
        public int Id { get; set; }

        [StringLength(500)]
        public string Subject { get; set; }

        public string Contents { get; set; }

        [StringLength(250)]
        public string Image { get; set; }

        public string Note { get; set; }
    }
}
