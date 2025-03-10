
using Catalog.API.Products.UpdateProduct;
using System.Diagnostics.Eventing.Reader;

namespace Catalog.API.Products.DeleteProduct
{
    public record DeleteProductCommand(Guid Id): ICommand<DeleteProductResult>;

    public record DeleteProductResult(bool IsSuccess);


    public class DeleteProductCommandValidator : AbstractValidator<DeleteProductCommand>
    {
        public DeleteProductCommandValidator()
        {
            RuleFor(u => u.Id).NotEmpty().WithMessage("Product Id is required");
        }
    }


    internal class DeleteProductCommandHandler
        (IDocumentSession session)
        : ICommandHandler<DeleteProductCommand, DeleteProductResult>
    {
        public async Task<DeleteProductResult> Handle(DeleteProductCommand command, CancellationToken cancellationToken)
        {
            session.Delete<Product>(command.Id);
            await session.SaveChangesAsync(cancellationToken);

            return new DeleteProductResult(true);

        }
    }
}
