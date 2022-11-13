using Application.PersonOperation.Commands.AddBasketItem;
using FluentValidation;

namespace Application.Validation.BasketValidator
{
    public class CreateBasketRequestValidator : AbstractValidator<AddBasketItemCommandRequest>
    {
        public CreateBasketRequestValidator()
        {
            RuleFor(b => b.ProductId)
                .NotEmpty()
                .NotNull()
                .WithMessage("Yanlış Parametre");
            RuleFor(b => b.Quantity).GreaterThanOrEqualTo(1);
        }
    }
}
