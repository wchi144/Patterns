namespace FactoryPattern
{
    public class ClientBasicRecord : IClientRecord
    {
        public string GetRecord()
        {
            return "Name = Linda";
        }
    }
}
