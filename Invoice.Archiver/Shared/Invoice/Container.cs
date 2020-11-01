using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Invoice.Archiver.Shared.Invoice
{
    public partial class Container
    {
        [Key]
        public int Id { get; set; }
        public DateTime? Etd { get; set; }
        public DateTime? Eta { get; set; }
        [Required]
        [StringLength(50)]
        public string ContainerNo { get; set; }
        [StringLength(100)]
        public string ShipName { get; set; }
        [StringLength(50)]
        public string SealNo { get; set; }
    }
}