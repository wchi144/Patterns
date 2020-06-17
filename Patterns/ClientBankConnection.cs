using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class ClientBankConnection : IClientRecord
    {
        public string GetRecord()
        {
            return "Connection = ANZ";
        }
    }
}
