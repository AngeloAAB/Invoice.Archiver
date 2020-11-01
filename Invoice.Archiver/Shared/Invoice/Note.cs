using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Invoice.Archiver.Shared.Invoice
{
    [Table("Note")]
    public partial class Note
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("Note")]
        [StringLength(255)]
        public string Note1 { get; set; }
        [StringLength(10)]
        public string Type { get; set; }
        public int FkId { get; set; }
    }
}