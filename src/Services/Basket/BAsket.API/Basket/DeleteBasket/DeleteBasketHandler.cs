namespace Basket.API.Basket.DeleteBasket
{
    public record DeleteBasketCommand(string Username) : ICommand<DeleteBasketResult>;

    public record DeleteBasketResult(bool IsSuccess);

    public class DeleteBasketCommandValidator : AbstractValidator<DeleteBasketCommand>
    {
        public DeleteBasketCommandValidator()
        {
            RuleFor(x => x.Username).NotEmpty().WithName("Username is required");
        }
    }

    public class DeleteBasketCommandHandler(IBasketRepository repository) 
        : ICommandHandler<DeleteBasketCommand, DeleteBasketResult>
    {
        public async Task<DeleteBasketResult> Handle(DeleteBasketCommand command, CancellationToken cancellationToken)
        {
            // ToDo: delete basket from database and cache
            // session.Delete<Product>(command.Username);
            await repository.DeleteBasket(command.Username, cancellationToken);

            return new DeleteBasketResult(true);
        }
    }
}
