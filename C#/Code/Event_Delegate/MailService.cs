using System;

namespace ConsoleApp
{
    class MailService
    {
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("MailService: Sending mail..");
        }
    }
}
