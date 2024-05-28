﻿using System.ComponentModel.DataAnnotations;

namespace GadevangTennisklub.Models
{
    public class Member
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        [Required]
        public string MembershipType { get; set; }
    }
}
