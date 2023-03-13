using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T> where T : class, new()
    {

        public SuccessDataResult(T data, string message) : base(data, message, true)
        {
        }
        public SuccessDataResult(T data) : base(data, true)
        {
        }

        public SuccessDataResult(string message) : base(default,message, true)// default ile new SuccessDataResult<T>() gönderildi.
        {
        }

        public SuccessDataResult() : base(default, true)// default ile new SuccessDataResult<T>() gönderildi.
        {
        }
    }
}
