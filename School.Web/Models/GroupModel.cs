﻿using System.ComponentModel.DataAnnotations;

namespace School.Models
{
    public class GroupModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Capacity { get; set; }
    }
}
