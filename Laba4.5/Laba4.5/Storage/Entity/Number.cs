using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Laba4._5.Storage.Entity
{
    [Table("tblNumber")]
    public class Number : IUniqueId
    {
        [Key]
        [Required]
        [Column("gId")]
        public Guid Id { get; set; }

        [Required]
        [Column("iFloor")]
        public int floor { get; set; }

        [Required]
        [Column("iNomer")]
        public int nomer { get; set; }

        [Required]
        [Column("gCHNumberId")]
        public Guid CHNumberId { get; set; }

        [ForeignKey(nameof(CHNumberId))]
        public CHnumber CHnumber { get; set; }


    }
}
 