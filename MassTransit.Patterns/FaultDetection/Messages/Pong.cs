namespace MassTransit.Patterns.FaultDetection.Messages
{
    using System;
    using MassTransit.ServiceBus;

    [Serializable]
    public class Pong : 
        IMessage
    {
    }
}
