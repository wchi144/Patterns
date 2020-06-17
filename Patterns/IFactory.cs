namespace FactoryPattern
{
    public interface IFactory
    {
        IClientRecord GetRecord(RecodeType type);
    }
}