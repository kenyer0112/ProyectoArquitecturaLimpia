using System.ComponentModel.DataAnnotations;

namespace CleanArchitectureHotelHome.Domine
{
    public class User_D : EntityBase
    {
        [MaxLength(300)]
        public string Fullname { get; set; }
        [Required]
        public string LoginName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        public int RoolId { get; set; }
        //[ForeignKey("RoolId")]
        public virtual Rool_D Rool { get; set; }
    }
}
