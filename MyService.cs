using System;
using System.ServiceModel;

namespace MyNamespace
{
    [ServiceContract]
    public interface IMessagingService
    {
        [OperationContract]
        void SendMessage(string message);
    }

    public class MyService : IMessagingService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Received Message: " + message);
        }
    }
}
