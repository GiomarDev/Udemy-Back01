﻿using System.ComponentModel.DataAnnotations;
using System;

namespace back_end.DTOs
{
    public class ActorCreacionDTO
    {
        [Required]
        [StringLength(maximumLength: 200)]
        public string Nombre { get; set; }
        public string Biografia { get; set; }
        public DateTime FechaNacimiento { get; set; }
        //public string Foto { get; set; }
    }
}