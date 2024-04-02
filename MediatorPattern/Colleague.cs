using MediatorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class Colleague : IColleague
    {
        private readonly IMessageWriter<Message> _messageWriter;
        public string Name { get; set; }
        public Colleague(string name , IMessageWriter<Message> messageWriter) 
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            _messageWriter = messageWriter ?? throw new ArgumentNullException(nameof(messageWriter));
        }
        public void ReceiveMessage(Message message)
        {
            _messageWriter.Write(this ,message );
        }
    }
}
