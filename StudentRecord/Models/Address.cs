namespace StudentRecord.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string line1 { get; set; }
        public string line2 { get; set; }
        public virtual User User { get; set; }
        public int UserId { get; set; }

        public virtual City City { get; set; }
        public int CityId { get; set; } 

    }
}
