using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ürün adı boş geçemezsiniz!");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Ürün adı en az 3 karakterli olmalıdır!");
            RuleFor(x => x.Stock).NotEmpty().WithMessage("Stok sayısı boş geçemezsiniz!");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat boş geçemezsiniz!");
        }
    }
}