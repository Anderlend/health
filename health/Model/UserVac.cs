namespace health.Model
{
    public class UserVacinations
    {

        public List<UserVac> UserVac { get; set; }
    }

    public class UserVac
    {
        public DateTimeOffset Data { get; set; }
        public string VacSlug { get; set; }
        public string[] Symptomatic { get; set; }
    }
}
