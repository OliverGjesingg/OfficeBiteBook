using backend.Models;
using System.Runtime.Intrinsics.X86;

namespace backend.DatabaseRepository
{
    public class LocationRoomDB
    {
        // Get All
        public static List<LocationRoom> GetAllLocationRooms()
        {
            List<LocationRoom> list = new List<LocationRoom>();
            List<Location> location = LocationDB.GetAllLocations();


            LocationRoom locationRoom1 = new LocationRoom();
            locationRoom1.RoomId = location[0].LocationId;
            locationRoom1.LocationId = 1;
            locationRoom1.RoomName = "Aarhus Kantine";
            locationRoom1.Default = true;
            list.Add(locationRoom1);

            LocationRoom locationRoom2 = new LocationRoom();
            locationRoom2.RoomId = location[1].LocationId;
            locationRoom2.LocationId = 2;
            locationRoom2.RoomName = "Aarhus Streetfood";
            locationRoom2.Default = false;
            list.Add(locationRoom2);

            LocationRoom locationRoom3 = new LocationRoom();
            locationRoom3.RoomId = location[2].LocationId;
            locationRoom3.LocationId = 3;
            locationRoom3.RoomName = "Den Gode Gamle Bager";
            locationRoom3.Default = false;
            list.Add(locationRoom3);

            return list;
        }

        // Get Single
        public static LocationRoom GetLocationRoomById(int LocationRoomId)
        {
            var locationRoom = new LocationRoom();
            locationRoom = GetAllLocationRooms().Where(p => p.LocationId == LocationRoomId).FirstOrDefault();

            return locationRoom;
        }

        // Delete
        public static LocationRoom DeleteLocationRoomById(int LocationRoomId)
        {
            var locationRoom = new LocationRoom();
            locationRoom = GetAllLocationRooms().Where(p => p.LocationId == LocationRoomId).FirstOrDefault();

            return locationRoom;
        }

        // Edit
        public static LocationRoom EditLocationRoomById(int LocationRoomId)
        {
            var locationRoom = new LocationRoom();
            locationRoom = GetAllLocationRooms().Where(p => p.LocationId == LocationRoomId).FirstOrDefault();

            return locationRoom;
        }
    }
}