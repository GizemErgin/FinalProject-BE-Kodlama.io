using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel viodler için başlangıç.
    //Yapılan işlemlerin sonuçları için kullanacağız.
    public interface IResult
    {
        bool Success { get; }     //İşlemin kontrolü
        string Message { get; }   //İşlemin mesajı
    }
}
