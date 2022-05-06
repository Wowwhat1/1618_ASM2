using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1618_ASM2
{
    internal class Presentator
    {
        public static void Menu()
        {
            Console.WriteLine(" ==============MENU============== ");
            Console.WriteLine("|  1. Add Room                   |");
            Console.WriteLine("|  2. Book Room                  |");
            Console.WriteLine("|  3. Show room information      |");
            Console.WriteLine("|  4. Search booking by name     |");
            Console.WriteLine("|  5. Update price by room type  |");
            Console.WriteLine("|  6. Calculate bill             |");
            Console.WriteLine("|  7. Cancel Room                |");
            Console.WriteLine("|  8. Exit                       |");
            Console.WriteLine(" ================================ ");
        }

        public static void DisplayRoomInfo(Room room)
        {
            Console.WriteLine($"Days stay: {room.DaysStay}");
            Console.WriteLine($"Customer name: {room.CustomerName}");
            Console.WriteLine($"Room size: {room.RoomType}");
        }

        public static void DisplayRoomsInHotel(Hotel hotel)
        {
            Console.WriteLine("ALL ROOMS IN HOTEL");
            foreach (var room in hotel.Rooms)
            {
                if (room.IsEmpty)
                {
                    Console.WriteLine($" --------ROOM {room.RoomNumber}-------- ");
                    Console.WriteLine( "      AVAILABLE");
                }
                else
                {
                    Console.WriteLine($" --------ROOM {room.RoomNumber}-------- ");
                    DisplayRoomInfo(room);
                }
            }
        }

        public static void DisplayRooms(List<Room> rooms)
        {
            if (rooms.Count == 0)
            {
                Console.WriteLine("Nothing Found ...");
            }
            else
            {
                foreach (var room in rooms)
                {
                    Console.WriteLine("--------------------------------------");
                    DisplayRoomInfo(room);
                }
            }
        }
    }
}
