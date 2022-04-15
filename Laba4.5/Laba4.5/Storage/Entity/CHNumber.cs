using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Laba4._5.Storage.Entity
{
    [Table("tblCHnumber")]
    public class CHnumber : IUniqueId
    {
        [Key]
        [Required]
        [Column("gId")]
        public Guid Id { get; set; }

        [Required]
        [Column("iRooms")]
        public int rooms { get; set; }

        [Required]
        [Column("iSleep")]
        public int sleep { get; set; }

        [Required]
        [Column("gHotelId")]
        public Guid HotelId { get; set; }

        [ForeignKey(nameof(HotelId))]
        public Hotel Hotel { get; set; }

        public CHnumber()
        {
        }
    }
}
