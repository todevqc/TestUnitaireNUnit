using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT_Project
{
    public interface IServiceSMS
    {
        public int EnvoyerSMS(SMS monSMS);
    }
}
