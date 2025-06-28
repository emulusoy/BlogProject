using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogProject.EntityLayer.Entities;
using FluentValidation;

namespace BlogProject.BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adı boş geçilemez.");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Kategori adı en az 3 karakter olmalıdır.");
            RuleFor(x => x.CategoryName).MaximumLength(40).WithMessage("Kategori adı en fazla 40 karakter olmalıdır.");
            RuleFor(x => x.CategoryName);
        }
    }
}
