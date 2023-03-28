using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepElektroniczny1501
{
    public class ProductValidator : AbstractValidator<produkt>
    {
        public ProductValidator()
        { 
            RuleFor(produkt=>produkt.model).NotEmpty().WithMessage("Wypełnij pole model");
            RuleFor(produkt=>produkt.nazwa).NotEmpty().WithMessage("Wypełnij pole nazwa");
            RuleFor(produkt=>produkt.ilosc_dostepna).GreaterThan(-1).WithMessage("Dostępna ilość produktów musi być liczbą nieujemną");
            RuleFor(produkt=>produkt.cena).GreaterThan(-1).WithMessage("Cena produktu musi być liczbą nieujemną");   
        }
    }
}
