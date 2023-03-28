using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepElektroniczny1501
{
    public class OrderProductValidator : AbstractValidator<zamowienie_produkt>
    {
        public OrderProductValidator()
        {
            RuleFor(zamowienie_produkt => zamowienie_produkt.ilosc).GreaterThan(0).WithMessage("Liczba zamawianych produktów musi być dodatnia");
            RuleFor(zamowienie_produkt => zamowienie_produkt.cena).GreaterThan(0).WithMessage("Cena zamawianych produktów musi być liczbą dodatnią");
        }
    }
}
