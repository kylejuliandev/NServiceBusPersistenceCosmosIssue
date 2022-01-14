using Microsoft.Extensions.Logging;
using NServiceBus;
using SampleApp.Messages;

namespace SampleApp.Handlers;

public class OrderPlacedHandler : IHandleMessages<OrderPlaced>
{
    private readonly ILogger<OrderPlacedHandler> _logger;

    public OrderPlacedHandler(ILogger<OrderPlacedHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(OrderPlaced message, IMessageHandlerContext context)
    {
        _logger.LogInformation("Order Placed {orderId}", message.OrderId);

        return Task.CompletedTask;
    }
}
