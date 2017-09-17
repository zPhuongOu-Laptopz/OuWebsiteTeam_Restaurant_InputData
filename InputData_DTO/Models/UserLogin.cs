using System.ComponentModel.DataAnnotations;

namespace InputData_DTO.Models
{
    public class UserLogin
    {
        [Required]
        [StringLength(30)]
        public string username { get; set; }
        [Required]
        [StringLength(30)]
        public string password { get; set; }
        [Required]
        public bool isStatus { get; set; }

        public UserLogin()
        {
           
        }

        public UserLogin(string us, string pw, bool stt)
        {
            this.username = us;
            this.password = pw;
            this.isStatus = stt;
        }
    }
}
