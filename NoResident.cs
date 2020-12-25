using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment
{
    class NoResident: ArithmeticException
    {
        public NoResident(string message) : base(message)
        {

        }
    }
}
