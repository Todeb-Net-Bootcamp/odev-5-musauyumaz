using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Concrete
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(string message, T data) : base(true, message, data)
        {
        }
        public SuccessDataResult(T data) : base(true, data)
        {
        }
        public SuccessDataResult() : base(true, default)
        {
        }
        public SuccessDataResult(string message) : base(true, message, default)
        {
        }
    }
}
