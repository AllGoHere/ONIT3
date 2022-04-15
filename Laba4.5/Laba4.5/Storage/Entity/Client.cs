using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Laba4._5.Storage.Entity
{
[Table("tblClient")]
    public class Client : IUniqueId
    {
        [Key]
        [Required]
        [Column("gId")]
        public Guid Id { get; set; } 

        [Required]
        [Column("szName")]
        [MaxLength(50)]
        public string name { get; set; }

        [Required]
        [Column("szLname")]
        [MaxLength(50)]
        public string lastname { get; set; }  

        [Required]
        [Column("iNights")]
        public int nights { get; set; }

        [Required]
        [Column("iNumber")]
        public int number { get; set; }
         
        [Required]
        [Column("gNumberId")]
        public Guid NumberId { get; set; }

        [ForeignKey(nameof(NumberId))]
        public Number Number { get; set; }
    }
}
