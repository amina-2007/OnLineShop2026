namespace OnLineShop2026.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PFPPath { get; set; } = "/images/sausage.jpg";

        public User(Guid id, string name, string lastName, string email, string pFPPath)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Email = email;
            PFPPath = pFPPath;
        }
    }

}
