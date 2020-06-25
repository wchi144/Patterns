using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryPattern.Autofac.Services
{
    public class WarmingManager: IAirManager
    {
        public WarmingManager(int temperature)
        {
            
        }
        public void Operate()
        {
            throw new NotImplementedException();
        }
    }
}
