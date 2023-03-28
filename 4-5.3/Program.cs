using System;

namespace _4_5._3
{
    public class HotelReservation
    {
        private string name;
        private DateTime checkInDate;
        private DateTime checkOutDate;
        private int numberOfGuests;
        private bool isCancelled;

        public HotelReservation(string name, DateTime checkInDate, DateTime checkOutDate, int numberOfGuests)
        {
            this.name = name;
            this.checkInDate = checkInDate;
            this.checkOutDate = checkOutDate;
            this.numberOfGuests = numberOfGuests;
            this.isCancelled = false;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime CheckInDate
        {
            get { return checkInDate; }
            set { checkInDate = value; }
        }

        public DateTime CheckOutDate
        {
            get { return checkOutDate; }
            set { checkOutDate = value; }
        }

        public int NumberOfGuests
        {
            get { return numberOfGuests; }
            set { numberOfGuests = value; }
        }

        public bool IsCancelled
        {
            get { return isCancelled; }
            set { isCancelled = value; }
        }

        public int GetTotalNights()
        {
            return (int)(checkOutDate - checkInDate).TotalDays;
        }

        public decimal GetTotalPrice(decimal pricePerNight)
        {
            return GetTotalNights() * pricePerNight;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 호텔 예약 객체 생성
            HotelReservation reservation = new HotelReservation("하태욱", new DateTime(2023, 4, 1), new DateTime(2023, 4, 5), 3);

            // 예약 정보 출력
            Console.WriteLine("예약자 이름: {0}", reservation.Name);
            Console.WriteLine("체크인 날짜: {0}", reservation.CheckInDate.ToShortDateString());
            Console.WriteLine("체크아웃 날짜: {0}", reservation.CheckOutDate.ToShortDateString());
            Console.WriteLine("예약 인원 수: {0}", reservation.NumberOfGuests);
            Console.WriteLine("예약 취소 여부: {0}", reservation.IsCancelled);
        }
    }
}
