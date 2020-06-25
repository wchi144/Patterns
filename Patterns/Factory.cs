using System;

namespace FactoryPattern
{
    public class Factory : IFactory
    {
        private readonly ClientBankConnection _createBankConnection;
        private readonly ClientBasicRecord _createBasic;

        public Factory(ClientBankConnection createIdentityAuth, ClientBasicRecord createIdAuth)
        {
            _createBankConnection = createIdentityAuth;
            _createBasic = createIdAuth;
        }

        // only load auth that you need
        // depending on the situation auth type can be retrieved from config
        public IClientRecord GetRecord(RecodeType type)
        {
            switch (type)
            {
                case RecodeType.BankConnection:
                    return _createBankConnection;
                case RecodeType.Basic:
                    return _createBasic;
                default:
                    throw new NotImplementedException($"{type} auth is not implemented");
            }
        }
    }
}