using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionUserProblem
{
    internal class InvalidLastNameException:Exception
    {
        public InvalidLastNameException(string message) : base(message)
        {
        
        }
    }
}
