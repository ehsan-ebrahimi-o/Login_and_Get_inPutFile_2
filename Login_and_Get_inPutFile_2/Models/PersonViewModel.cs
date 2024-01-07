using System.ComponentModel.DataAnnotations;

namespace Login_and_Get_inPutFile_2.Models
{
    public class PersonViewModel
    {
        public string FullName { get; set; }

        public string Email { get; set; }

        public string Age { get; set; }

        public string CityBurn { get; set; } 

        [StringLength(500)]
        public string Aboutself { get; set; } = null!;

        public string Mobile { get; set; } 

        public string Password { get; set; }

        public IFormFile File { get; set; } = null!;

        public string ImageName { get; set; }
    }
}
