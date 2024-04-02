using MediatorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class ConsoleMessageWriter : IMessageWriter<Message>
    {
        public ConsoleMessageWriter() { }
        public void Write(IColleague colleague ,Message message)
        {
            Console.WriteLine($"[{ colleague.Name}] received a message ------------------------------");
            Console.WriteLine($"From {message.From} {message.CreatedDate} : {message.Content}");
        }

   
    }
}
