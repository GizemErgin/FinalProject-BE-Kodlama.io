using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorResult : Result
    {
        //base --> result classı
        public ErrorResult(string message) : base(false, message)
        {

        }

        //Tek parametreli ctora gönderdik
        public ErrorResult() : base(false)
        {

        }
    }
}
