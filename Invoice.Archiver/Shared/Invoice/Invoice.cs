using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Invoice.Archiver.Shared.Invoice
{
    public partial class Invoice
    {
        public Invoice()
        {
            Lines = new HashSet<Line>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("VendorID")]
        [StringLength(25)]
        public string VendorId { get; set; }
        [Required]
        [StringLength(50)]
        public string InvoiceNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime InvoiceDate { get; set; }
        [StringLength(50)]
        public string Status { get; set; }
        [StringLength(50)]
        public string Type { get; set; }
        public double? TotalCases { get; set; }
        public double? NumberItems { get; set; }
        public double? TotalAmount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateCreate { get; set; }
        public int? FkContainerId { get; set; }

        [InverseProperty(nameof(Line.FkInvoice))]
        public virtual ICollection<Line> Lines { get; set; }
    }
}