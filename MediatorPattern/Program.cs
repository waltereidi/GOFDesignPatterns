// See https://aka.ms/new-console-template for more information
using MediatorPattern;
using MediatorPattern.Interfaces;
using System.Xml.Linq;
public class Program
{
    public static IMessageWriter<Message> _messageWriter = new ConsoleMessageWriter();
    public static IColleague colleague1 = new Colleague("Eduardo", _messageWriter);
    public static IColleague colleague2 = new Colleague("Ronaldo", _messageWriter);
    public static IColleague colleague3 = new Colleague("Alexandre", _messageWriter);
    public static void Main(string[] args)
    {
        //Stating a new chat room 
        IMediator chatRoom = new ConcreteMediator( colleague1 , colleague2 , colleague3 );

        //Sending random messages 
        Message msg1 = new Message(colleague1, "Hello , starting a conversation");
        chatRoom.Send(msg1);

        Message msg2 = new Message(colleague1, "Hello , there");
        chatRoom.Send(msg2);

        Message msg3 = new Message(colleague1, "Hello , Nice to meet you");
        chatRoom.Send(msg3);

        Message msg4 = new Message(colleague1, "End of conversation");
        chatRoom.Send(msg4);

        Console.ReadLine();

    }
}





