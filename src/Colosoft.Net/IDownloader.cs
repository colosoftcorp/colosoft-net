using System;

namespace Colosoft.Net
{
    public interface IDownloader : IDisposable
    {
        event DownloadProgressEventHandler ProgressChanged;

        event DownloadCompletedEventHandler DownloadCompleted;

        bool IsBusy { get; }

        void RunAsync(object userState);

        void CancelAsync();
    }
}
