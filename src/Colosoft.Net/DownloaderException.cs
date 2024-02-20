using System;

namespace Colosoft.Net
{
    /// <summary>
    /// Representa um erro do Downloader.
    /// </summary>
    [Serializable]
    public class DownloaderException : Exception, ICommunicationException
    {
        private readonly CommunicationExceptionDetails details;

        public CommunicationExceptionDetails Details
        {
            get { return this.details; }
        }

        public DownloaderException()
        {
        }

        public DownloaderException(CommunicationExceptionDetails details)
            : base(
                details != null ? details.Message : null,
                details?.InnerException != null ? new DownloaderException(details.InnerException) : null)
        {
            this.details = details;
        }

        public DownloaderException(string message)
            : base(message)
        {
        }

        public DownloaderException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        [System.Security.SecuritySafeCritical]
        protected DownloaderException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }

        [System.Security.SecurityCritical]
        [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.LinkDemand)]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
    }
}
