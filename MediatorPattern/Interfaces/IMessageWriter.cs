namespace MediatorPattern.Interfaces
{
    public interface IMessageWriter<T>
    {
        void Write(IColleague colleague ,T message);  
    }
}