namespace Ordering.Application.Orders.Eventhandlers
{
    public class OrderUpdatedEventHandler(ILogger<OrderUpdatedEvent> logger)
        : INotificationHandler<OrderUpdatedEvent>
    {
        public Task Handle(OrderUpdatedEvent notification, CancellationToken cancellationToken)
        {
            logger.LogInformation("Domain Even handled: {DomainEvent}", notification.GetType().Name);
            return Task.CompletedTask;
        }
    }
}
