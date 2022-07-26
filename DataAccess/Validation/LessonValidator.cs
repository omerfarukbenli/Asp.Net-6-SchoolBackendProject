using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Validation
{
    public class LessonValidator : AbstractValidator<Lesson>
    {
        public LessonValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Ders adı boş olamaz");
            RuleFor(p => p.Name).MinimumLength(3).WithMessage("Ders adı en az 3 karakter olmalıdır");
        }
    }
}
