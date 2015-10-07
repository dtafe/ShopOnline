namespace ShopOnline.Models.EVShop20
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contact")]
    public partial class Contact
    {
        public int Id { get; set; }

        [StringLength(56)]
        public string Email { get; set; }

        [StringLength(16)]
        public string Phone { get; set; }

        [StringLength(256)]
        public string Name { get; set; }

        public string Contents { get; set; }

        public string Note { get; set; }
    }
}
