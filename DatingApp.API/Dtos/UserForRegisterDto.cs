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

// 696299 enviado
// 199329 enviado
// 477812 enviado
// 616966 enviado
// 419661 enviado
// 652573 enviado
// 790427 enviado
// 174624 ***
// 493651 enviado
// 904161 enviado
// 206251 aqui esta
// 248550 aqui esta
// 362380 aqui esta
// 351232 ***

