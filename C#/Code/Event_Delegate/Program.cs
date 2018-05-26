using System;
using System.Threading;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] arg)
        {
            var video = new Video { Title = "Video1"};
            var videoEncodeer = new VideoEncoder(); // Publisher
            var mailService = new MailService();    // Subscriber

            videoEncodeer.VideoEncoded += mailService.OnVideoEncoded;

            videoEncodeer.Encode(video);
        }
    }

    class VideoEncoder
    {
        // 1. Define a delegate
        // 2. Define a event based on the delegate
        // 3. Raise the event

        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        public event VideoEncodedEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            OnVideoEncoded();
        }

        protected virtual void OnVideoEncoded()
        {
            VideoEncoded?.Invoke(this, EventArgs.Empty);
        }

    }

}












