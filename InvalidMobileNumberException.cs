using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionUserProblem
{
    internal class InvalidMobileNumberException:Exception
    {

        public InvalidMobileNumberException(string message) : base(message)
        {
        }
    }
}
