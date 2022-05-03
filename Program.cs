using System;

namespace _1618_ASM2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel();
            Console.WriteLine("Enter the number of room: ");
            int command;
            do
            {
                Presentator.Menu();
                command = int.Parse(Console.ReadLine());
                switch (command)
                {
                    case Command.ADD_ROOM:
                        Console.WriteLine("Enter room ID: ");
                        int roomId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter type room: ");
                        string type = Console.ReadLine();
                        hotel.AddRoom(roomId, ConvertStringToRoomType(type));
                        break;
                    case Command.BOOK_ROOM:
                        
                            Console.WriteLine("Enter room ID: ");
                            int bookRoomId = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter check-in date: ");
                            string checkInDate = Console.ReadLine();
                            Console.WriteLine("Enter check-out date: ");
                            string checkOutDate = Console.ReadLine();
                            Console.WriteLine("Enter customer name: ");
                            string customerName = Console.ReadLine();
                            hotel.BookRoom(bookRoomId, checkInDate, checkOutDate, customerName);
                            Console.WriteLine("Book room succesfully!");
                        break;
                    case Command.SHOW_ALL_ROOM_INFORMATION:
                        Presentator.DisplayRoomsInHotel(hotel);
                        break;
                    case Command.SEARCH_BOOKING_BY_NAME:
                        string name = Console.ReadLine();
                        hotel.SearchBookingByName(name);
                        break;
                    case Command.UPDATE_PRICE_BY_ROOM_TYPE:
                        Console.Write("Enter room type you want to change price: ");
                        string roomType = Console.ReadLine();
                        Console.Write("Enter price you want to change: ");
                        double price = double.Parse(Console.ReadLine());
                        hotel.UpdateRoomPriceByRoomType(ConvertStringToRoomType(roomType), price);
                        Console.WriteLine($"Update price successfully! New price of {roomType} room is {price}");
                        break;
                    case Command.CALCULATE_BILL:
                        break;
                    case Command.CANCEL_ROOM:
                        break;
                    case Command.EXIT_APPLICATION:
                        return;
                }
            } while (command != 6);
        } 

        public static RoomType ConvertStringToRoomType(string type)
        {
            if (type == "Big")
                return RoomType.Big;
            else if (type == "Medium")
                return RoomType.Medium;
            else
                return RoomType.Small;
        }
    }
}
