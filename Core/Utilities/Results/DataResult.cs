using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T> where T : class, new()
    {
        public T Data { get; }


        public DataResult(T data, string message, bool success) : base(message, success)
        {
            // Aşağıya this ile referans veremediğimizden buraya ayrıca data set edildi.
            Data = data;
        }

        public DataResult(T data, bool success) : base(success)
        {
            Data = data;
        }    
        

    }
}
