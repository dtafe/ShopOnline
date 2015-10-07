namespace ShopOnline.Models.EVShop20
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Permission
    {
        public int Id { get; set; }

        public int WebActionId { get; set; }

        [StringLength(128)]
        public string RoleId { get; set; }

        public bool Allowable { get; set; }
    }
}
