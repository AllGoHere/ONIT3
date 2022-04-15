using System;
namespace Laba4._5.Managers.Personals
{
    public class CreateOrUpdatePersonals
    {
        public Guid Id { get; set; }

        public string name { get; set; }

        public string lastname { get; set; }

        public string dolzhnost { get; set; }

        public Guid HotelId { get; set; }
    }
}