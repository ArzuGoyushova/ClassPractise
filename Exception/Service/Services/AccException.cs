using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class AccException : Exception
    {
        public AccException(string message) : base(message)
        {

        }
    }
}
