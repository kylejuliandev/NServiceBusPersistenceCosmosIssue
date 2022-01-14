using NServiceBus;

namespace SampleApp.Messages;

public class OrderPlaced : IEvent
{
    public string OrderId { get; init; }

    public OrderPlaced()
    {
        OrderId = string.Empty;
    }
}
