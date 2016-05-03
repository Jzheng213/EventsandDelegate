using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsandDelegates
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs arg)
        {
            Console.WriteLine("MessageService: Sending a text Messaging..." + arg.Video.Title);
        }
    }
}
