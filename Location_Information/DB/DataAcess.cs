using Location_Information.Models;

namespace Location_Information.DB
{
    public static class DataAcess
    {
        public static List<Location> location{get;set;}=new List<Location>();
        public static List<Location> GetLocation()
        {
            //location.Add(new Location { id = 1, location_name = "SuperMarket", opening_time = Convert.ToDateTime("10:00"), ending_time = Convert.ToDateTime("10:00") });
            List<Location> LocationInform = new List<Location>
            { new Location{ id = 1, location_name = "SuperMarket", opening_time = Convert.ToDateTime("10:00"), ending_time  = Convert.ToDateTime("10:00")} ,
             new Location{ id = 2, location_name = "ElectronicMarket", opening_time = Convert.ToDateTime("10:00"), ending_time  = Convert.ToDateTime("10:00")}};
            return LocationInform;
        }

        
    }
}
