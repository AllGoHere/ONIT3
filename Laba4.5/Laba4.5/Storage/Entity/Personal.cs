using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Laba4._5.Storage.Entity

{
    [Table("tblPersonal")]
    public class Personal : IUniqueId
    {
        [Key]
        [Required]
        [Column("gId")]
        public Guid Id { get; set; }

        [Required]
        [Column("szName")]
        public string name { get; set; }

        [Required]
        [Column("szLName")]
        public string lastname { get; set; }

        [Required]
        [Column("szDolzhnost")]
        public string dolzhnost { get; set; }

        [Required]
        [Column("gHotelId")]
        public Guid HotelId { get; set; }

        [ForeignKey(nameof(HotelId))]
        public Hotel Hotel { get; set; }

    }
}
