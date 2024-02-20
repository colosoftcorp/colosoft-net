using System;

namespace Colosoft.Net
{
    public delegate void DownloadCompletedEventHandler(object sender, DownloadCompletedEventArgs e);

    public class DownloadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        public System.IO.Stream Result { get; }

        public DownloadCompletedEventArgs(Exception error, bool cancelled, object userState, System.IO.Stream result)
            : base(error, cancelled, userState)
        {
            this.Result = result;
        }
    }
}
