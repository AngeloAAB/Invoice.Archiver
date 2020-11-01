using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Invoice.Archiver.Shared.Invoice
{
    public partial class Product
    {
        public Product()
        {
            Lines = new HashSet<Line>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column(TypeName = "VARCHAR(13)")]
        [StringLength(13)]
        public string Barcode { get; set; }
        [StringLength(30)]
        public string Brand { get; set; }
        [Required]
        [StringLength(50)]
        public string Description { get; set; }
        [Required]
        [StringLength(20)]
        public string Size { get; set; }
        public string ImageUrl { get; set; }

        [InverseProperty(nameof(Line.FkProduct))]
        public virtual ICollection<Line> Lines { get; set; }
    }
}