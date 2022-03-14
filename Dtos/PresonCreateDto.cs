using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Back_end_API.Dtos
{
    public class PresonCreateDto
    {
        [Required]
        public string? FirstName {get; set;}
        [Required]
        public string? LastName {get; set;}

    }
}