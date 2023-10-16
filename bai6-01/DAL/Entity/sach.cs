namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sach")]
    public partial class sach
    {
        [Key]
        public int masach { get; set; }

        [Required]
        [StringLength(150)]
        public string tensach { get; set; }

        public int namxb { get; set; }

        public int maloai { get; set; }

        public virtual loaisach loaisach { get; set; }
    }
}
