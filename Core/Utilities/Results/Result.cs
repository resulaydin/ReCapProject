using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public bool Success { get; }
        public string Message { get; }

        public Result(string message, bool success):this(success)
        {
            Message = message;
            //Message= message;
            Console.WriteLine(Message);
        }

        public Result(bool success) {
            Success = success;
            //Console.WriteLine(Success);
        }
    }
}
