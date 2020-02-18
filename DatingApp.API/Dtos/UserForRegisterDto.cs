using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        
        [Required]
        [StringLength(8, MinimumLength=4, ErrorMessage="Tu password debe ser mayor de 4 caracteres y menor a 8")]
        public string Password { get; set; }
    }

// 619966***
// 174624***
// 206251
// 248550 lote 2
// 362380 lote 2
// 351232 lote 3
// DUMAX
}


