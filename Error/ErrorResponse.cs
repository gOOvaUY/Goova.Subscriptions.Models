﻿using System.Net;

namespace Goova.Suscriptions.Models.Error
{
    public class ErrorResponse
    {
        public HttpStatusCode Code { get; set; }
        public string Message { get; set; }
        public ErrorSubCode SubCode { get; set; }
        public string Type { get; set; }
    }
}
