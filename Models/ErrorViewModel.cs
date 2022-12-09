using System;

namespace Project2.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public string Message { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
