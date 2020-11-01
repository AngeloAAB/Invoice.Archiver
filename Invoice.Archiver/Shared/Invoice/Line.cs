using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Invoice.Archiver.Shared.Invoice
{
    public partial class Line
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(25)]
        public string VendorCode { get; set; }
        [Column(TypeName = "VARCHAR(13)")]
        public string Barcode { get; set; }
        public int Qty { get; set; }
        public int Pack { get; set; }
        [Column(TypeName = "money")]
        public decimal PriceCase { get; set; }
        [Column(TypeName = "money")]
        public decimal? DiscountAmount { get; set; }
        [Column(TypeName = "money")]
        public decimal TotalAmount { get; set; }
        public double? TotalCube { get; set; }
        [StringLength(10)]
        public string CubeFormat { get; set; }
        public double? TotalWeight { get; set; }
        [StringLength(10)]
        public string WeightFormat { get; set; }
        [StringLength(100)]
        public string OutReason { get; set; }
        public int VendorLineId { get; set; }
        [Column("fkInvoiceID")]
        public int FkInvoiceId { get; set; }
        [Column("fkProductID")]
        public int FkProductId { get; set; }

        [ForeignKey(nameof(FkInvoiceId))]
        [InverseProperty(nameof(Invoice.Lines))]
        public virtual Invoice FkInvoice { get; set; }
        [ForeignKey(nameof(FkProductId))]
        [InverseProperty(nameof(Product.Lines))]
        public virtual Product FkProduct { get; set; }
    }
}