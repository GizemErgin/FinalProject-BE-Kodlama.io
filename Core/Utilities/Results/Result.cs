using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //Çift parametreli çalışırız ama farklı farklı metotlarda. 
        //Böylece tek tek de çalıştırabiliriz.
        //This --> bu class demek, 
        public Result(bool success, string message): this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

        //getter readonly'dir, sadece constructor'da set edilebilir, normalde set edilmez.
        public bool Success { get; }

        public string Message { get; }
    }
}
