using System;

namespace Colosoft.Net
{
    public class CommunicationExceptionDetails
    {
        public string Message { get; set; }

        public string StackTrace { get; set; }

        public CommunicationExceptionDetails InnerException { get; set; }

        public CommunicationExceptionDetails()
        {
        }

        public CommunicationExceptionDetails(Exception exception)
            : this(exception?.Message, exception?.StackTrace, exception?.InnerException)
        {
        }

        public CommunicationExceptionDetails(string message, string stackTrace, Exception innerException)
        {
            this.Message = message;
            this.StackTrace = stackTrace;

            if (innerException != null)
            {
                this.InnerException = new CommunicationExceptionDetails(message, innerException.StackTrace, innerException.InnerException);
            }
        }
    }
}
