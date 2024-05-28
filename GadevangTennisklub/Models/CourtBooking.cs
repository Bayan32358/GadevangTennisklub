using System;
using System.ComponentModel.DataAnnotations;

namespace GadevangTennisklub.Models
{
    public class CourtBooking
    {
        public int Id { get; set; }

        [Required]
        public int MemberId { get; set; }

        [Required]
        public string Court { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public TimeSpan Time { get; set; }

        public Member Member { get; set; }
    }
}
