using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ecard.Model
{
    public class Greetings
    {
        [Key]
        public int? ID { get; set; }

        [DisplayName("Friend's Name")]
        [Display(Prompt = "Add your friend's name")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2,
            ErrorMessage = "You must enter between 2-100 characters.")]
        public string friendname { get; set; }

        [DisplayName("Friend's Email")]
        [Display(Prompt = "Add your friend's email address")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2,
            ErrorMessage = "You must enter between 2-100 characters.")]
        public string friendsemail { get; set; }

        [DisplayName("Email Subject")]
        [Display(Prompt = "Enter in your message subject")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2,
            ErrorMessage = "You must enter between 2-100 characters.")]
        public string subject { get; set; }

        [DisplayName("Message")]
        [Display(Prompt = "Add your greeting message.")]
        [Required(ErrorMessage = "Required")]

        public string message { get; set; }

        [DisplayName("Your Name")]
        [Display(Prompt = "Add your name")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2,
            ErrorMessage = "You must enter between 2-100 characters.")]
        public string yourname { get; set; }

        [DisplayName("Your Email")]
        [Display(Prompt = "Add your email")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2,
            ErrorMessage = "You must enter between 2-100 characters.")]
        public string youremail { get; set; }
    }
}
