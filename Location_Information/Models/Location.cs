namespace Location_Information.Models
{
    public class Location
    {
        public  int id { get; set; }
        public string? location_name { get; set; }
        public DateTime opening_time { get; set; }
        public DateTime ending_time { get;set; }

    }
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
