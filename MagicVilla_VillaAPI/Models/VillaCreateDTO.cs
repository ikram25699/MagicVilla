using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaAPI.Models
{
    public class VillaCreateDTO

    {
        
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Superficie { get; set; }
        public int NbRoom { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        public double Rate { get; set; }
    }
}
