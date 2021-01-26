using System;

namespace Yuan.WebSockets
{
    public class SubProtocolNegotiationFailureException : Exception
    {
        public SubProtocolNegotiationFailureException() : base() { }
        
        public SubProtocolNegotiationFailureException(string message) : base(message) {}
        
        public SubProtocolNegotiationFailureException(string message, Exception innerException) : base(message, innerException) {}
    }
}
