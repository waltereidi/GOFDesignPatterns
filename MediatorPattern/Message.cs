using MediatorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class Message 
    {
        public string From { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; } = DateTime.Now;
        public Message(IColleague colleague , string content)
        {
            From = colleague.Name;
            Content = content;
        }

    }
}
