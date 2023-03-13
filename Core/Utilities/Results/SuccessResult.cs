using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {


        public SuccessResult(string message,bool success):base(message,success)
        {
            Console.WriteLine(Message);
        }
        public SuccessResult(string message):base(message,true)
        {
            Console.WriteLine(Message);
        }
        public SuccessResult():base(true)
        {
            Console.WriteLine(Message);
        }
    }
}
