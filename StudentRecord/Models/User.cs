using EAS.Models;
using System.Data;

namespace StudentRecord.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Balance { get; set; }
        public string? Image { get; set; }
        public string Email { get; set; }
        public string AccessToken { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public DateTime JoinedOn { get; set; }
        public virtual Role Role { get; set; }
        public int RoleId { get; set; }
    }
}
