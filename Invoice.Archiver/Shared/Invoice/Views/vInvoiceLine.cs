using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Invoice.Archiver.Shared.Invoice.Views
{
    public class vInvoiceLine
    {
        public int lineNo { get; set; }
        [StringLength(25)]
        public string VendorCode { get; set; }
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
        public int Qty { get; set; }
        public int Pack { get; set; }
        [Column(TypeName = "money")]
        public decimal PriceCase { get; set; }
        [Column(TypeName = "money")]
        public decimal? DiscountAmount { get; set; }
        [Column(TypeName = "money")]
        public decimal TotalAmount { get; set; }
        [StringLength(100)]
        public string OutReason { get; set; }
    }
}
