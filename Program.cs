using System;

namespace _1618_ASM2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel();
            int command;
            do
            {
                Presentator.Menu();
                Console.Write("Enter your choice: ");
                command = int.Parse(Console.ReadLine());
                switch (command)
                {
                    case Command.ADD_ROOM:
                        Console.Write("Enter the number of rooms you want to add: ");
                        int numberOfRoom = int.Parse(Console.ReadLine());
                        for (int i = 0; i < numberOfRoom; i++)
                        {
                            Console.Write("Enter room ID: ");
                            int roomId = int.Parse(Console.ReadLine());
                            while (!hotel.IsDuplicated(roomId))
                            {
                                Console.Write("Duplicated room number ,enter room ID again: ");
                                roomId = int.Parse(Console.ReadLine());
                            }
                            Console.Write("Enter type room: ");
                            string type = Console.ReadLine();
                            hotel.AddRoom(roomId, ConvertStringToRoomType(type));
                        }
                        break;
                    case Command.BOOK_ROOM:
                        if (!hotel.IsRoomExist())
                        {
                            Console.WriteLine("There's no room exist!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Enter room ID: ");
                            int bookRoomId = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter days stay: ");
                            int daysStay = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter customer name: ");
                            string customerName = Console.ReadLine();
                            if (hotel.BookRoom(bookRoomId, daysStay, customerName))
                            {
                                Console.WriteLine("Book room succesfully!");
                            }
                            else
                            {
                                Console.WriteLine("Room is unavailable, please choose another room!");
                            }
                            break;
                        }
                    case Command.SHOW_ALL_ROOM_INFORMATION:
                        Presentator.DisplayRoomsInHotel(hotel);
                        break;
                    case Command.SEARCH_BOOKING_BY_NAME:
                        Console.WriteLine("Enter customer name: ");
                        string name = Console.ReadLine();
                        var searchCustomer = hotel.SearchBookingByName(name);
                        Presentator.DisplayRooms(searchCustomer);
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
                        Console.WriteLine("Enter room ID: ");
                        int calculateBillRoomId = int.Parse(Console.ReadLine());
                        if (hotel.IsAvailable(calculateBillRoomId))
                        {
                            Console.WriteLine("Invalid room ID!");
                        } else
                        {
                            Console.WriteLine($"Total bill of room {calculateBillRoomId}: {hotel.CalculateBill(calculateBillRoomId)}$");
                        }
                        break;
                    case Command.CANCEL_ROOM:
                        Console.WriteLine("Enter room ID: ");
                        int cancelRoomId = int.Parse(Console.ReadLine());
                        if (hotel.CancelRoom(cancelRoomId))
                        {
                            Console.WriteLine("Cancel room succesfully!");
                        }
                        else
                        {
                            Console.WriteLine("Room isn't booked!");
                        }
                        break;
                    case Command.EXIT_APPLICATION:
                        return;
                }
            } while (command != Command.EXIT_APPLICATION);
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
