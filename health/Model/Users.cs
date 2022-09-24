namespace health.Model
{
    public class GetUsers
    {
        public User[] Users { get; set; }
    }

    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTimeOffset BirthDate { get; set; }
    }
}
