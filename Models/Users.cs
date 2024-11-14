namespace test_backend.Models
{
    public class Users
    {
        public int id { get; set; }
        public string? fname { get; set; }
        public string? lname { get; set; }
        public string? email { get; set; }
        public string? password { get; set; }
        public int? role_id { get; set; }
        public DateTime? created_date { get; set; }
    }

    public class LoginRequest
    {
        public string? email { get; set; }
        public string? password { get; set; }
    }
}