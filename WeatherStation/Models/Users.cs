﻿using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherStation.Models
{
    public class Users
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public int PersonId { get; set; }
        public int Username { get; set; }
        public string Password { get; set; }
        public DateTime CreateDate { get; set; }
        public bool State { get; set; }
    }
}
