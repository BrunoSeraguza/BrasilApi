using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace IntegraBrasilApi.Dto
{
    public class ResponseGeneric<T> where T : class
    {
        public HttpStatusCode HttpStatusCode { get; set; }
        public T? Response{ get; set; }
        public ExpandoObject? ReturnError { get; set; }
    }
}