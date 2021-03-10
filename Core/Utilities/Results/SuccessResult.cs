using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        //base --> result classı
        public SuccessResult(string message):base(true, message)
        {

        }

        //Tek parametreli ctora gönderdik
        public SuccessResult():base(true)
        {

        }
    }
}
