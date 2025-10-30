using System.ComponentModel.DataAnnotations;

namespace Portfolio_.NetCore.DAL.Entities
{
    public class Login
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserMail { get; set; }
    }
}
