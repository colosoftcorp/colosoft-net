namespace Colosoft.Net
{
    public delegate void DownloadProgressEventHandler(object sender, DownloadProgressChangedEventArgs e);

    public class DownloadProgressChangedEventArgs : System.ComponentModel.ProgressChangedEventArgs
    {
        public long BytesReceived { get; }

        public long TotalBytesToReceive { get; }

        public DownloadProgressChangedEventArgs(long bytesReceived, long totalBytesToReceive)
            : base((int)((100f / totalBytesToReceive) * bytesReceived), null)
        {
            this.BytesReceived = bytesReceived;
            this.TotalBytesToReceive = totalBytesToReceive;
        }
    }
}
