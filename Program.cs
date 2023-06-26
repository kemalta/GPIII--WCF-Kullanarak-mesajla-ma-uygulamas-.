using System;
using System.ServiceModel;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ChannelFactory<IMessagingService> factory = new ChannelFactory<IMessagingService>(new BasicHttpBinding(), "http://78.191.87.126:8000/MyService"))
            {
                IMessagingService client = factory.CreateChannel();

                Console.Write("Enter the message: ");
                string message = Console.ReadLine();

                client.SendMessage(message);

                Console.WriteLine("Message sent successfully!");
            }

            Console.ReadLine();
        }
    }
}
