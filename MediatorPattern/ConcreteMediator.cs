using MediatorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class ConcreteMediator : IMediator
    {
        List<IColleague> _colleagues {  get; set; }
        public ConcreteMediator(params IColleague[] colleagues )
        {
            _colleagues = new List<IColleague>(colleagues) ?? throw new ArgumentException();
        }
        public void Send(Message message)
        {
            _colleagues.ForEach(f =>
            {
                f.ReceiveMessage(message);
            });
            Console.WriteLine($"==================== Messages sent to all colleagues ====================");

        }

    }
}
