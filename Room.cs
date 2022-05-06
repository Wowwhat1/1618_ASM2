using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1618_ASM2
{
    internal class Room
    {

        public bool IsEmpty { get; set; } = true;
        public int RoomNumber { get; set; }
        public int DaysStay { get; set; }
        public string CustomerName { get; set; }
        public double RoomPrice { get; set; } = 100;
        public RoomType RoomType { get; set; }

        public Room()
        {
            IsEmpty = true;
        }

        public Room(int roomNumber, RoomType type)
        {
            RoomNumber = roomNumber;
            RoomType = type;
        }

        public Room(int daysStay, string customerName)
        {
            DaysStay = daysStay;
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

        public void BookRoom()
        {
            IsEmpty = false;
        }

        public void FreeRoom()
        {
            IsEmpty = true;
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
