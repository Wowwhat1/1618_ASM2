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
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Check-in date: {room.CheckInDate}");
            Console.WriteLine($"Check-out date: {room.CheckOutDate}");
            Console.WriteLine($"Customer name: {room.CustomerName}");
            Console.WriteLine($"Room size: {room.RoomType}");
            Console.WriteLine($"Bill: {room.RoomPrice}");
        }

        public static void DisplayRoomsInHotel(Hotel hotel)
        {
            Console.WriteLine("ALL ROOMS IN HOTEL");
            foreach (var book in hotel.Rooms)
            {
                DisplayRoomInfo(book);
            }
        }
    }
}
