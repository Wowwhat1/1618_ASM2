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

        public bool BookRoom(int roomId, int daysStay, string customerName)
        {
            if (!IsAvailable(roomId))
            { 
                return false;
            }
            var findRoomId = Rooms.FirstOrDefault(t => t.RoomNumber == roomId);
            findRoomId.DaysStay = daysStay;
            findRoomId.CustomerName = customerName;
            findRoomId.BookRoom();
            return true;
        }

        public bool IsAvailable(int roomId)
        {
            var room = Rooms.FirstOrDefault(t => t.RoomNumber == roomId);
            if (room == null) return false;
            return room.IsEmpty;
        }

        public List<Room> SearchBookingByName(string name)
        { 
            return Rooms.Where(x => x.CustomerName.Contains(name)).ToList();
        }

        public List<Room> SearchRoomById(int id)
        {
            return Rooms.Where(x => x.RoomNumber == id).ToList();
        }

        public void UpdateRoomPriceByRoomType(RoomType roomType, double newRoomPrice)
        {
            for (int i = 0; i < Rooms.Count; i++)
            {
                if (Rooms[i].RoomType == roomType)
                {
                    Rooms[i].SetPrice(newRoomPrice);
                }
            }
        }

        public double CalculateBill(int roomId)
        {
            var room = Rooms.FirstOrDefault(t => t.RoomNumber == roomId);
            return room.DaysStay * room.RoomPrice;
        }

        public bool CancelRoom(int roomId)
        {
            if (IsAvailable(roomId))
            { 
                return false;
            }
            var findRoomId = SearchRoomById(roomId);
            foreach (var room in findRoomId)
            {
                room.DaysStay = 0;
                room.CustomerName = "None";
                room.FreeRoom();
            }
            return true;
        }

        public bool IsRoomExist()
        {
            if (Rooms.Count == 0)
            {
                return false;
            } 
            else 
                return true;
        }

        public bool IsRoomBooked()
        {
            var room = Rooms.FirstOrDefault(t => t.IsEmpty == true);
            if (room.IsEmpty == true)
            {
                return false;
            }
            return true;
        }

        public bool IsDuplicated(int roomId)
        {
            if (Rooms.Count != 0)
            {
                foreach (var room in Rooms)
                {
                    if (room.RoomNumber == roomId)
                    {
                        Console.WriteLine("The room with the ID had already exist");
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
