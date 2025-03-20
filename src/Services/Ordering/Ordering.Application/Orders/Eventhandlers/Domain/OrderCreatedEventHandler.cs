namespace Ordering.Application.Orders.Eventhandlers.Domain
{
    public class OrderCreatedEventHandler(ILogger<OrderCreatedEventHandler> logger)
        : INotificationHandler<OrderCreatedEvent>
    {
        public Task Handle(OrderCreatedEvent notification, CancellationToken cancellationToken)
        {
            logger.LogInformation("Domain Even handled: {DomainEvent}", notification.GetType().Name);
            return Task.CompletedTask;
        }
    }
}
