using System;
using System.Collections.Generic;
using System.Text;

namespace effectory.questionnaire.application.Exceptions
{
    public class HttpResponseException : Exception
    {
        public HttpResponseException(int statuscode, string message) : base(message)
        {
            StatusCode = statuscode;
        }

        public int StatusCode { get; }
    }
}
