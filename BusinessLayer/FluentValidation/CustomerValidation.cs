using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.FluentValidation
{
    public class CustomerValidation : AbstractValidator<Customer>
    {
        public CustomerValidation()
        {
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir Bilgisi Boş Geçilemez!");
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim Boş Geçilemez!");
        }
    }
}