using backend.Models;

namespace backend.DatabaseRepository
{
    public class LocationDB
    {
        // Get All
        public static List<Location> GetAllLocations()
        {
            List<Location> list = new List<Location>();

            Location location1 = new Location();
            location1.LocationId = 1;
            location1.LocationName = "Aarhus";
            list.Add(location1);

            Location location2 = new Location();
            location2.LocationId = 2;
            location2.LocationName = "København";
            list.Add(location2);

            Location location3 = new Location();
            location3.LocationId = 3;
            location3.LocationName = "Silkeborg";
            list.Add(location3);

            return list;
        }

        // Get Single
        public static Location GetLocationById(int LocationId)
        {
            var location = new Location();
            location = GetAllLocations().Where(p => p.LocationId == LocationId).FirstOrDefault();

            return location;
        }

        // Delete
        public static Location DeleteLocationById(int LocationId)
        {
            var location = new Location();
            location = GetAllLocations().Where(p => p.LocationId == LocationId).FirstOrDefault();

            return location;
        }

        // Edit
        public static Location EditLocationById(int LocationId)
        {
            var location = new Location();
            location = GetAllLocations().Where(p => p.LocationId == LocationId).FirstOrDefault();

            return location;
        }
    }
}
