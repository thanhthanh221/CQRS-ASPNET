using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Back_end_API.Dtos
{
    public class PresonUpdateDto
    {
        // Dto chỉ để truyền từ sever -> Ui hoặc ngược lại
        [Required]
        public string? FirstName {get; set;}
        [Required]
        public string? LastName {get; set;}

    }
}