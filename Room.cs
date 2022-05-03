using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1618_ASM2
{
    internal class Room
    {
       
        public bool IsEmpty { get; set; }
        public int RoomNumber { get; set; }
        public string CheckInDate { get; set; }
        public string CheckOutDate { get; set; }
        public string CustomerName { get; set; }
        public double RoomPrice { get; set; }
        public RoomType RoomType { get; set; }

        public Room()
        {
            IsEmpty = true;
            RoomPrice = 10;
        }

        public Room(int roomNumber, RoomType type)
        {
            RoomNumber = roomNumber;
            RoomType = type;
        }

        public Room(string checkInDate, string checkOutDate, string customerName)
        {
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            CustomerName = customerName;
        }

        public Room(RoomType type, double roomPrice)
        {
            RoomType = type;
            if (type == RoomType.Small)
            {
                RoomPrice = roomPrice;
            }
            else if (type == RoomType.Big)
            {
                RoomPrice = roomPrice;
            } else if (type == RoomType.Medium)
            {
                RoomPrice = roomPrice;
            }
        }

        public void SetPrice(double price)
        {
            RoomPrice = price;
        }
    }

    public enum RoomType
    {
        Big,
        Medium,
        Small,
        Unknow
    }
}
