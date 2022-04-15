using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Laba4._5.Storage.Entity
{
    [Table("tblCHhotel")]
    public class Hotel : IUniqueId
    {
        [Key]
        [Required]
        [Column("gId")]
        public Guid Id { get; set; }

        [Required]
        [Column("iFloors")]
        public int floors {get ; set ;}

        [Required]
        [Column("iKolNum")]
        public int KolNum { get; set; }

        [Required]
        [Column("szName")]
        public string name { get; set; }

        [Required]
        [Column("iKolSot")]
        public int kolsot {get ; set;}

    public Hotel()
        {
        }
    }
}
