using System;

namespace UnderstandingOfDiamond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var someTicket = new Ticket<TicketAlanas>();
            Console.WriteLine(someTicket.Type);
            var aTicket = new Ticket<TicketAlanas>(1, "QQQ", 1, 50); // TicketAlanas
            var aOrder = new Order()
            {
                Name = "AAA",
                Created = DateTime.Now,
                Ticket = aTicket,
            };

            var bTicket = new Ticket<TicketTheater>(); //  TicketTheater
            var bOrder = new Order()
            {
                Name = "BBB",
                Created = DateTime.Now,
                Ticket = bTicket
            };
        }
        
        class Ticket<TTicketType>: ITicket
        {
            public Ticket()
            {
                
            }

            public Ticket(int ID, string Name, int RowNo, int SeatNo)
            {
                if(Type.GetType() == typeof(TicketAlanas)) {

                }
            }
            public TTicketType Type { get; private set; }
            //public int Id { get; set; }
            //public string Name { get; set; }
            //public int Row { get; set; }
            //public int SeatNo { get; set; }
        }

        class TicketAlanas: ITicket
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        class TicketTheater: ITicket
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Row { get; set; }
            public int SeatNo { get; set; }
        }

        class Order
        {
            public string Name { get; set; }
            public DateTime Created { get; set; }
            public ITicket Ticket { get; set; }
        }
    }
}   
