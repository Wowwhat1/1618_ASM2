using System.Collections.Generic;
using System;
using System.Linq;

namespace _1618_ASM2
{
    internal class Hotel
    {
        public List<Room> Rooms { get; set; }
        public string Name { get; set; }

        public Hotel()
        {
            Rooms = new List<Room>();
        }

        public Hotel(string name)
        {
            Name = name;
            Rooms = new List<Room>();
        }

        public void AddRoom(int roomId, RoomType type)
        {
            Room room = new Room(roomId, type);
            Rooms.Add(room);
        }

        public bool BookRoom(int roomId, string checkInDate, string checkOutDate, string customerName)
        {
            if (!IsAvailable(roomId))
            {
                return false;
            }
            var room = Rooms.FirstOrDefault(t => t.RoomNumber == roomId);
            room.CheckInDate = checkInDate;
            room.CheckOutDate = checkOutDate;
            room.CustomerName = customerName;
            return true;
        }

        public bool IsAvailable(int roomid)
        {
            var room = Rooms.FirstOrDefault(t => t.RoomNumber == roomid);
            return room.IsEmpty;
        }

        public List<Room> SearchBookingByName(string name)
        {
            return Rooms.Where(x => x.CustomerName.Contains(name)).ToList();
        }

        public void UpdateRoomPriceByRoomType(RoomType roomType, double roomPrice)
        {
            for (int i = 0; i < Rooms.Count - 1; i++)
            {
                if (Rooms[i].RoomType == roomType)
                {
                    Rooms[i].SetPrice(roomPrice);
                }
            }
        }
    }
}
